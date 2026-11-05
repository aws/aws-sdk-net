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

namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Defines an Amazon EKS cluster and its namespaces as an input source for resource discovery.
    /// </summary>
    public partial class EksSource
    {
        /// <summary>
        /// Gets and sets the property ClusterArn.
        /// </summary>
        [AWSProperty(Required = true, Min = 31)]
        public string ClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the ClusterArn property is set.
        /// </summary>
        internal bool IsSetClusterArn() => this.ClusterArn != null;

        /// <summary>
        /// Gets and sets the property LabelSelector. 
        /// <para>
        /// Filters discovery to the Kubernetes objects whose labels match the selector. When
        /// omitted, all supported objects in the specified namespaces are discovered.
        /// </para>
        /// </summary>
        public EksLabelSelector LabelSelector { get; set; }

        /// <summary>
        /// Checks to see if the LabelSelector property is set.
        /// </summary>
        internal bool IsSetLabelSelector() => this.LabelSelector != null;

        /// <summary>
        /// Gets and sets the property Namespaces. 
        /// <para>
        /// The list of Kubernetes namespaces within the EKS cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public List<string> Namespaces { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Namespaces property is set.
        /// </summary>
        internal bool IsSetNamespaces() => this.Namespaces != null && (this.Namespaces.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
