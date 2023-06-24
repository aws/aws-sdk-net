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
    /// This is the response object from the DescribeSpace operation.
    /// </summary>
    public partial class DescribeSpaceResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private string _domainId;
        private string _failureReason;
        private string _homeEfsFileSystemUid;
        private DateTime? _lastModifiedTime;
        private string _spaceArn;
        private string _spaceName;
        private SpaceSettings _spaceSettings;
        private SpaceStatus _status;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The ID of the associated Domain.
        /// </para>
        /// </summary>
        [AWSProperty(Max=63)]
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The failure reason.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property HomeEfsFileSystemUid. 
        /// <para>
        /// The ID of the space's profile in the Amazon Elastic File System volume.
        /// </para>
        /// </summary>
        [AWSProperty(Max=10)]
        public string HomeEfsFileSystemUid
        {
            get { return this._homeEfsFileSystemUid; }
            set { this._homeEfsFileSystemUid = value; }
        }

        // Check to see if HomeEfsFileSystemUid property is set
        internal bool IsSetHomeEfsFileSystemUid()
        {
            return this._homeEfsFileSystemUid != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The last modified time.
        /// </para>
        /// </summary>
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SpaceArn. 
        /// <para>
        /// The space's Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string SpaceArn
        {
            get { return this._spaceArn; }
            set { this._spaceArn = value; }
        }

        // Check to see if SpaceArn property is set
        internal bool IsSetSpaceArn()
        {
            return this._spaceArn != null;
        }

        /// <summary>
        /// Gets and sets the property SpaceName. 
        /// <para>
        /// The name of the space.
        /// </para>
        /// </summary>
        [AWSProperty(Max=63)]
        public string SpaceName
        {
            get { return this._spaceName; }
            set { this._spaceName = value; }
        }

        // Check to see if SpaceName property is set
        internal bool IsSetSpaceName()
        {
            return this._spaceName != null;
        }

        /// <summary>
        /// Gets and sets the property SpaceSettings. 
        /// <para>
        /// A collection of space settings.
        /// </para>
        /// </summary>
        public SpaceSettings SpaceSettings
        {
            get { return this._spaceSettings; }
            set { this._spaceSettings = value; }
        }

        // Check to see if SpaceSettings property is set
        internal bool IsSetSpaceSettings()
        {
            return this._spaceSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status.
        /// </para>
        /// </summary>
        public SpaceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}