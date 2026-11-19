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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the disk container object for an import image task.
    /// </summary>
    public partial class ImageDiskContainer
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the disk image.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DeviceName. 
        /// <para>
        /// The block device mapping for the disk.
        /// </para>
        /// </summary>
        public string DeviceName { get; set; }

        /// <summary>
        /// Checks to see if the DeviceName property is set.
        /// </summary>
        internal bool IsSetDeviceName() => this.DeviceName != null;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the disk image being imported.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>OVA</c> | <c>VHD</c> | <c>VHDX</c> | <c>VMDK</c> | <c>RAW</c> 
        /// </para>
        /// </summary>
        public string Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The ID of the EBS snapshot to be used for importing the snapshot.
        /// </para>
        /// </summary>
        public string SnapshotId { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotId property is set.
        /// </summary>
        internal bool IsSetSnapshotId() => this.SnapshotId != null;

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL to the Amazon S3-based disk image being imported. The URL can either be a
        /// https URL (https://..) or an Amazon S3 URL (s3://..)
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;

        /// <summary>
        /// Gets and sets the property UserBucket. 
        /// <para>
        /// The S3 bucket for the disk image.
        /// </para>
        /// </summary>
        public UserBucket UserBucket { get; set; }

        /// <summary>
        /// Checks to see if the UserBucket property is set.
        /// </summary>
        internal bool IsSetUserBucket() => this.UserBucket != null;
    }
}
