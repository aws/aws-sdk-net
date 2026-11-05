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
    /// Container for the parameters to the UpdateCollector operation. Updates the customer-controlled
    /// mutable properties of a Collector. Only the name and Kubernetes cluster IAM role can
    /// be changed.
    /// </summary>
    public partial class UpdateCollectorRequest : AmazonContinuumRequest
    {
        /// <summary>
        /// Gets and sets the property CollectorId. The unique identifier of the Collector to
        /// update.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string CollectorId { get; set; }

        /// <summary>
        /// Checks to see if the CollectorId property is set.
        /// </summary>
        internal bool IsSetCollectorId() => this.CollectorId != null;

        /// <summary>
        /// Gets and sets the property KubernetesClusterRole. Atomic update to the IAM role configuration
        /// used to collect Kubernetes cluster metadata. The set variant requires a complete configuration;
        /// the authenticated caller must be allowed to pass its exact roleArn to Continuum. The
        /// remove variant clears both the role and external ID.
        /// </summary>
        public KubernetesClusterRoleUpdate KubernetesClusterRole { get; set; }

        /// <summary>
        /// Checks to see if the KubernetesClusterRole property is set.
        /// </summary>
        internal bool IsSetKubernetesClusterRole() => this.KubernetesClusterRole != null;

        /// <summary>
        /// Gets and sets the property Name. The new customer-visible name.
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
