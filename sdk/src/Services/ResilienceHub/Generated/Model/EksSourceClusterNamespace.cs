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
    /// The input source of the namespace that is located on your Amazon Elastic Kubernetes
    /// Service cluster.
    /// </summary>
    public partial class EksSourceClusterNamespace
    {
        private string _eksClusterArn;
        private string _awsNamespace;

        /// <summary>
        /// Gets and sets the property EksClusterArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the Amazon Elastic Kubernetes Service cluster. The format
        /// for this ARN is: arn:<c>aws</c>:eks:<c>region</c>:<c>account-id</c>:cluster/<c>cluster-name</c>.
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">
        /// Amazon Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>
        /// guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EksClusterArn
        {
            get { return this._eksClusterArn; }
            set { this._eksClusterArn = value; }
        }

        // Check to see if EksClusterArn property is set
        internal bool IsSetEksClusterArn()
        {
            return this._eksClusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// Name of the namespace that is located on your Amazon Elastic Kubernetes Service cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

    }
}