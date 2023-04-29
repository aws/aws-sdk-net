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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Settings that Image Builder uses to configure the ECR repository and the output container
    /// images that Amazon Inspector scans.
    /// </summary>
    public partial class EcrConfiguration
    {
        private List<string> _containerTags = new List<string>();
        private string _repositoryName;

        /// <summary>
        /// Gets and sets the property ContainerTags. 
        /// <para>
        /// Tags for Image Builder to apply to the output container image that &amp;INS; scans.
        /// Tags can help you identify and manage your scanned images.
        /// </para>
        /// </summary>
        public List<string> ContainerTags
        {
            get { return this._containerTags; }
            set { this._containerTags = value; }
        }

        // Check to see if ContainerTags property is set
        internal bool IsSetContainerTags()
        {
            return this._containerTags != null && this._containerTags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the container repository that Amazon Inspector scans to identify findings
        /// for your container images. The name includes the path for the repository location.
        /// If you don’t provide this information, Image Builder creates a repository in your
        /// account named <code>image-builder-image-scanning-repository</code> for vulnerability
        /// scans of your output container images.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string RepositoryName
        {
            get { return this._repositoryName; }
            set { this._repositoryName = value; }
        }

        // Check to see if RepositoryName property is set
        internal bool IsSetRepositoryName()
        {
            return this._repositoryName != null;
        }

    }
}