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
    /// This is the response object from the DescribeImageReplicationStatus operation.
    /// </summary>
    public partial class DescribeImageReplicationStatusResponse : AmazonWebServiceResponse
    {
        private ImageIdentifier _imageId;
        private List<ImageReplicationStatus> _replicationStatuses = AWSConfigs.InitializeCollections ? new List<ImageReplicationStatus>() : null;
        private string _repositoryName;

        /// <summary>
        /// Gets and sets the property ImageId.
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
        /// Gets and sets the property ReplicationStatuses. 
        /// <para>
        /// The replication status details for the images in the specified repository.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ImageReplicationStatus> ReplicationStatuses
        {
            get { return this._replicationStatuses; }
            set { this._replicationStatuses = value; }
        }

        // Check to see if ReplicationStatuses property is set
        internal bool IsSetReplicationStatuses()
        {
            return this._replicationStatuses != null && (this._replicationStatuses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The repository name associated with the request.
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

    }
}