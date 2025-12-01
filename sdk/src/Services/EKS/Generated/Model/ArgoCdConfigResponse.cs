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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
namespace Amazon.EKS.Model
{
    /// <summary>
    /// The response object containing Argo CD configuration details, including the server
    /// URL that you use to access the Argo CD web interface and API.
    /// </summary>
    public partial class ArgoCdConfigResponse
    {
        private ArgoCdAwsIdcConfigResponse _awsIdc;
        private string _awsNamespace;
        private ArgoCdNetworkAccessConfigResponse _networkAccess;
        private List<ArgoCdRoleMapping> _rbacRoleMappings = AWSConfigs.InitializeCollections ? new List<ArgoCdRoleMapping>() : null;
        private string _serverUrl;

        /// <summary>
        /// Gets and sets the property AwsIdc. 
        /// <para>
        /// The IAM Identity CenterIAM; Identity Center integration configuration.
        /// </para>
        /// </summary>
        public ArgoCdAwsIdcConfigResponse AwsIdc
        {
            get { return this._awsIdc; }
            set { this._awsIdc = value; }
        }

        // Check to see if AwsIdc property is set
        internal bool IsSetAwsIdc()
        {
            return this._awsIdc != null;
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The Kubernetes namespace where Argo CD resources are monitored by your Argo CD Capability.
        /// </para>
        /// </summary>
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkAccess. 
        /// <para>
        /// The network access configuration for the Argo CD capability's managed API server endpoint.
        /// If VPC endpoint IDs are specified, public access is blocked and the Argo CD server
        /// is only accessible through the specified VPC endpoints.
        /// </para>
        /// </summary>
        public ArgoCdNetworkAccessConfigResponse NetworkAccess
        {
            get { return this._networkAccess; }
            set { this._networkAccess = value; }
        }

        // Check to see if NetworkAccess property is set
        internal bool IsSetNetworkAccess()
        {
            return this._networkAccess != null;
        }

        /// <summary>
        /// Gets and sets the property RbacRoleMappings. 
        /// <para>
        /// The list of role mappings that define which IAM Identity CenterIAM; Identity Center
        /// users or groups have which Argo CD roles.
        /// </para>
        /// </summary>
        public List<ArgoCdRoleMapping> RbacRoleMappings
        {
            get { return this._rbacRoleMappings; }
            set { this._rbacRoleMappings = value; }
        }

        // Check to see if RbacRoleMappings property is set
        internal bool IsSetRbacRoleMappings()
        {
            return this._rbacRoleMappings != null && (this._rbacRoleMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ServerUrl. 
        /// <para>
        /// The URL of the Argo CD server. Use this URL to access the Argo CD web interface and
        /// API.
        /// </para>
        /// </summary>
        public string ServerUrl
        {
            get { return this._serverUrl; }
            set { this._serverUrl = value; }
        }

        // Check to see if ServerUrl property is set
        internal bool IsSetServerUrl()
        {
            return this._serverUrl != null;
        }

    }
}