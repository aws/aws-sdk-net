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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the PutEndpointPolicy operation. Attaches a resource-based
    /// policy to an endpoint. With an endpoint policy, you can allow other Amazon Web Services
    /// accounts to send requests to your endpoint, or to inference components on it, through
    /// an inference router. The policy that you specify replaces the endpoint's existing
    /// policy, if it has one. <para> You can't attach a policy to an endpoint whose status
    /// is <c>Deleting</c> or <c>Failed</c>. SageMaker AI rejects a policy that doesn't follow
    /// the endpoint policy rules. For information about the policy rules, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/inference-router-cross-account.html">Use
    /// destinations in other accounts</a>. </para> <para> Policy changes typically take effect
    /// within 30 seconds, and can take up to 5 minutes. If you delete the endpoint, its policy
    /// is also deleted, and a new endpoint with the same name has no policy. </para>
    /// </summary>
    public partial class PutEndpointPolicyRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The name of the endpoint. The endpoint must be in your account and in the current
        /// Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 63)]
        public string EndpointName { get; set; }

        /// <summary>
        /// Checks to see if the EndpointName property is set.
        /// </summary>
        internal bool IsSetEndpointName() => this.EndpointName != null;

        /// <summary>
        /// Gets and sets the property ResourcePolicy. 
        /// <para>
        /// The endpoint policy, as a JSON policy document. The policy can contain only ASCII
        /// characters. For information about the policy rules, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/inference-router-cross-account.html">Use
        /// destinations in other accounts</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20480)]
        public string ResourcePolicy { get; set; }

        /// <summary>
        /// Checks to see if the ResourcePolicy property is set.
        /// </summary>
        internal bool IsSetResourcePolicy() => this.ResourcePolicy != null;
    }
}
