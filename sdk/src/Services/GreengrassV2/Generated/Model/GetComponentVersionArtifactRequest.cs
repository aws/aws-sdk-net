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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Container for the parameters to the GetComponentVersionArtifact operation.
    /// Gets the pre-signed URL to a component artifact in an S3 bucket. Core devices can
    /// call this operation to identify the URL that they can use to download an artifact
    /// to install.
    /// </summary>
    public partial class GetComponentVersionArtifactRequest : AmazonGreengrassV2Request
    {
        private string _arn;
        private string _artifactName;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the component version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ArtifactName. 
        /// <para>
        /// The name of the artifact.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string ArtifactName
        {
            get { return this._artifactName; }
            set { this._artifactName = value; }
        }

        // Check to see if ArtifactName property is set
        internal bool IsSetArtifactName()
        {
            return this._artifactName != null;
        }

    }
}