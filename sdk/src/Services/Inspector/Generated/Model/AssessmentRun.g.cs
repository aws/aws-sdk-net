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

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// A snapshot of an Amazon Inspector assessment run that contains the findings of the
    /// assessment run .
    /// 
    ///  
    /// <para>
    /// Used as the response element in the <a>DescribeAssessmentRuns</a> action.
    /// </para>
    /// </summary>
    public partial class AssessmentRun
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the assessment run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 300)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AssessmentTemplateArn. 
        /// <para>
        /// The ARN of the assessment template that is associated with the assessment run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 300)]
        public string AssessmentTemplateArn { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentTemplateArn property is set.
        /// </summary>
        internal bool IsSetAssessmentTemplateArn() => this.AssessmentTemplateArn != null;

        /// <summary>
        /// Gets and sets the property CompletedAt. 
        /// <para>
        /// The assessment run completion time that corresponds to the rules packages evaluation
        /// completion time or failure.
        /// </para>
        /// </summary>
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Checks to see if the CompletedAt property is set.
        /// </summary>
        internal bool IsSetCompletedAt() => this.CompletedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when <a>StartAssessmentRun</a> was called.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DataCollected. 
        /// <para>
        /// A Boolean value (true or false) that specifies whether the process of collecting data
        /// from the agents is completed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? DataCollected { get; set; }

        /// <summary>
        /// Checks to see if the DataCollected property is set.
        /// </summary>
        internal bool IsSetDataCollected() => this.DataCollected.HasValue;

        /// <summary>
        /// Gets and sets the property DurationInSeconds. 
        /// <para>
        /// The duration of the assessment run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 180, Max = 86400)]
        public int? DurationInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the DurationInSeconds property is set.
        /// </summary>
        internal bool IsSetDurationInSeconds() => this.DurationInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property FindingCounts. 
        /// <para>
        /// Provides a total count of generated findings per severity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public Dictionary<string, int> FindingCounts { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;

        /// <summary>
        /// Checks to see if the FindingCounts property is set.
        /// </summary>
        internal bool IsSetFindingCounts() => this.FindingCounts != null && (this.FindingCounts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The auto-generated name for the assessment run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 140)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Notifications. 
        /// <para>
        /// A list of notifications for the event subscriptions. A notification about a particular
        /// generated finding is added to this list only once.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 50)]
        public List<AssessmentRunNotification> Notifications { get; set; } = AWSConfigs.InitializeCollections ? new List<AssessmentRunNotification>() : null;

        /// <summary>
        /// Checks to see if the Notifications property is set.
        /// </summary>
        internal bool IsSetNotifications() => this.Notifications != null && (this.Notifications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RulesPackageArns. 
        /// <para>
        /// The rules packages selected for the assessment run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public List<string> RulesPackageArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RulesPackageArns property is set.
        /// </summary>
        internal bool IsSetRulesPackageArns() => this.RulesPackageArns != null && (this.RulesPackageArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The time when <a>StartAssessmentRun</a> was called.
        /// </para>
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the assessment run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AssessmentRunState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateChangedAt. 
        /// <para>
        /// The last time when the assessment run's state changed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StateChangedAt { get; set; }

        /// <summary>
        /// Checks to see if the StateChangedAt property is set.
        /// </summary>
        internal bool IsSetStateChangedAt() => this.StateChangedAt.HasValue;

        /// <summary>
        /// Gets and sets the property StateChanges. 
        /// <para>
        /// A list of the assessment run state changes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 50)]
        public List<AssessmentRunStateChange> StateChanges { get; set; } = AWSConfigs.InitializeCollections ? new List<AssessmentRunStateChange>() : null;

        /// <summary>
        /// Checks to see if the StateChanges property is set.
        /// </summary>
        internal bool IsSetStateChanges() => this.StateChanges != null && (this.StateChanges.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UserAttributesForFindings. 
        /// <para>
        /// The user-defined attributes that are assigned to every generated finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 10)]
        public List<Attribute> UserAttributesForFindings { get; set; } = AWSConfigs.InitializeCollections ? new List<Attribute>() : null;

        /// <summary>
        /// Checks to see if the UserAttributesForFindings property is set.
        /// </summary>
        internal bool IsSetUserAttributesForFindings() => this.UserAttributesForFindings != null && (this.UserAttributesForFindings.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
