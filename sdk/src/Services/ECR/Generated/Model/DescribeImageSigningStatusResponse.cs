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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ECR.Model
{
    /// <summary>
    /// This is the response object from the DescribeImageSigningStatus operation.
    /// </summary>
    public partial class DescribeImageSigningStatusResponse : AmazonWebServiceResponse
    {
        private ImageIdentifier _imageId;
        private string _registryId;
        private string _repositoryName;
        private List<ImageSigningStatus> _signingStatuses = AWSConfigs.InitializeCollections ? new List<ImageSigningStatus>() : null;

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// An object with identifying information for the image.
        /// </para>
        /// </summary>
        public ImageIdentifier ImageId
        {
            get { return this._imageId; }
            set { this._imageId = value; }
        }

        // Check to see if ImageId property is set
        internal bool IsSetImageId()
        {
            return this._imageId != null;
        }

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The Amazon Web Services account ID associated with the registry.
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
        /// The name of the repository.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=256)]
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
        /// Gets and sets the property SigningStatuses. 
        /// <para>
        /// A list of signing statuses for the specified image. Each status corresponds to a signing
        /// profile.
        /// </para>
        /// </summary>
        public List<ImageSigningStatus> SigningStatuses
        {
            get { return this._signingStatuses; }
            set { this._signingStatuses = value; }
        }

        // Check to see if SigningStatuses property is set
        internal bool IsSetSigningStatuses()
        {
            return this._signingStatuses != null && (this._signingStatuses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}