/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECR.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRepository operation.
    /// Creates a repository. For more information, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/Repositories.html">Amazon
    /// ECR Repositories</a> in the <i>Amazon Elastic Container Registry User Guide</i>.
    /// </summary>
    public partial class CreateRepositoryRequest : AmazonECRRequest
    {
        private ImageScanningConfiguration _imageScanningConfiguration;
        private ImageTagMutability _imageTagMutability;
        private string _repositoryName;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ImageScanningConfiguration. 
        /// <para>
        /// The image scanning configuration for the repository. This setting determines whether
        /// images are scanned for known vulnerabilities after being pushed to the repository.
        /// </para>
        /// </summary>
        public ImageScanningConfiguration ImageScanningConfiguration
        {
            get { return this._imageScanningConfiguration; }
            set { this._imageScanningConfiguration = value; }
        }

        // Check to see if ImageScanningConfiguration property is set
        internal bool IsSetImageScanningConfiguration()
        {
            return this._imageScanningConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ImageTagMutability. 
        /// <para>
        /// The tag mutability setting for the repository. If this parameter is omitted, the default
        /// setting of <code>MUTABLE</code> will be used which will allow image tags to be overwritten.
        /// If <code>IMMUTABLE</code> is specified, all image tags within the repository will
        /// be immutable which will prevent them from being overwritten.
        /// </para>
        /// </summary>
        public ImageTagMutability ImageTagMutability
        {
            get { return this._imageTagMutability; }
            set { this._imageTagMutability = value; }
        }

        // Check to see if ImageTagMutability property is set
        internal bool IsSetImageTagMutability()
        {
            return this._imageTagMutability != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name to use for the repository. The repository name may be specified on its own
        /// (such as <code>nginx-web-app</code>) or it can be prepended with a namespace to group
        /// the repository into a category (such as <code>project-a/nginx-web-app</code>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=256)]
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The metadata that you apply to the repository to help you categorize and organize
        /// them. Each tag consists of a key and an optional value, both of which you define.
        /// Tag keys can have a maximum character length of 128 characters, and tag values can
        /// have a maximum length of 256 characters.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}