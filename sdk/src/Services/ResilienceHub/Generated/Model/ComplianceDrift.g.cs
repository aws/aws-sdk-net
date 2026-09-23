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

namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Indicates the compliance drifts (recovery time objective (RTO) and recovery point
    /// objective (RPO)) that were detected for an assessed entity.
    /// </summary>
    public partial class ComplianceDrift
    {
        /// <summary>
        /// Gets and sets the property ActualReferenceId. 
        /// <para>
        /// Assessment identifier that is associated with this drift item.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ActualReferenceId { get; set; }

        /// <summary>
        /// Checks to see if the ActualReferenceId property is set.
        /// </summary>
        internal bool IsSetActualReferenceId() => this.ActualReferenceId != null;

        /// <summary>
        /// Gets and sets the property ActualValue. 
        /// <para>
        /// Actual compliance value of the entity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, DisruptionCompliance> ActualValue { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, DisruptionCompliance>() : null;

        /// <summary>
        /// Checks to see if the ActualValue property is set.
        /// </summary>
        internal bool IsSetActualValue() => this.ActualValue != null && (this.ActualValue.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// Identifier of your application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string AppId { get; set; }

        /// <summary>
        /// Checks to see if the AppId property is set.
        /// </summary>
        internal bool IsSetAppId() => this.AppId != null;

        /// <summary>
        /// Gets and sets the property AppVersion. 
        /// <para>
        /// Published version of your application on which drift was detected.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string AppVersion { get; set; }

        /// <summary>
        /// Checks to see if the AppVersion property is set.
        /// </summary>
        internal bool IsSetAppVersion() => this.AppVersion != null;

        /// <summary>
        /// Gets and sets the property DiffType. 
        /// <para>
        /// Difference type between actual and expected recovery point objective (RPO) and recovery
        /// time objective (RTO) values. Currently, Resilience Hub supports only <c>NotEqual</c>
        /// difference type.
        /// </para>
        /// </summary>
        public DifferenceType DiffType { get; set; }

        /// <summary>
        /// Checks to see if the DiffType property is set.
        /// </summary>
        internal bool IsSetDiffType() => this.DiffType != null;

        /// <summary>
        /// Gets and sets the property DriftType. 
        /// <para>
        /// The type of drift detected. Currently, Resilience Hub supports only <b>ApplicationCompliance</b>
        /// drift type.
        /// </para>
        /// </summary>
        public DriftType DriftType { get; set; }

        /// <summary>
        /// Checks to see if the DriftType property is set.
        /// </summary>
        internal bool IsSetDriftType() => this.DriftType != null;

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// Identifier of an entity in which drift was detected. For compliance drift, the entity
        /// ID can be either application ID or the AppComponent ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string EntityId { get; set; }

        /// <summary>
        /// Checks to see if the EntityId property is set.
        /// </summary>
        internal bool IsSetEntityId() => this.EntityId != null;

        /// <summary>
        /// Gets and sets the property EntityType. 
        /// <para>
        /// The type of entity in which drift was detected. For compliance drifts, Resilience
        /// Hub supports <c>AWS::ResilienceHub::AppComponent</c> and <c>AWS::ResilienceHub::Application</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string EntityType { get; set; }

        /// <summary>
        /// Checks to see if the EntityType property is set.
        /// </summary>
        internal bool IsSetEntityType() => this.EntityType != null;

        /// <summary>
        /// Gets and sets the property ExpectedReferenceId. 
        /// <para>
        /// Assessment identifier of a previous assessment of the same application version. Resilience
        /// Hub uses the previous assessment (associated with the reference identifier) to compare
        /// the compliance with the current assessment to identify drifts.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ExpectedReferenceId { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedReferenceId property is set.
        /// </summary>
        internal bool IsSetExpectedReferenceId() => this.ExpectedReferenceId != null;

        /// <summary>
        /// Gets and sets the property ExpectedValue. 
        /// <para>
        /// The expected compliance value of an entity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, DisruptionCompliance> ExpectedValue { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, DisruptionCompliance>() : null;

        /// <summary>
        /// Checks to see if the ExpectedValue property is set.
        /// </summary>
        internal bool IsSetExpectedValue() => this.ExpectedValue != null && (this.ExpectedValue.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
