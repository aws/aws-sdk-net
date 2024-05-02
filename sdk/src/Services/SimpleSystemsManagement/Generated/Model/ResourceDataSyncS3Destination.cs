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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Information about the target S3 bucket for the resource data sync.
    /// </summary>
    public partial class ResourceDataSyncS3Destination
    {
        private string _awskmsKeyARN;
        private string _bucketName;
        private ResourceDataSyncDestinationDataSharing _destinationDataSharing;
        private string _prefix;
        private string _region;
        private ResourceDataSyncS3Format _syncFormat;

        /// <summary>
        /// Gets and sets the property AWSKMSKeyARN. 
        /// <para>
        /// The ARN of an encryption key for a destination in Amazon S3. Must belong to the same
        /// Region as the destination S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string AWSKMSKeyARN
        {
            get { return this._awskmsKeyARN; }
            set { this._awskmsKeyARN = value; }
        }

        // Check to see if AWSKMSKeyARN property is set
        internal bool IsSetAWSKMSKeyARN()
        {
            return this._awskmsKeyARN != null;
        }

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the S3 bucket where the aggregated data is stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this._bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationDataSharing. 
        /// <para>
        /// Enables destination data sharing. By default, this field is <c>null</c>.
        /// </para>
        /// </summary>
        public ResourceDataSyncDestinationDataSharing DestinationDataSharing
        {
            get { return this._destinationDataSharing; }
            set { this._destinationDataSharing = value; }
        }

        // Check to see if DestinationDataSharing property is set
        internal bool IsSetDestinationDataSharing()
        {
            return this._destinationDataSharing != null;
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// An Amazon S3 prefix for the bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region with the S3 bucket targeted by the resource data sync.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property SyncFormat. 
        /// <para>
        /// A supported sync format. The following format is currently supported: JsonSerDe
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceDataSyncS3Format SyncFormat
        {
            get { return this._syncFormat; }
            set { this._syncFormat = value; }
        }

        // Check to see if SyncFormat property is set
        internal bool IsSetSyncFormat()
        {
            return this._syncFormat != null;
        }

    }
}