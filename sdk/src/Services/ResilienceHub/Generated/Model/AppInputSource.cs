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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// The list of Resilience Hub application input sources.
    /// </summary>
    public partial class AppInputSource
    {
        private EksSourceClusterNamespace _eksSourceClusterNamespace;
        private ResourceMappingType _importType;
        private int? _resourceCount;
        private string _sourceArn;
        private string _sourceName;
        private TerraformSource _terraformSource;

        /// <summary>
        /// Gets and sets the property EksSourceClusterNamespace. 
        /// <para>
        /// The namespace on your Amazon Elastic Kubernetes Service cluster.
        /// </para>
        /// </summary>
        public EksSourceClusterNamespace EksSourceClusterNamespace
        {
            get { return this._eksSourceClusterNamespace; }
            set { this._eksSourceClusterNamespace = value; }
        }

        // Check to see if EksSourceClusterNamespace property is set
        internal bool IsSetEksSourceClusterNamespace()
        {
            return this._eksSourceClusterNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property ImportType. 
        /// <para>
        /// The resource type of the input source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceMappingType ImportType
        {
            get { return this._importType; }
            set { this._importType = value; }
        }

        // Check to see if ImportType property is set
        internal bool IsSetImportType()
        {
            return this._importType != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceCount. 
        /// <para>
        /// The number of resources.
        /// </para>
        /// </summary>
        public int ResourceCount
        {
            get { return this._resourceCount.GetValueOrDefault(); }
            set { this._resourceCount = value; }
        }

        // Check to see if ResourceCount property is set
        internal bool IsSetResourceCount()
        {
            return this._resourceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the input source. For more information about ARNs,
        /// see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">
        /// Amazon Resource Names (ARNs)</a> in the <i>AWS General Reference</i> guide.
        /// </para>
        /// </summary>
        public string SourceArn
        {
            get { return this._sourceArn; }
            set { this._sourceArn = value; }
        }

        // Check to see if SourceArn property is set
        internal bool IsSetSourceArn()
        {
            return this._sourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceName. 
        /// <para>
        /// The name of the input source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string SourceName
        {
            get { return this._sourceName; }
            set { this._sourceName = value; }
        }

        // Check to see if SourceName property is set
        internal bool IsSetSourceName()
        {
            return this._sourceName != null;
        }

        /// <summary>
        /// Gets and sets the property TerraformSource. 
        /// <para>
        /// The name of the Terraform s3 state ﬁle.
        /// </para>
        /// </summary>
        public TerraformSource TerraformSource
        {
            get { return this._terraformSource; }
            set { this._terraformSource = value; }
        }

        // Check to see if TerraformSource property is set
        internal bool IsSetTerraformSource()
        {
            return this._terraformSource != null;
        }

    }
}