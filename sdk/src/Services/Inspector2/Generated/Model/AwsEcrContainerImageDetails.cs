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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// The image details of the Amazon ECR container image.
    /// </summary>
    public partial class AwsEcrContainerImageDetails
    {
        private string _architecture;
        private string _author;
        private string _imageHash;
        private List<string> _imageTags = new List<string>();
        private string _platform;
        private DateTime? _pushedAt;
        private string _registry;
        private string _repositoryName;

        /// <summary>
        /// Gets and sets the property Architecture. 
        /// <para>
        /// The architecture of the Amazon ECR container image.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Architecture
        {
            get { return this._architecture; }
            set { this._architecture = value; }
        }

        // Check to see if Architecture property is set
        internal bool IsSetArchitecture()
        {
            return this._architecture != null;
        }

        /// <summary>
        /// Gets and sets the property Author. 
        /// <para>
        /// The image author of the Amazon ECR container image.
        /// </para>
        /// </summary>
        public string Author
        {
            get { return this._author; }
            set { this._author = value; }
        }

        // Check to see if Author property is set
        internal bool IsSetAuthor()
        {
            return this._author != null;
        }

        /// <summary>
        /// Gets and sets the property ImageHash. 
        /// <para>
        /// The image hash of the Amazon ECR container image.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=71, Max=71)]
        public string ImageHash
        {
            get { return this._imageHash; }
            set { this._imageHash = value; }
        }

        // Check to see if ImageHash property is set
        internal bool IsSetImageHash()
        {
            return this._imageHash != null;
        }

        /// <summary>
        /// Gets and sets the property ImageTags. 
        /// <para>
        /// The image tags attached to the Amazon ECR container image.
        /// </para>
        /// </summary>
        public List<string> ImageTags
        {
            get { return this._imageTags; }
            set { this._imageTags = value; }
        }

        // Check to see if ImageTags property is set
        internal bool IsSetImageTags()
        {
            return this._imageTags != null && this._imageTags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The platform of the Amazon ECR container image.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Platform
        {
            get { return this._platform; }
            set { this._platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this._platform != null;
        }

        /// <summary>
        /// Gets and sets the property PushedAt. 
        /// <para>
        /// The date and time the Amazon ECR container image was pushed.
        /// </para>
        /// </summary>
        public DateTime PushedAt
        {
            get { return this._pushedAt.GetValueOrDefault(); }
            set { this._pushedAt = value; }
        }

        // Check to see if PushedAt property is set
        internal bool IsSetPushedAt()
        {
            return this._pushedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Registry. 
        /// <para>
        /// The registry for the Amazon ECR container image.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string Registry
        {
            get { return this._registry; }
            set { this._registry = value; }
        }

        // Check to see if Registry property is set
        internal bool IsSetRegistry()
        {
            return this._registry != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository the Amazon ECR container image resides in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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