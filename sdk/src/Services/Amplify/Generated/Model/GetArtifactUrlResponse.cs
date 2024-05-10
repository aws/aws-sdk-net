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
 * Do not modify this file. This file is generated from the amplify-2017-07-25.normal.json service model.
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
namespace Amazon.Amplify.Model
{
    /// <summary>
    /// Returns the result structure for the get artifact request.
    /// </summary>
    public partial class GetArtifactUrlResponse : AmazonWebServiceResponse
    {
        private string _artifactId;
        private string _artifactUrl;

        /// <summary>
        /// Gets and sets the property ArtifactId. 
        /// <para>
        /// The unique ID for an artifact. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public string ArtifactId
        {
            get { return this._artifactId; }
            set { this._artifactId = value; }
        }

        // Check to see if ArtifactId property is set
        internal bool IsSetArtifactId()
        {
            return this._artifactId != null;
        }

        /// <summary>
        /// Gets and sets the property ArtifactUrl. 
        /// <para>
        /// The presigned URL for the artifact. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1000)]
        public string ArtifactUrl
        {
            get { return this._artifactUrl; }
            set { this._artifactUrl = value; }
        }

        // Check to see if ArtifactUrl property is set
        internal bool IsSetArtifactUrl()
        {
            return this._artifactUrl != null;
        }

    }
}