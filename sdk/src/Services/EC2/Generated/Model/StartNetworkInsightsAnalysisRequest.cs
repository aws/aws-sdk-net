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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the StartNetworkInsightsAnalysis operation.
    /// Starts analyzing the specified path. If the path is reachable, the operation returns
    /// the shortest feasible path.
    /// </summary>
    public partial class StartNetworkInsightsAnalysisRequest : AmazonEC2Request
    {
        private List<string> _additionalAccounts = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _clientToken;
        private bool? _dryRun;
        private List<string> _filterInArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _filterOutArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _networkInsightsPathId;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Gets and sets the property AdditionalAccounts. 
        /// <para>
        /// The member accounts that contain resources that the path can traverse.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AdditionalAccounts
        {
            get { return this._additionalAccounts; }
            set { this._additionalAccounts = value; }
        }

        // Check to see if AdditionalAccounts property is set
        internal bool IsSetAdditionalAccounts()
        {
            return this._additionalAccounts != null && (this._additionalAccounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-idempotency.html">How
        /// to ensure idempotency</a>.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FilterInArns. 
        /// <para>
        /// The Amazon Resource Names (ARN) of the resources that the path must traverse.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FilterInArns
        {
            get { return this._filterInArns; }
            set { this._filterInArns = value; }
        }

        // Check to see if FilterInArns property is set
        internal bool IsSetFilterInArns()
        {
            return this._filterInArns != null && (this._filterInArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FilterOutArns. 
        /// <para>
        /// The Amazon Resource Names (ARN) of the resources that the path will ignore.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FilterOutArns
        {
            get { return this._filterOutArns; }
            set { this._filterOutArns = value; }
        }

        // Check to see if FilterOutArns property is set
        internal bool IsSetFilterOutArns()
        {
            return this._filterOutArns != null && (this._filterOutArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NetworkInsightsPathId. 
        /// <para>
        /// The ID of the path.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NetworkInsightsPathId
        {
            get { return this._networkInsightsPathId; }
            set { this._networkInsightsPathId = value; }
        }

        // Check to see if NetworkInsightsPathId property is set
        internal bool IsSetNetworkInsightsPathId()
        {
            return this._networkInsightsPathId != null;
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && (this._tagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}