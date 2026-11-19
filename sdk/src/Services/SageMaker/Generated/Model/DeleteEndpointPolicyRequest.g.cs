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
    /// Container for the parameters to the DeleteEndpointPolicy operation. Deletes the resource-based
    /// policy that is attached to an endpoint. After you delete the policy, other accounts
    /// can no longer send requests to the endpoint through an inference router. The endpoint
    /// continues to serve requests from your account. If the endpoint doesn't have a policy,
    /// the operation succeeds. <para> The change typically takes effect within 30 seconds,
    /// and can take up to 5 minutes. To revoke access for one account only, use <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_PutEndpointPolicy.html">PutEndpointPolicy</a>
    /// to replace the policy with one that doesn't include that account. </para>
    /// </summary>
    public partial class DeleteEndpointPolicyRequest : AmazonSageMakerRequest
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
    }
}
