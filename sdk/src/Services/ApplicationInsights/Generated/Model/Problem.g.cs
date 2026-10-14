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

namespace Amazon.ApplicationInsights.Model
{
    /// <summary>
    /// Describes a problem that is detected by correlating observations.
    /// </summary>
    public partial class Problem
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID for the owner of the resource group affected by
        /// the problem.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property AffectedResource. 
        /// <para>
        /// The resource affected by the problem.
        /// </para>
        /// </summary>
        public string AffectedResource { get; set; }

        /// <summary>
        /// Checks to see if the AffectedResource property is set.
        /// </summary>
        internal bool IsSetAffectedResource() => this.AffectedResource != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time when the problem ended, in epoch seconds.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property Feedback. 
        /// <para>
        /// Feedback provided by the user about the problem.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public Dictionary<string, string> Feedback { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Feedback property is set.
        /// </summary>
        internal bool IsSetFeedback() => this.Feedback != null && (this.Feedback.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the problem.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 38, Max = 38)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Insights. 
        /// <para>
        /// A detailed analysis of the problem using machine learning.
        /// </para>
        /// </summary>
        public string Insights { get; set; }

        /// <summary>
        /// Checks to see if the Insights property is set.
        /// </summary>
        internal bool IsSetInsights() => this.Insights != null;

        /// <summary>
        /// Gets and sets the property LastRecurrenceTime. 
        /// <para>
        ///  The last time that the problem reoccurred after its last resolution. 
        /// </para>
        /// </summary>
        public DateTime? LastRecurrenceTime { get; set; }

        /// <summary>
        /// Checks to see if the LastRecurrenceTime property is set.
        /// </summary>
        internal bool IsSetLastRecurrenceTime() => this.LastRecurrenceTime.HasValue;

        /// <summary>
        /// Gets and sets the property RecurringCount. 
        /// <para>
        ///  The number of times that the same problem reoccurred after the first time it was
        /// resolved. 
        /// </para>
        /// </summary>
        public long? RecurringCount { get; set; }

        /// <summary>
        /// Checks to see if the RecurringCount property is set.
        /// </summary>
        internal bool IsSetRecurringCount() => this.RecurringCount.HasValue;

        /// <summary>
        /// Gets and sets the property ResolutionMethod. 
        /// <para>
        /// Specifies how the problem was resolved. If the value is <c>AUTOMATIC</c>, the system
        /// resolved the problem. If the value is <c>MANUAL</c>, the user resolved the problem.
        /// If the value is <c>UNRESOLVED</c>, then the problem is not resolved.
        /// </para>
        /// </summary>
        public ResolutionMethod ResolutionMethod { get; set; }

        /// <summary>
        /// Checks to see if the ResolutionMethod property is set.
        /// </summary>
        internal bool IsSetResolutionMethod() => this.ResolutionMethod != null;

        /// <summary>
        /// Gets and sets the property ResourceGroupName. 
        /// <para>
        /// The name of the resource group affected by the problem.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceGroupName property is set.
        /// </summary>
        internal bool IsSetResourceGroupName() => this.ResourceGroupName != null;

        /// <summary>
        /// Gets and sets the property SeverityLevel. 
        /// <para>
        /// A measure of the level of impact of the problem.
        /// </para>
        /// </summary>
        public SeverityLevel SeverityLevel { get; set; }

        /// <summary>
        /// Checks to see if the SeverityLevel property is set.
        /// </summary>
        internal bool IsSetSeverityLevel() => this.SeverityLevel != null;

        /// <summary>
        /// Gets and sets the property ShortName. 
        /// <para>
        ///  The short name of the problem associated with the SNS notification. 
        /// </para>
        /// </summary>
        public string ShortName { get; set; }

        /// <summary>
        /// Checks to see if the ShortName property is set.
        /// </summary>
        internal bool IsSetShortName() => this.ShortName != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time when the problem started, in epoch seconds.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the problem.
        /// </para>
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The name of the problem.
        /// </para>
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property Visibility. 
        /// <para>
        /// Specifies whether or not you can view the problem. Updates to ignored problems do
        /// not generate notifications.
        /// </para>
        /// </summary>
        public Visibility Visibility { get; set; }

        /// <summary>
        /// Checks to see if the Visibility property is set.
        /// </summary>
        internal bool IsSetVisibility() => this.Visibility != null;
    }
}
