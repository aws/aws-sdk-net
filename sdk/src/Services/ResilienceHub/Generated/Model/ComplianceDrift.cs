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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
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
        private string _actualReferenceId;
        private Dictionary<string, DisruptionCompliance> _actualValue = AWSConfigs.InitializeCollections ? new Dictionary<string, DisruptionCompliance>() : null;
        private string _appId;
        private string _appVersion;
        private DifferenceType _diffType;
        private DriftType _driftType;
        private string _entityId;
        private string _entityType;
        private string _expectedReferenceId;
        private Dictionary<string, DisruptionCompliance> _expectedValue = AWSConfigs.InitializeCollections ? new Dictionary<string, DisruptionCompliance>() : null;

        /// <summary>
        /// Gets and sets the property ActualReferenceId. 
        /// <para>
        /// Assessment identifier that is associated with this drift item.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ActualReferenceId
        {
            get { return this._actualReferenceId; }
            set { this._actualReferenceId = value; }
        }

        // Check to see if ActualReferenceId property is set
        internal bool IsSetActualReferenceId()
        {
            return this._actualReferenceId != null;
        }

        /// <summary>
        /// Gets and sets the property ActualValue. 
        /// <para>
        /// Actual compliance value of the entity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, DisruptionCompliance> ActualValue
        {
            get { return this._actualValue; }
            set { this._actualValue = value; }
        }

        // Check to see if ActualValue property is set
        internal bool IsSetActualValue()
        {
            return this._actualValue != null && (this._actualValue.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// Identifier of your application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string AppId
        {
            get { return this._appId; }
            set { this._appId = value; }
        }

        // Check to see if AppId property is set
        internal bool IsSetAppId()
        {
            return this._appId != null;
        }

        /// <summary>
        /// Gets and sets the property AppVersion. 
        /// <para>
        /// Published version of your application on which drift was detected.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string AppVersion
        {
            get { return this._appVersion; }
            set { this._appVersion = value; }
        }

        // Check to see if AppVersion property is set
        internal bool IsSetAppVersion()
        {
            return this._appVersion != null;
        }

        /// <summary>
        /// Gets and sets the property DiffType. 
        /// <para>
        /// Difference type between actual and expected recovery point objective (RPO) and recovery
        /// time objective (RTO) values. Currently, Resilience Hub supports only <c>NotEqual</c>
        /// difference type.
        /// </para>
        /// </summary>
        public DifferenceType DiffType
        {
            get { return this._diffType; }
            set { this._diffType = value; }
        }

        // Check to see if DiffType property is set
        internal bool IsSetDiffType()
        {
            return this._diffType != null;
        }

        /// <summary>
        /// Gets and sets the property DriftType. 
        /// <para>
        /// The type of drift detected. Currently, Resilience Hub supports only <b>ApplicationCompliance</b>
        /// drift type.
        /// </para>
        /// </summary>
        public DriftType DriftType
        {
            get { return this._driftType; }
            set { this._driftType = value; }
        }

        // Check to see if DriftType property is set
        internal bool IsSetDriftType()
        {
            return this._driftType != null;
        }

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// Identifier of an entity in which drift was detected. For compliance drift, the entity
        /// ID can be either application ID or the AppComponent ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string EntityId
        {
            get { return this._entityId; }
            set { this._entityId = value; }
        }

        // Check to see if EntityId property is set
        internal bool IsSetEntityId()
        {
            return this._entityId != null;
        }

        /// <summary>
        /// Gets and sets the property EntityType. 
        /// <para>
        /// The type of entity in which drift was detected. For compliance drifts, Resilience
        /// Hub supports <c>AWS::ResilienceHub::AppComponent</c> and <c>AWS::ResilienceHub::Application</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string EntityType
        {
            get { return this._entityType; }
            set { this._entityType = value; }
        }

        // Check to see if EntityType property is set
        internal bool IsSetEntityType()
        {
            return this._entityType != null;
        }

        /// <summary>
        /// Gets and sets the property ExpectedReferenceId. 
        /// <para>
        /// Assessment identifier of a previous assessment of the same application version. Resilience
        /// Hub uses the previous assessment (associated with the reference identifier) to compare
        /// the compliance with the current assessment to identify drifts.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ExpectedReferenceId
        {
            get { return this._expectedReferenceId; }
            set { this._expectedReferenceId = value; }
        }

        // Check to see if ExpectedReferenceId property is set
        internal bool IsSetExpectedReferenceId()
        {
            return this._expectedReferenceId != null;
        }

        /// <summary>
        /// Gets and sets the property ExpectedValue. 
        /// <para>
        /// The expected compliance value of an entity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, DisruptionCompliance> ExpectedValue
        {
            get { return this._expectedValue; }
            set { this._expectedValue = value; }
        }

        // Check to see if ExpectedValue property is set
        internal bool IsSetExpectedValue()
        {
            return this._expectedValue != null && (this._expectedValue.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}