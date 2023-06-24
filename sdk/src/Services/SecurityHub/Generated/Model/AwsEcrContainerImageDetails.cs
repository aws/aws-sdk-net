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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about an Amazon ECR image.
    /// </summary>
    public partial class AwsEcrContainerImageDetails
    {
        private string _architecture;
        private string _imageDigest;
        private string _imagePublishedAt;
        private List<string> _imageTags = new List<string>();
        private string _registryId;
        private string _repositoryName;

        /// <summary>
        /// Gets and sets the property Architecture. 
        /// <para>
        /// The architecture of the image. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>arm64</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>i386</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>x86_64</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
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
        /// Gets and sets the property ImageDigest. 
        /// <para>
        /// The sha256 digest of the image manifest.
        /// </para>
        /// </summary>
        public string ImageDigest
        {
            get { return this._imageDigest; }
            set { this._imageDigest = value; }
        }

        // Check to see if ImageDigest property is set
        internal bool IsSetImageDigest()
        {
            return this._imageDigest != null;
        }

        /// <summary>
        /// Gets and sets the property ImagePublishedAt. 
        /// <para>
        /// The date and time when the image was pushed to the repository.
        /// </para>
        ///  
        /// <para>
        /// Uses the <code>date-time</code> format specified in <a href="https://tools.ietf.org/html/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>. The value cannot contain spaces,
        /// and date and time should be separated by <code>T</code>. For example, <code>2020-03-22T13:22:13.933Z</code>.
        /// </para>
        /// </summary>
        public string ImagePublishedAt
        {
            get { return this._imagePublishedAt; }
            set { this._imagePublishedAt = value; }
        }

        // Check to see if ImagePublishedAt property is set
        internal bool IsSetImagePublishedAt()
        {
            return this._imagePublishedAt != null;
        }

        /// <summary>
        /// Gets and sets the property ImageTags. 
        /// <para>
        /// The list of tags that are associated with the image.
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
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The Amazon Web Services account identifier that is associated with the registry that
        /// the image belongs to.
        /// </para>
        /// </summary>
        public string RegistryId
        {
            get { return this._registryId; }
            set { this._registryId = value; }
        }

        // Check to see if RegistryId property is set
        internal bool IsSetRegistryId()
        {
            return this._registryId != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository that the image belongs to.
        /// </para>
        /// </summary>
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