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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
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
namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Summary of an optimization profile, including its configuration, metadata, and audit
    /// information.
    /// </summary>
    public partial class AgentProfileSummary
    {
        private List<AggregationConfiguration> _aggregationConfiguration = AWSConfigs.InitializeCollections ? new List<AggregationConfiguration>() : null;
        private string _arn;
        private string _businessOverview;
        private DateTime? _createdAt;
        private string _createdBy;
        private bool? _deletionProtection;
        private string _description;
        private string _displayName;
        private bool? _eligibleForArchitectureGeneration;
        private bool? _eligibleForScheduledGeneration;
        private string _executionRoleArn;
        private Dictionary<string, string> _fieldErrors = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private DateTime? _lastModifiedAt;
        private string _lastModifiedBy;
        private string _name;
        private List<string> _pillars = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AggregationConfiguration. 
        /// <para>
        /// The aggregation configuration that defines which Amazon Web Services accounts and
        /// Regions to analyze.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<AggregationConfiguration> AggregationConfiguration
        {
            get { return this._aggregationConfiguration; }
            set { this._aggregationConfiguration = value; }
        }

        // Check to see if AggregationConfiguration property is set
        internal bool IsSetAggregationConfiguration()
        {
            return this._aggregationConfiguration != null && (this._aggregationConfiguration.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the optimization profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property BusinessOverview. 
        /// <para>
        /// The business overview for this profile.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=512)]
        public string BusinessOverview
        {
            get { return this._businessOverview; }
            set { this._businessOverview = value; }
        }

        // Check to see if BusinessOverview property is set
        internal bool IsSetBusinessOverview()
        {
            return this._businessOverview != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the profile was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The identifier of the user or system that created this profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// Indicates whether deletion protection is enabled for the profile.
        /// </para>
        /// </summary>
        public bool? DeletionProtection
        {
            get { return this._deletionProtection; }
            set { this._deletionProtection = value; }
        }

        // Check to see if DeletionProtection property is set
        internal bool IsSetDeletionProtection()
        {
            return this._deletionProtection.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the profile.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=512)]
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
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the profile shown to users.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=3, Max=128)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property EligibleForArchitectureGeneration. 
        /// <para>
        /// Indicates whether the profile is valid for manual architecture generation.
        /// </para>
        /// </summary>
        public bool? EligibleForArchitectureGeneration
        {
            get { return this._eligibleForArchitectureGeneration; }
            set { this._eligibleForArchitectureGeneration = value; }
        }

        // Check to see if EligibleForArchitectureGeneration property is set
        internal bool IsSetEligibleForArchitectureGeneration()
        {
            return this._eligibleForArchitectureGeneration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EligibleForScheduledGeneration. 
        /// <para>
        /// Indicates whether the profile is valid for scheduled recommendation generation.
        /// </para>
        /// </summary>
        public bool? EligibleForScheduledGeneration
        {
            get { return this._eligibleForScheduledGeneration; }
            set { this._eligibleForScheduledGeneration = value; }
        }

        // Check to see if EligibleForScheduledGeneration property is set
        internal bool IsSetEligibleForScheduledGeneration()
        {
            return this._eligibleForScheduledGeneration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The ARN of the IAM execution role used for recommendation actions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string ExecutionRoleArn
        {
            get { return this._executionRoleArn; }
            set { this._executionRoleArn = value; }
        }

        // Check to see if ExecutionRoleArn property is set
        internal bool IsSetExecutionRoleArn()
        {
            return this._executionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property FieldErrors. 
        /// <para>
        /// A map of field paths to error messages for invalid or missing input fields.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public Dictionary<string, string> FieldErrors
        {
            get { return this._fieldErrors; }
            set { this._fieldErrors = value; }
        }

        // Check to see if FieldErrors property is set
        internal bool IsSetFieldErrors()
        {
            return this._fieldErrors != null && (this._fieldErrors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedAt. 
        /// <para>
        /// The timestamp when the profile was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedAt
        {
            get { return this._lastModifiedAt; }
            set { this._lastModifiedAt = value; }
        }

        // Check to see if LastModifiedAt property is set
        internal bool IsSetLastModifiedAt()
        {
            return this._lastModifiedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedBy. 
        /// <para>
        /// The identifier of the user or system that last modified this profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string LastModifiedBy
        {
            get { return this._lastModifiedBy; }
            set { this._lastModifiedBy = value; }
        }

        // Check to see if LastModifiedBy property is set
        internal bool IsSetLastModifiedBy()
        {
            return this._lastModifiedBy != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The system name of the profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=128)]
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
        /// Gets and sets the property Pillars. 
        /// <para>
        /// The Well-Architected Tool Framework pillars associated with this profile.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<string> Pillars
        {
            get { return this._pillars; }
            set { this._pillars = value; }
        }

        // Check to see if Pillars property is set
        internal bool IsSetPillars()
        {
            return this._pillars != null && (this._pillars.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the profile.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}