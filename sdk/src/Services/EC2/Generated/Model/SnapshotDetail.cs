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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the snapshot created from the imported disk.
    /// </summary>
    public partial class SnapshotDetail
    {
        private string _description;
        private string _deviceName;
        private double? _diskImageSize;
        private string _format;
        private string _progress;
        private string _snapshotId;
        private string _status;
        private string _statusMessage;
        private string _url;
        private UserBucketDetails _userBucket;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the snapshot.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceName. 
        /// <para>
        /// The block device mapping for the snapshot.
        /// </para>
        /// </summary>
        public string DeviceName
        {
            get { return this._deviceName; }
            set { this._deviceName = value; }
        }

        // Check to see if DeviceName property is set
        internal bool IsSetDeviceName()
        {
            return this._deviceName != null;
        }

        /// <summary>
        /// Gets and sets the property DiskImageSize. 
        /// <para>
        /// The size of the disk in the snapshot, in GiB.
        /// </para>
        /// </summary>
        public double? DiskImageSize
        {
            get { return this._diskImageSize; }
            set { this._diskImageSize = value; }
        }

        // Check to see if DiskImageSize property is set
        internal bool IsSetDiskImageSize()
        {
            return this._diskImageSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the disk image from which the snapshot is created.
        /// </para>
        /// </summary>
        public string Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property Progress. 
        /// <para>
        /// The percentage of progress for the task.
        /// </para>
        /// </summary>
        public string Progress
        {
            get { return this._progress; }
            set { this._progress = value; }
        }

        // Check to see if Progress property is set
        internal bool IsSetProgress()
        {
            return this._progress != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The snapshot ID of the disk being imported.
        /// </para>
        /// </summary>
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
        /// A brief status of the snapshot creation.
        /// </para>
        /// </summary>
        public string Status
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
        /// A detailed status message for the snapshot creation.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL used to access the disk image.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

        /// <summary>
        /// Gets and sets the property UserBucket. 
        /// <para>
        /// The Amazon S3 bucket for the disk image.
        /// </para>
        /// </summary>
        public UserBucketDetails UserBucket
        {
            get { return this._userBucket; }
            set { this._userBucket = value; }
        }

        // Check to see if UserBucket property is set
        internal bool IsSetUserBucket()
        {
            return this._userBucket != null;
        }

    }
}