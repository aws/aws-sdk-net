/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// A logical container used for storing the configuration changes of an AWS resource.
    /// </summary>
    public partial class DeliveryChannel
    {
        private ConfigSnapshotDeliveryProperties _configSnapshotDeliveryProperties;
        private string _name;
        private string _s3BucketName;
        private string _s3KeyPrefix;
        private string _snsTopicARN;

        /// <summary>
        /// Gets and sets the property ConfigSnapshotDeliveryProperties.
        /// </summary>
        public ConfigSnapshotDeliveryProperties ConfigSnapshotDeliveryProperties
        {
            get { return this._configSnapshotDeliveryProperties; }
            set { this._configSnapshotDeliveryProperties = value; }
        }

        // Check to see if ConfigSnapshotDeliveryProperties property is set
        internal bool IsSetConfigSnapshotDeliveryProperties()
        {
            return this._configSnapshotDeliveryProperties != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the delivery channel. By default, AWS Config automatically assigns the
        /// name "default" when creating the delivery channel. You cannot change the assigned
        /// name. 
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property S3BucketName. 
        /// <para>
        /// The name of the Amazon S3 bucket used to store configuration history for the delivery
        /// channel.
        /// </para>
        /// </summary>
        public string S3BucketName
        {
            get { return this._s3BucketName; }
            set { this._s3BucketName = value; }
        }

        // Check to see if S3BucketName property is set
        internal bool IsSetS3BucketName()
        {
            return this._s3BucketName != null;
        }

        /// <summary>
        /// Gets and sets the property S3KeyPrefix. 
        /// <para>
        /// The prefix for the specified Amazon S3 bucket.
        /// </para>
        /// </summary>
        public string S3KeyPrefix
        {
            get { return this._s3KeyPrefix; }
            set { this._s3KeyPrefix = value; }
        }

        // Check to see if S3KeyPrefix property is set
        internal bool IsSetS3KeyPrefix()
        {
            return this._s3KeyPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property SnsTopicARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the SNS topic that AWS Config delivers notifications
        /// to.
        /// </para>
        /// </summary>
        public string SnsTopicARN
        {
            get { return this._snsTopicARN; }
            set { this._snsTopicARN = value; }
        }

        // Check to see if SnsTopicARN property is set
        internal bool IsSetSnsTopicARN()
        {
            return this._snsTopicARN != null;
        }

    }
}