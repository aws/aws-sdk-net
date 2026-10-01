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

namespace Amazon.EKS.Model
{
    /// <summary>
    /// Container for the parameters to the DisassociateIdentityProviderConfig operation.
    /// Disassociates an identity provider configuration from a cluster. <para> If you disassociate
    /// an identity provider from your cluster, users included in the provider can no longer
    /// access the cluster. However, you can still access the cluster with IAM principals.
    /// </para>
    /// </summary>
    public partial class DisassociateIdentityProviderConfigRequest : AmazonEKSRequest
    {
        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of your cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

        /// <summary>
        /// Gets and sets the property IdentityProviderConfig. 
        /// <para>
        /// An object representing an identity provider configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IdentityProviderConfig IdentityProviderConfig { get; set; }

        /// <summary>
        /// Checks to see if the IdentityProviderConfig property is set.
        /// </summary>
        internal bool IsSetIdentityProviderConfig() => this.IdentityProviderConfig != null;
    }
}
