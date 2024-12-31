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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// This is the response object from the GetSegmentSnapshot operation.
    /// </summary>
    public partial class GetSegmentSnapshotResponse : AmazonWebServiceResponse
    {
        private DataFormat _dataFormat;
        private string _destinationUri;
        private string _encryptionKey;
        private string _roleArn;
        private string _snapshotId;
        private SegmentSnapshotStatus _status;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property DataFormat. 
        /// <para>
        /// The format in which the segment will be exported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataFormat DataFormat
        {
            get { return this._dataFormat; }
            set { this._dataFormat = value; }
        }

        // Check to see if DataFormat property is set
        internal bool IsSetDataFormat()
        {
            return this._dataFormat != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationUri. 
        /// <para>
        /// The destination to which the segment will be exported. This field must be provided
        /// if the request is not submitted from the Amazon Connect Admin Website.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DestinationUri
        {
            get { return this._destinationUri; }
            set { this._destinationUri = value; }
        }

        // Check to see if DestinationUri property is set
        internal bool IsSetDestinationUri()
        {
            return this._destinationUri != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionKey. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key used to encrypt the exported segment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string EncryptionKey
        {
            get { return this._encryptionKey; }
            set { this._encryptionKey = value; }
        }

        // Check to see if EncryptionKey property is set
        internal bool IsSetEncryptionKey()
        {
            return this._encryptionKey != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that allows Customer Profiles service
        /// principal to assume the role for conducting KMS and S3 operations.
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The unique identifier of the segment snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SnapshotId
        {
            get { return this._snapshotId; }
            set { this._snapshotId = value; }
        }

        // Check to see if SnapshotId property is set
        internal bool IsSetSnapshotId()
        {
            return this._snapshotId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the asynchronous job for exporting the segment snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SegmentSnapshotStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status message of the asynchronous job for exporting the segment snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}