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

namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// The list of Resilience Hub application input sources.
    /// </summary>
    public partial class AppInputSource
    {
        /// <summary>
        /// Gets and sets the property EksSourceClusterNamespace. 
        /// <para>
        /// The namespace on your Amazon Elastic Kubernetes Service cluster.
        /// </para>
        /// </summary>
        public EksSourceClusterNamespace EksSourceClusterNamespace { get; set; }

        /// <summary>
        /// Checks to see if the EksSourceClusterNamespace property is set.
        /// </summary>
        internal bool IsSetEksSourceClusterNamespace() => this.EksSourceClusterNamespace != null;

        /// <summary>
        /// Gets and sets the property ImportType. 
        /// <para>
        /// The resource type of the input source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceMappingType ImportType { get; set; }

        /// <summary>
        /// Checks to see if the ImportType property is set.
        /// </summary>
        internal bool IsSetImportType() => this.ImportType != null;

        /// <summary>
        /// Gets and sets the property ResourceCount. 
        /// <para>
        /// The number of resources.
        /// </para>
        /// </summary>
        public int? ResourceCount { get; set; }

        /// <summary>
        /// Checks to see if the ResourceCount property is set.
        /// </summary>
        internal bool IsSetResourceCount() => this.ResourceCount.HasValue;

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the input source. For more information about ARNs,
        /// see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">
        /// Amazon Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>
        /// guide.
        /// </para>
        /// </summary>
        public string SourceArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceArn property is set.
        /// </summary>
        internal bool IsSetSourceArn() => this.SourceArn != null;

        /// <summary>
        /// Gets and sets the property SourceName. 
        /// <para>
        /// The name of the input source.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string SourceName { get; set; }

        /// <summary>
        /// Checks to see if the SourceName property is set.
        /// </summary>
        internal bool IsSetSourceName() => this.SourceName != null;

        /// <summary>
        /// Gets and sets the property TerraformSource. 
        /// <para>
        /// The name of the Terraform s3 state ﬁle.
        /// </para>
        /// </summary>
        public TerraformSource TerraformSource { get; set; }

        /// <summary>
        /// Checks to see if the TerraformSource property is set.
        /// </summary>
        internal bool IsSetTerraformSource() => this.TerraformSource != null;
    }
}
