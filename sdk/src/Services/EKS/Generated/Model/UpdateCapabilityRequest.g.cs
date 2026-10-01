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
    /// Container for the parameters to the UpdateCapability operation. Updates the configuration
    /// of a managed capability in your Amazon EKS cluster. You can update the IAM role, configuration
    /// settings, and delete propagation policy for a capability. <para> When you update a
    /// capability, Amazon EKS applies the changes and may restart capability components as
    /// needed. The capability remains available during the update process, but some operations
    /// may be temporarily unavailable. </para>
    /// </summary>
    public partial class UpdateCapabilityRequest : AmazonEKSRequest
    {
        /// <summary>
        /// Gets and sets the property CapabilityName. 
        /// <para>
        /// The name of the capability to update configuration for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CapabilityName { get; set; }

        /// <summary>
        /// Checks to see if the CapabilityName property is set.
        /// </summary>
        internal bool IsSetCapabilityName() => this.CapabilityName != null;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. This token is valid for 24 hours after creation.
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
        /// The name of the Amazon EKS cluster that contains the capability you want to update
        /// configuration for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The updated configuration settings for the capability. You only need to specify the
        /// configuration parameters you want to change. For Argo CD capabilities, you can update
        /// RBAC role mappings and network access settings.
        /// </para>
        /// </summary>
        public UpdateCapabilityConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property DeletePropagationPolicy. 
        /// <para>
        /// The updated delete propagation policy for the capability. Currently, the only supported
        /// value is <c>RETAIN</c>.
        /// </para>
        /// </summary>
        public CapabilityDeletePropagationPolicy DeletePropagationPolicy { get; set; }

        /// <summary>
        /// Checks to see if the DeletePropagationPolicy property is set.
        /// </summary>
        internal bool IsSetDeletePropagationPolicy() => this.DeletePropagationPolicy != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that the capability uses to interact
        /// with Amazon Web Services services. If you specify a new role ARN, the capability will
        /// start using the new role for all subsequent operations.
        /// </para>
        /// </summary>
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;
    }
}
