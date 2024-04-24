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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// The channel through which Config delivers notifications and updated configuration
    /// states.
    /// </summary>
    public partial class DeliveryChannel
    {
        private ConfigSnapshotDeliveryProperties _configSnapshotDeliveryProperties;
        private string _name;
        private string _s3BucketName;
        private string _s3KeyPrefix;
        private string _s3KmsKeyArn;
        private string _snsTopicARN;

        /// <summary>
        /// Gets and sets the property ConfigSnapshotDeliveryProperties. 
        /// <para>
        /// The options for how often Config delivers configuration snapshots to the Amazon S3
        /// bucket.
        /// </para>
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
        /// The name of the delivery channel. By default, Config assigns the name "default" when
        /// creating the delivery channel. To change the delivery channel name, you must use the
        /// DeleteDeliveryChannel action to delete your current delivery channel, and then you
        /// must use the PutDeliveryChannel command to create a delivery channel that has the
        /// desired name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// The name of the Amazon S3 bucket to which Config delivers configuration snapshots
        /// and configuration history files.
        /// </para>
        ///  
        /// <para>
        /// If you specify a bucket that belongs to another Amazon Web Services account, that
        /// bucket must have policies that grant access permissions to Config. For more information,
        /// see <a href="https://docs.aws.amazon.com/config/latest/developerguide/s3-bucket-policy.html">Permissions
        /// for the Amazon S3 Bucket</a> in the <i>Config Developer Guide</i>.
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
        /// Gets and sets the property S3KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Key Management Service (KMS ) KMS key (KMS key)
        /// used to encrypt objects delivered by Config. Must belong to the same Region as the
        /// destination S3 bucket.
        /// </para>
        /// </summary>
        public string S3KmsKeyArn
        {
            get { return this._s3KmsKeyArn; }
            set { this._s3KmsKeyArn = value; }
        }

        // Check to see if S3KmsKeyArn property is set
        internal bool IsSetS3KmsKeyArn()
        {
            return this._s3KmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property SnsTopicARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon SNS topic to which Config sends notifications
        /// about configuration changes.
        /// </para>
        ///  
        /// <para>
        /// If you choose a topic from another account, the topic must have policies that grant
        /// access permissions to Config. For more information, see <a href="https://docs.aws.amazon.com/config/latest/developerguide/sns-topic-policy.html">Permissions
        /// for the Amazon SNS Topic</a> in the <i>Config Developer Guide</i>.
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