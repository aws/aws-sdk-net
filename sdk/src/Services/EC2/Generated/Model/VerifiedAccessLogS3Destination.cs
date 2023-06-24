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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Options for Amazon S3 as a logging destination.
    /// </summary>
    public partial class VerifiedAccessLogS3Destination
    {
        private string _bucketName;
        private string _bucketOwner;
        private VerifiedAccessLogDeliveryStatus _deliveryStatus;
        private bool? _enabled;
        private string _prefix;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The bucket name.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property BucketOwner. 
        /// <para>
        /// The Amazon Web Services account number that owns the bucket.
        /// </para>
        /// </summary>
        public string BucketOwner
        {
            get { return this._bucketOwner; }
            set { this._bucketOwner = value; }
        }

        // Check to see if BucketOwner property is set
        internal bool IsSetBucketOwner()
        {
            return this._bucketOwner != null;
        }

        /// <summary>
        /// Gets and sets the property DeliveryStatus. 
        /// <para>
        /// The delivery status.
        /// </para>
        /// </summary>
        public VerifiedAccessLogDeliveryStatus DeliveryStatus
        {
            get { return this._deliveryStatus; }
            set { this._deliveryStatus = value; }
        }

        // Check to see if DeliveryStatus property is set
        internal bool IsSetDeliveryStatus()
        {
            return this._deliveryStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether logging is enabled.
        /// </para>
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// The bucket prefix.
        /// </para>
        /// </summary>
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

    }
}