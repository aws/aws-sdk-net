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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains details about Kubernetes activity. A record contains either <c>ApiCall</c>
    /// and <c>Enrichment</c>, or <c>Anomaly</c> and <c>Workload</c>.
    /// </summary>
    public partial class KubernetesActivity
    {
        /// <summary>
        /// Gets and sets the property Anomaly. 
        /// <para>
        /// Details about anomalous Kubernetes behavior.
        /// </para>
        /// </summary>
        public KubernetesAnomaly Anomaly { get; set; }

        /// <summary>
        /// Checks to see if the Anomaly property is set.
        /// </summary>
        internal bool IsSetAnomaly() => this.Anomaly != null;

        /// <summary>
        /// Gets and sets the property ApiCall. 
        /// <para>
        /// Details about a Kubernetes API call.
        /// </para>
        /// </summary>
        public KubernetesApiCall ApiCall { get; set; }

        /// <summary>
        /// Checks to see if the ApiCall property is set.
        /// </summary>
        internal bool IsSetApiCall() => this.ApiCall != null;

        /// <summary>
        /// Gets and sets the property Enrichment. 
        /// <para>
        /// Additional context about the API call, such as geolocation information.
        /// </para>
        /// </summary>
        public Enrichment Enrichment { get; set; }

        /// <summary>
        /// Checks to see if the Enrichment property is set.
        /// </summary>
        internal bool IsSetEnrichment() => this.Enrichment != null;

        /// <summary>
        /// Gets and sets the property Workload. 
        /// <para>
        /// The Kubernetes workload that is associated with the anomaly.
        /// </para>
        /// </summary>
        public InvestigationKubernetesWorkload Workload { get; set; }

        /// <summary>
        /// Checks to see if the Workload property is set.
        /// </summary>
        internal bool IsSetWorkload() => this.Workload != null;
    }
}
