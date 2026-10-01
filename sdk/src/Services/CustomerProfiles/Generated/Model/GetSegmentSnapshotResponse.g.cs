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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property DataFormat. 
        /// <para>
        /// The format in which the segment will be exported.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataFormat DataFormat { get; set; }

        /// <summary>
        /// Checks to see if the DataFormat property is set.
        /// </summary>
        internal bool IsSetDataFormat() => this.DataFormat != null;

        /// <summary>
        /// Gets and sets the property DestinationUri. 
        /// <para>
        /// The destination to which the segment will be exported. This field must be provided
        /// if the request is not submitted from the Connect Customer Admin Website.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DestinationUri { get; set; }

        /// <summary>
        /// Checks to see if the DestinationUri property is set.
        /// </summary>
        internal bool IsSetDestinationUri() => this.DestinationUri != null;

        /// <summary>
        /// Gets and sets the property EncryptionKey. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key used to encrypt the exported segment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKey property is set.
        /// </summary>
        internal bool IsSetEncryptionKey() => this.EncryptionKey != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that allows Customer Profiles service
        /// principal to assume the role for conducting KMS and S3 operations.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The unique identifier of the segment snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotId property is set.
        /// </summary>
        internal bool IsSetSnapshotId() => this.SnapshotId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the asynchronous job for exporting the segment snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SegmentSnapshotStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status message of the asynchronous job for exporting the segment snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;
    }
}
