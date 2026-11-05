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

namespace Amazon.Continuum.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCollector operation. Creates the Collector
    /// for the caller's account. Provisions an AWS Config service-linked recorder using the
    /// caller's federated access session and begins recording infrastructure changes.
    /// </summary>
    public partial class CreateCollectorRequest : AmazonContinuumRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. Caller-provided token that makes retried create
        /// requests return the original Collector rather than creating a duplicate.
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property KubernetesClusterRole. IAM role configuration used to collect
        /// Kubernetes cluster metadata. The authenticated caller must be allowed to pass its
        /// exact roleArn to Continuum.
        /// </summary>
        public KubernetesClusterRoleConfiguration KubernetesClusterRole { get; set; }

        /// <summary>
        /// Checks to see if the KubernetesClusterRole property is set.
        /// </summary>
        internal bool IsSetKubernetesClusterRole() => this.KubernetesClusterRole != null;

        /// <summary>
        /// Gets and sets the property Type. Source to collect. Defaults to AWS_COLLECTOR when
        /// omitted.
        /// </summary>
        public CollectorType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
