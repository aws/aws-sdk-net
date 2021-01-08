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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteArtifact operation.
    /// Deletes an artifact. Either <code>ArtifactArn</code> or <code>Source</code> must be
    /// specified.
    /// </summary>
    public partial class DeleteArtifactRequest : AmazonSageMakerRequest
    {
        private string _artifactArn;
        private ArtifactSource _source;

        /// <summary>
        /// Gets and sets the property ArtifactArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the artifact to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ArtifactArn
        {
            get { return this._artifactArn; }
            set { this._artifactArn = value; }
        }

        // Check to see if ArtifactArn property is set
        internal bool IsSetArtifactArn()
        {
            return this._artifactArn != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The URI of the source.
        /// </para>
        /// </summary>
        public ArtifactSource Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

    }
}