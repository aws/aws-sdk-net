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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Represents a resilience finding from a failure mode assessment.
    /// </summary>
    public partial class Finding
    {
        private string _comment;
        private string _description;
        private FailureCategory _failureCategory;
        private string _findingId;
        private List<InfrastructureAndCodeRecommendation> _infrastructureAndCodeRecommendations = AWSConfigs.InitializeCollections ? new List<InfrastructureAndCodeRecommendation>() : null;
        private string _name;
        private List<ObservabilityRecommendation> _observabilityRecommendations = AWSConfigs.InitializeCollections ? new List<ObservabilityRecommendation>() : null;
        private PolicyComponent _policyComponent;
        private string _reasoning;
        private List<string> _serviceFunctions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private FindingSeverity _severity;
        private FindingStatus _status;
        private List<TestingRecommendation> _testingRecommendations = AWSConfigs.InitializeCollections ? new List<TestingRecommendation>() : null;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// A user-provided comment about the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property Description.
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FailureCategory. 
        /// <para>
        /// The failure category of the finding.
        /// </para>
        /// </summary>
        public FailureCategory FailureCategory
        {
            get { return this._failureCategory; }
            set { this._failureCategory = value; }
        }

        // Check to see if FailureCategory property is set
        internal bool IsSetFailureCategory()
        {
            return this._failureCategory != null;
        }

        /// <summary>
        /// Gets and sets the property FindingId. 
        /// <para>
        /// The unique identifier of the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string FindingId
        {
            get { return this._findingId; }
            set { this._findingId = value; }
        }

        // Check to see if FindingId property is set
        internal bool IsSetFindingId()
        {
            return this._findingId != null;
        }

        /// <summary>
        /// Gets and sets the property InfrastructureAndCodeRecommendations. 
        /// <para>
        /// Infrastructure and code recommendations to address the finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<InfrastructureAndCodeRecommendation> InfrastructureAndCodeRecommendations
        {
            get { return this._infrastructureAndCodeRecommendations; }
            set { this._infrastructureAndCodeRecommendations = value; }
        }

        // Check to see if InfrastructureAndCodeRecommendations property is set
        internal bool IsSetInfrastructureAndCodeRecommendations()
        {
            return this._infrastructureAndCodeRecommendations != null && (this._infrastructureAndCodeRecommendations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the finding.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ObservabilityRecommendations. 
        /// <para>
        /// Observability recommendations to address the finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<ObservabilityRecommendation> ObservabilityRecommendations
        {
            get { return this._observabilityRecommendations; }
            set { this._observabilityRecommendations = value; }
        }

        // Check to see if ObservabilityRecommendations property is set
        internal bool IsSetObservabilityRecommendations()
        {
            return this._observabilityRecommendations != null && (this._observabilityRecommendations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PolicyComponent. 
        /// <para>
        /// The policy component associated with the finding.
        /// </para>
        /// </summary>
        public PolicyComponent PolicyComponent
        {
            get { return this._policyComponent; }
            set { this._policyComponent = value; }
        }

        // Check to see if PolicyComponent property is set
        internal bool IsSetPolicyComponent()
        {
            return this._policyComponent != null;
        }

        /// <summary>
        /// Gets and sets the property Reasoning. 
        /// <para>
        /// The reasoning behind the finding.
        /// </para>
        /// </summary>
        public string Reasoning
        {
            get { return this._reasoning; }
            set { this._reasoning = value; }
        }

        // Check to see if Reasoning property is set
        internal bool IsSetReasoning()
        {
            return this._reasoning != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceFunctions. 
        /// <para>
        /// The service functions associated with the finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<string> ServiceFunctions
        {
            get { return this._serviceFunctions; }
            set { this._serviceFunctions = value; }
        }

        // Check to see if ServiceFunctions property is set
        internal bool IsSetServiceFunctions()
        {
            return this._serviceFunctions != null && (this._serviceFunctions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity of the finding.
        /// </para>
        /// </summary>
        public FindingSeverity Severity
        {
            get { return this._severity; }
            set { this._severity = value; }
        }

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this._severity != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the finding.
        /// </para>
        /// </summary>
        public FindingStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TestingRecommendations. 
        /// <para>
        /// Testing recommendations to address the finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<TestingRecommendation> TestingRecommendations
        {
            get { return this._testingRecommendations; }
            set { this._testingRecommendations = value; }
        }

        // Check to see if TestingRecommendations property is set
        internal bool IsSetTestingRecommendations()
        {
            return this._testingRecommendations != null && (this._testingRecommendations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the finding was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}