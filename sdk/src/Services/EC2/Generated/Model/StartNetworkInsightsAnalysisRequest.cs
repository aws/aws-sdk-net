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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the StartNetworkInsightsAnalysis operation.
    /// Starts analyzing the specified path. If the path is reachable, the operation returns
    /// the shortest feasible path.
    /// </summary>
    public partial class StartNetworkInsightsAnalysisRequest : AmazonEC2Request
    {
        private List<string> _additionalAccounts = new List<string>();
        private string _clientToken;
        private List<string> _filterInArns = new List<string>();
        private string _networkInsightsPathId;
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();

        /// <summary>
        /// Gets and sets the property AdditionalAccounts. 
        /// <para>
        /// The member accounts that contain resources that the path can traverse.
        /// </para>
        /// </summary>
        public List<string> AdditionalAccounts
        {
            get { return this._additionalAccounts; }
            set { this._additionalAccounts = value; }
        }

        // Check to see if AdditionalAccounts property is set
        internal bool IsSetAdditionalAccounts()
        {
            return this._additionalAccounts != null && this._additionalAccounts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">How
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
        /// Gets and sets the property FilterInArns. 
        /// <para>
        /// The Amazon Resource Names (ARN) of the resources that the path must traverse.
        /// </para>
        /// </summary>
        public List<string> FilterInArns
        {
            get { return this._filterInArns; }
            set { this._filterInArns = value; }
        }

        // Check to see if FilterInArns property is set
        internal bool IsSetFilterInArns()
        {
            return this._filterInArns != null && this._filterInArns.Count > 0; 
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
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && this._tagSpecifications.Count > 0; 
        }

    }
}