/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// The record of the incident that's created when an incident occurs.
    /// </summary>
    public partial class IncidentRecord
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the incident record.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 1000)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AutomationExecutions. 
        /// <para>
        /// The runbook, or automation document, that's run at the beginning of the incident.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 100)]
        public List<AutomationExecution> AutomationExecutions { get; set; } = AWSConfigs.InitializeCollections ? new List<AutomationExecution>() : null;

        /// <summary>
        /// Checks to see if the AutomationExecutions property is set.
        /// </summary>
        internal bool IsSetAutomationExecutions() => this.AutomationExecutions != null && (this.AutomationExecutions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ChatChannel. 
        /// <para>
        /// The chat channel used for collaboration during an incident.
        /// </para>
        /// </summary>
        public ChatChannel ChatChannel { get; set; }

        /// <summary>
        /// Checks to see if the ChatChannel property is set.
        /// </summary>
        internal bool IsSetChatChannel() => this.ChatChannel != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp for when Incident Manager created the incident record.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DedupeString. 
        /// <para>
        /// The string Incident Manager uses to prevent duplicate incidents from being created
        /// by the same incident in the same account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 1000)]
        public string DedupeString { get; set; }

        /// <summary>
        /// Checks to see if the DedupeString property is set.
        /// </summary>
        internal bool IsSetDedupeString() => this.DedupeString != null;

        /// <summary>
        /// Gets and sets the property Impact. 
        /// <para>
        /// The impact of the incident on customers and applications.
        /// </para>
        ///  
        /// <para>
        ///  <b>Supported impact codes</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>1</c> - Critical
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>2</c> - High
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>3</c> - Medium
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>4</c> - Low
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>5</c> - No Impact
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 5)]
        public int? Impact { get; set; }

        /// <summary>
        /// Checks to see if the Impact property is set.
        /// </summary>
        internal bool IsSetImpact() => this.Impact.HasValue;

        /// <summary>
        /// Gets and sets the property IncidentRecordSource. 
        /// <para>
        /// Details about the action that started the incident.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IncidentRecordSource IncidentRecordSource { get; set; }

        /// <summary>
        /// Checks to see if the IncidentRecordSource property is set.
        /// </summary>
        internal bool IsSetIncidentRecordSource() => this.IncidentRecordSource != null;

        /// <summary>
        /// Gets and sets the property LastModifiedBy. 
        /// <para>
        /// Who modified the incident most recently.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 1000)]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedBy property is set.
        /// </summary>
        internal bool IsSetLastModifiedBy() => this.LastModifiedBy != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The timestamp for when the incident was most recently modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property NotificationTargets. 
        /// <para>
        /// The Amazon SNS targets that are notified when updates are made to an incident.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<NotificationTargetItem> NotificationTargets { get; set; } = AWSConfigs.InitializeCollections ? new List<NotificationTargetItem>() : null;

        /// <summary>
        /// Checks to see if the NotificationTargets property is set.
        /// </summary>
        internal bool IsSetNotificationTargets() => this.NotificationTargets != null && (this.NotificationTargets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResolvedTime. 
        /// <para>
        /// The timestamp for when the incident was resolved. This appears as a timeline event.
        /// </para>
        /// </summary>
        public DateTime? ResolvedTime { get; set; }

        /// <summary>
        /// Checks to see if the ResolvedTime property is set.
        /// </summary>
        internal bool IsSetResolvedTime() => this.ResolvedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the incident.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IncidentRecordStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Summary. 
        /// <para>
        /// The summary of the incident. The summary is a brief synopsis of what occurred, what's
        /// currently happening, and context of the incident.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 8000)]
        public string Summary { get; set; }

        /// <summary>
        /// Checks to see if the Summary property is set.
        /// </summary>
        internal bool IsSetSummary() => this.Summary != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the incident.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 200)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
