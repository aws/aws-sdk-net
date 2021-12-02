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
    /// Container for the parameters to the CreateNetworkInsightsAccessScope operation.
    /// Creates a Network Access Scope.
    /// 
    ///  
    /// <para>
    /// Amazon Web Services Network Access Analyzer enables cloud networking and cloud operations
    /// teams to verify that their networks on Amazon Web Services conform to their network
    /// security and governance objectives. For more information, see the <a href="https://docs.aws.amazon.com/vpc/latest/network-access-analyzer/">Amazon
    /// Web Services Network Access Analyzer Guide</a>.
    /// </para>
    /// </summary>
    public partial class CreateNetworkInsightsAccessScopeRequest : AmazonEC2Request
    {
        private string _clientToken;
        private List<AccessScopePathRequest> _excludePaths = new List<AccessScopePathRequest>();
        private List<AccessScopePathRequest> _matchPaths = new List<AccessScopePathRequest>();
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();

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
        /// Gets and sets the property ExcludePaths. 
        /// <para>
        /// The paths to exclude.
        /// </para>
        /// </summary>
        public List<AccessScopePathRequest> ExcludePaths
        {
            get { return this._excludePaths; }
            set { this._excludePaths = value; }
        }

        // Check to see if ExcludePaths property is set
        internal bool IsSetExcludePaths()
        {
            return this._excludePaths != null && this._excludePaths.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MatchPaths. 
        /// <para>
        /// The paths to match.
        /// </para>
        /// </summary>
        public List<AccessScopePathRequest> MatchPaths
        {
            get { return this._matchPaths; }
            set { this._matchPaths = value; }
        }

        // Check to see if MatchPaths property is set
        internal bool IsSetMatchPaths()
        {
            return this._matchPaths != null && this._matchPaths.Count > 0; 
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