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
    /// Container for the parameters to the UpdateCapability operation.
    /// Updates the configuration of a managed capability in your Amazon EKS cluster. You
    /// can update the IAM role, configuration settings, and delete propagation policy for
    /// a capability.
    /// 
    ///  
    /// <para>
    /// When you update a capability, Amazon EKS applies the changes and may restart capability
    /// components as needed. The capability remains available during the update process,
    /// but some operations may be temporarily unavailable.
    /// </para>
    /// </summary>
    public partial class UpdateCapabilityRequest : AmazonEKSRequest
    {
        private string _capabilityName;
        private string _clientRequestToken;
        private string _clusterName;
        private UpdateCapabilityConfiguration _configuration;
        private CapabilityDeletePropagationPolicy _deletePropagationPolicy;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property CapabilityName. 
        /// <para>
        /// The name of the capability to update configuration for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CapabilityName
        {
            get { return this._capabilityName; }
            set { this._capabilityName = value; }
        }

        // Check to see if CapabilityName property is set
        internal bool IsSetCapabilityName()
        {
            return this._capabilityName != null;
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. This token is valid for 24 hours after creation.
        /// </para>
        /// </summary>
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the Amazon EKS cluster that contains the capability you want to update
        /// configuration for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterName
        {
            get { return this._clusterName; }
            set { this._clusterName = value; }
        }

        // Check to see if ClusterName property is set
        internal bool IsSetClusterName()
        {
            return this._clusterName != null;
        }

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The updated configuration settings for the capability. You only need to specify the
        /// configuration parameters you want to change. For Argo CD capabilities, you can update
        /// RBAC role mappings and network access settings.
        /// </para>
        /// </summary>
        public UpdateCapabilityConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property DeletePropagationPolicy. 
        /// <para>
        /// The updated delete propagation policy for the capability. Currently, the only supported
        /// value is <c>RETAIN</c>.
        /// </para>
        /// </summary>
        public CapabilityDeletePropagationPolicy DeletePropagationPolicy
        {
            get { return this._deletePropagationPolicy; }
            set { this._deletePropagationPolicy = value; }
        }

        // Check to see if DeletePropagationPolicy property is set
        internal bool IsSetDeletePropagationPolicy()
        {
            return this._deletePropagationPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that the capability uses to interact
        /// with Amazon Web Services services. If you specify a new role ARN, the capability will
        /// start using the new role for all subsequent operations.
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}