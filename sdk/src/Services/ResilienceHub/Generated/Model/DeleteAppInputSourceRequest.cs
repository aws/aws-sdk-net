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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteAppInputSource operation.
    /// Deletes the input source and all of its imported resources from the Resilience Hub
    /// application.
    /// </summary>
    public partial class DeleteAppInputSourceRequest : AmazonResilienceHubRequest
    {
        private string _appArn;
        private string _clientToken;
        private EksSourceClusterNamespace _eksSourceClusterNamespace;
        private string _sourceArn;
        private TerraformSource _terraformSource;

        /// <summary>
        /// Gets and sets the property AppArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the Resilience Hub application. The format for this
        /// ARN is: arn:<c>partition</c>:resiliencehub:<c>region</c>:<c>account</c>:app/<c>app-id</c>.
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">
        /// Amazon Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>
        /// guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AppArn
        {
            get { return this._appArn; }
            set { this._appArn = value; }
        }

        // Check to see if AppArn property is set
        internal bool IsSetAppArn()
        {
            return this._appArn != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Used for an idempotency token. A client token is a unique, case-sensitive string of
        /// up to 64 ASCII characters. You should not reuse the same client token for other API
        /// requests.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property EksSourceClusterNamespace. 
        /// <para>
        /// The namespace on your Amazon Elastic Kubernetes Service cluster that you want to delete
        /// from the Resilience Hub application.
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
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the imported resource you want to remove from the
        /// Resilience Hub application. For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">
        /// Amazon Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>
        /// guide.
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
        /// Gets and sets the property TerraformSource. 
        /// <para>
        /// The imported Terraform s3 state ﬁle you want to remove from the Resilience Hub application.
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