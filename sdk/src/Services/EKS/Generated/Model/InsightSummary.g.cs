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
    /// The summarized description of the insight.
    /// </summary>
    public partial class InsightSummary
    {
        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category of the insight.
        /// </para>
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the insight which includes alert criteria, remediation recommendation,
        /// and additional resources (contains Markdown).
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the insight.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property InsightStatus. 
        /// <para>
        /// An object containing more detail on the status of the insight.
        /// </para>
        /// </summary>
        public InsightStatus InsightStatus { get; set; }

        /// <summary>
        /// Checks to see if the InsightStatus property is set.
        /// </summary>
        internal bool IsSetInsightStatus() => this.InsightStatus != null;

        /// <summary>
        /// Gets and sets the property KubernetesVersion. 
        /// <para>
        /// The Kubernetes minor version associated with an insight if applicable. 
        /// </para>
        /// </summary>
        public string KubernetesVersion { get; set; }

        /// <summary>
        /// Checks to see if the KubernetesVersion property is set.
        /// </summary>
        internal bool IsSetKubernetesVersion() => this.KubernetesVersion != null;

        /// <summary>
        /// Gets and sets the property LastRefreshTime. 
        /// <para>
        /// The time Amazon EKS last successfully completed a refresh of this insight check on
        /// the cluster.
        /// </para>
        /// </summary>
        public DateTime? LastRefreshTime { get; set; }

        /// <summary>
        /// Checks to see if the LastRefreshTime property is set.
        /// </summary>
        internal bool IsSetLastRefreshTime() => this.LastRefreshTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastTransitionTime. 
        /// <para>
        /// The time the status of the insight last changed.
        /// </para>
        /// </summary>
        public DateTime? LastTransitionTime { get; set; }

        /// <summary>
        /// Checks to see if the LastTransitionTime property is set.
        /// </summary>
        internal bool IsSetLastTransitionTime() => this.LastTransitionTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the insight.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
