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
    /// Container for the parameters to the UpdateAgentProfile operation.
    /// Updates an existing optimization profile's configuration, including its pillars, execution
    /// role, and aggregation settings.
    /// </summary>
    public partial class UpdateAgentProfileRequest : AmazonWellArchitectedRequest
    {
        private List<AggregationConfiguration> _aggregationConfiguration = AWSConfigs.InitializeCollections ? new List<AggregationConfiguration>() : null;
        private string _businessOverview;
        private string _clientToken;
        private bool? _deletionProtection;
        private string _description;
        private string _displayName;
        private string _executionRoleArn;
        private List<string> _pillars = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _profileArn;

        /// <summary>
        /// Gets and sets the property AggregationConfiguration. 
        /// <para>
        /// The updated aggregation configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
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
        /// Gets and sets the property BusinessOverview. 
        /// <para>
        /// The updated business overview for the profile.
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
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
        /// The updated description of the profile.
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
        /// The updated display name of the profile.
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
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The updated ARN of the IAM execution role.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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
        /// Gets and sets the property Pillars. 
        /// <para>
        /// The updated Well-Architected Tool Framework pillars for the profile.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
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
        /// Gets and sets the property ProfileArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the profile to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string ProfileArn
        {
            get { return this._profileArn; }
            set { this._profileArn = value; }
        }

        // Check to see if ProfileArn property is set
        internal bool IsSetProfileArn()
        {
            return this._profileArn != null;
        }

    }
}