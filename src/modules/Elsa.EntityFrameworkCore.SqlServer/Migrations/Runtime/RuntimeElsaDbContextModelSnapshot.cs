﻿// <auto-generated />
using System;
using Elsa.EntityFrameworkCore.Modules.Runtime;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Elsa.EntityFrameworkCore.SqlServer.Migrations.Runtime
{
    [DbContext(typeof(RuntimeElsaDbContext))]
    partial class RuntimeElsaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Elsa")
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Elsa.Workflows.Core.State.WorkflowState", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CorrelationId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Data")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DefinitionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("DefinitionVersion")
                        .HasColumnType("int");

                    b.Property<string>("DefinitionVersionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<long>("ExecutionLogSequence")
                        .HasColumnType("bigint");

                    b.Property<DateTimeOffset?>("FinishedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SubStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("CorrelationId")
                        .HasDatabaseName("IX_WorkflowState_CorrelationId");

                    b.HasIndex("CreatedAt")
                        .HasDatabaseName("IX_WorkflowState_CreatedAt");

                    b.HasIndex("DefinitionId")
                        .HasDatabaseName("IX_WorkflowState_DefinitionId");

                    b.HasIndex("DefinitionVersionId")
                        .HasDatabaseName("IX_WorkflowState_DefinitionVersionId");

                    b.HasIndex("UpdatedAt")
                        .HasDatabaseName("IX_WorkflowState_UpdatedAt");

                    b.HasIndex("Status", "DefinitionId")
                        .HasDatabaseName("IX_WorkflowState_Status_DefinitionId");

                    b.HasIndex("Status", "SubStatus")
                        .HasDatabaseName("IX_WorkflowState_Status_SubStatus");

                    b.HasIndex("Status", "SubStatus", "DefinitionId", "DefinitionVersion")
                        .HasDatabaseName("IX_WorkflowState_Status_SubStatus_DefinitionId_DefinitionVersion");

                    b.ToTable("WorkflowStates", "Elsa");
                });

            modelBuilder.Entity("Elsa.Workflows.Runtime.Entities.ActivityExecutionRecord", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ActivityId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ActivityName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ActivityType")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ActivityTypeVersion")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("CompletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("HasBookmarks")
                        .HasColumnType("bit");

                    b.Property<string>("SerializedActivityState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SerializedException")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SerializedOutputs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SerializedPayload")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("StartedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("WorkflowInstanceId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId")
                        .HasDatabaseName("IX_ActivityExecutionRecord_ActivityId");

                    b.HasIndex("ActivityName")
                        .HasDatabaseName("IX_ActivityExecutionRecord_ActivityName");

                    b.HasIndex("ActivityType")
                        .HasDatabaseName("IX_ActivityExecutionRecord_ActivityType");

                    b.HasIndex("ActivityTypeVersion")
                        .HasDatabaseName("IX_ActivityExecutionRecord_ActivityTypeVersion");

                    b.HasIndex("CompletedAt")
                        .HasDatabaseName("IX_ActivityExecutionRecord_CompletedAt");

                    b.HasIndex("HasBookmarks")
                        .HasDatabaseName("IX_ActivityExecutionRecord_HasBookmarks");

                    b.HasIndex("StartedAt")
                        .HasDatabaseName("IX_ActivityExecutionRecord_StartedAt");

                    b.HasIndex("Status")
                        .HasDatabaseName("IX_ActivityExecutionRecord_Status");

                    b.HasIndex("WorkflowInstanceId")
                        .HasDatabaseName("IX_ActivityExecutionRecord_WorkflowInstanceId");

                    b.HasIndex("ActivityType", "ActivityTypeVersion")
                        .HasDatabaseName("IX_ActivityExecutionRecord_ActivityType_ActivityTypeVersion");

                    b.ToTable("ActivityExecutionRecords", "Elsa");
                });

            modelBuilder.Entity("Elsa.Workflows.Runtime.Entities.StoredBookmark", b =>
                {
                    b.Property<string>("BookmarkId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ActivityInstanceId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ActivityTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CorrelationId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Hash")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SerializedPayload")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkflowInstanceId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("BookmarkId");

                    b.HasIndex(new[] { "ActivityInstanceId" }, "IX_StoredBookmark_ActivityInstanceId");

                    b.HasIndex(new[] { "ActivityTypeName" }, "IX_StoredBookmark_ActivityTypeName");

                    b.HasIndex(new[] { "ActivityTypeName", "Hash" }, "IX_StoredBookmark_ActivityTypeName_Hash");

                    b.HasIndex(new[] { "ActivityTypeName", "Hash", "WorkflowInstanceId" }, "IX_StoredBookmark_ActivityTypeName_Hash_WorkflowInstanceId");

                    b.HasIndex(new[] { "CreatedAt" }, "IX_StoredBookmark_CreatedAt");

                    b.HasIndex(new[] { "Hash" }, "IX_StoredBookmark_Hash");

                    b.HasIndex(new[] { "WorkflowInstanceId" }, "IX_StoredBookmark_WorkflowInstanceId");

                    b.ToTable("Bookmarks", "Elsa");
                });

            modelBuilder.Entity("Elsa.Workflows.Runtime.Entities.StoredTrigger", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ActivityId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hash")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SerializedPayload")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkflowDefinitionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("WorkflowDefinitionVersionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Hash")
                        .HasDatabaseName("IX_StoredTrigger_Hash");

                    b.HasIndex("Name")
                        .HasDatabaseName("IX_StoredTrigger_Name");

                    b.HasIndex("WorkflowDefinitionId")
                        .HasDatabaseName("IX_StoredTrigger_WorkflowDefinitionId");

                    b.HasIndex("WorkflowDefinitionVersionId")
                        .HasDatabaseName("IX_StoredTrigger_WorkflowDefinitionVersionId");

                    b.ToTable("Triggers", "Elsa");
                });

            modelBuilder.Entity("Elsa.Workflows.Runtime.Entities.WorkflowExecutionLogRecord", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ActivityId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ActivityInstanceId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ActivityName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ActivityType")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ActivityTypeVersion")
                        .HasColumnType("int");

                    b.Property<string>("EventName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NodeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentActivityInstanceId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<long>("Sequence")
                        .HasColumnType("bigint");

                    b.Property<string>("SerializedActivityState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SerializedPayload")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Source")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("Timestamp")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("WorkflowDefinitionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("WorkflowDefinitionVersionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("WorkflowInstanceId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("WorkflowVersion")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_ActivityId");

                    b.HasIndex("ActivityInstanceId")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_ActivityInstanceId");

                    b.HasIndex("ActivityName")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_ActivityName");

                    b.HasIndex("ActivityType")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_ActivityType");

                    b.HasIndex("ActivityTypeVersion")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_ActivityTypeVersion");

                    b.HasIndex("EventName")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_EventName");

                    b.HasIndex("ParentActivityInstanceId")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_ParentActivityInstanceId");

                    b.HasIndex("Sequence")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_Sequence");

                    b.HasIndex("Timestamp")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_Timestamp");

                    b.HasIndex("WorkflowDefinitionId")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_WorkflowDefinitionId");

                    b.HasIndex("WorkflowDefinitionVersionId")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_WorkflowDefinitionVersionId");

                    b.HasIndex("WorkflowInstanceId")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_WorkflowInstanceId");

                    b.HasIndex("WorkflowVersion")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_WorkflowVersion");

                    b.HasIndex("ActivityType", "ActivityTypeVersion")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_ActivityType_ActivityTypeVersion");

                    b.HasIndex("Timestamp", "Sequence")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_Timestamp_Sequence");

                    b.ToTable("WorkflowExecutionLogRecords", "Elsa");
                });

            modelBuilder.Entity("Elsa.Workflows.Runtime.Entities.WorkflowInboxMessage", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ActivityInstanceId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ActivityTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CorrelationId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("ExpiresAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Hash")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SerializedBookmarkPayload")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SerializedInput")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkflowInstanceId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "ActivityInstanceId" }, "IX_WorkflowInboxMessage_ActivityInstanceId");

                    b.HasIndex(new[] { "ActivityTypeName" }, "IX_WorkflowInboxMessage_ActivityTypeName");

                    b.HasIndex(new[] { "CorrelationId" }, "IX_WorkflowInboxMessage_CorrelationId");

                    b.HasIndex(new[] { "CreatedAt" }, "IX_WorkflowInboxMessage_CreatedAt");

                    b.HasIndex(new[] { "ExpiresAt" }, "IX_WorkflowInboxMessage_ExpiresAt");

                    b.HasIndex(new[] { "Hash" }, "IX_WorkflowInboxMessage_Hash");

                    b.HasIndex(new[] { "WorkflowInstanceId" }, "IX_WorkflowInboxMessage_WorkflowInstanceId");

                    b.ToTable("WorkflowInboxMessages", "Elsa");
                });
#pragma warning restore 612, 618
        }
    }
}
