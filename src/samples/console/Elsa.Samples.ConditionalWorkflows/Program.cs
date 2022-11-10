﻿using Elsa.Extensions;
using Elsa.Workflows.Core.Activities;
using Elsa.Workflows.Core.Models;
using Elsa.Workflows.Core.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

// Setup service container.
var services = new ServiceCollection();

// Add Elsa services.
services.AddElsa();

// Configure logging.
services.AddLogging(logging => logging.AddConsole().SetMinimumLevel(LogLevel.Debug));

// Build service container.
var serviceProvider = services.BuildServiceProvider();

// Declare a workflow variable for use in the workflow.
var ageVariable = new Variable<string>();

// Declare a workflow.
var workflow = new Sequence
{
    // Register the variable.
    Variables = { ageVariable }, 
    
    // Setup the sequence of activities to run.
    Activities =
    {
        new WriteLine("Please tell me your age:"), 
        new ReadLine(ageVariable), // Stores user input into the provided variable.,
        new If
        {
            // If aged 18 or up, beer is provided, soda otherwise.
            Condition = new Input<bool>(context => ageVariable.Get<int>(context) < 18),
            Then = new WriteLine("Enjoy your soda!"),
            Else = new WriteLine("Enjoy your beer!")
        },
        new WriteLine("Come again!")
    }
};

// Resolve a workflow runner to run the workflow.
var workflowRunner = serviceProvider.GetRequiredService<IWorkflowRunner>();

// Run the workflow.
await workflowRunner.RunAsync(workflow);