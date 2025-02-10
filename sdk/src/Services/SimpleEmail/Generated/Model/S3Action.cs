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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
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
namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// When included in a receipt rule, this action saves the received message to an Amazon
    /// Simple Storage Service (Amazon S3) bucket and, optionally, publishes a notification
    /// to Amazon Simple Notification Service (Amazon SNS).
    /// 
    ///  
    /// <para>
    /// To enable Amazon SES to write emails to your Amazon S3 bucket, use an Amazon Web Services
    /// KMS key to encrypt your emails, or publish to an Amazon SNS topic of another account,
    /// Amazon SES must have permission to access those resources. For information about granting
    /// permissions, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-permissions.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// When you save your emails to an Amazon S3 bucket, the maximum email size (including
    /// headers) is 40 MB. Emails larger than that bounces.
    /// </para>
    ///  </note> 
    /// <para>
    /// For information about specifying Amazon S3 actions in receipt rules, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-action-s3.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class S3Action
    {
        private string _bucketName;
        private string _iamRoleArn;
        private string _kmsKeyArn;
        private string _objectKeyPrefix;
        private string _topicArn;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the Amazon S3 bucket for incoming email.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        ///  The ARN of the IAM role to be used by Amazon Simple Email Service while writing to
        /// the Amazon S3 bucket, optionally encrypting your mail via the provided customer managed
        /// key, and publishing to the Amazon SNS topic. This role should have access to the following
        /// APIs: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>s3:PutObject</c>, <c>kms:Encrypt</c> and <c>kms:GenerateDataKey</c> for the given
        /// Amazon S3 bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>kms:GenerateDataKey</c> for the given Amazon Web Services KMS customer managed
        /// key. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sns:Publish</c> for the given Amazon SNS topic.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// If an IAM role ARN is provided, the role (and only the role) is used to access all
        /// the given resources (Amazon S3 bucket, Amazon Web Services KMS customer managed key
        /// and Amazon SNS topic). Therefore, setting up individual resource access permissions
        /// is not required.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string IamRoleArn
        {
            get { return this._iamRoleArn; }
            set { this._iamRoleArn = value; }
        }

        // Check to see if IamRoleArn property is set
        internal bool IsSetIamRoleArn()
        {
            return this._iamRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The customer managed key that Amazon SES should use to encrypt your emails before
        /// saving them to the Amazon S3 bucket. You can use the Amazon Web Services managed key
        /// or a customer managed key that you created in Amazon Web Services KMS as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To use the Amazon Web Services managed key, provide an ARN in the form of <c>arn:aws:kms:REGION:ACCOUNT-ID-WITHOUT-HYPHENS:alias/aws/ses</c>.
        /// For example, if your Amazon Web Services account ID is 123456789012 and you want to
        /// use the Amazon Web Services managed key in the US West (Oregon) Region, the ARN of
        /// the Amazon Web Services managed key would be <c>arn:aws:kms:us-west-2:123456789012:alias/aws/ses</c>.
        /// If you use the Amazon Web Services managed key, you don't need to perform any extra
        /// steps to give Amazon SES permission to use the key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To use a customer managed key that you created in Amazon Web Services KMS, provide
        /// the ARN of the customer managed key and ensure that you add a statement to your key's
        /// policy to give Amazon SES permission to use it. For more information about giving
        /// permissions, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-permissions.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about key policies, see the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html">Amazon
        /// Web Services KMS Developer Guide</a>. If you do not specify an Amazon Web Services
        /// KMS key, Amazon SES does not encrypt your emails.
        /// </para>
        ///  <important> 
        /// <para>
        /// Your mail is encrypted by Amazon SES using the Amazon S3 encryption client before
        /// the mail is submitted to Amazon S3 for storage. It is not encrypted using Amazon S3
        /// server-side encryption. This means that you must use the Amazon S3 encryption client
        /// to decrypt the email after retrieving it from Amazon S3, as the service has no access
        /// to use your Amazon Web Services KMS keys for decryption. This encryption client is
        /// currently available with the <a href="http://aws.amazon.com/sdk-for-java/">Amazon
        /// Web Services SDK for Java</a> and <a href="http://aws.amazon.com/sdk-for-ruby/">Amazon
        /// Web Services SDK for Ruby</a> only. For more information about client-side encryption
        /// using Amazon Web Services KMS managed keys, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingClientSideEncryption.html">Amazon
        /// S3 Developer Guide</a>.
        /// </para>
        ///  </important>
        /// </summary>
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectKeyPrefix. 
        /// <para>
        /// The key prefix of the Amazon S3 bucket. The key prefix is similar to a directory name
        /// that enables you to store similar data under the same directory in a bucket.
        /// </para>
        /// </summary>
        public string ObjectKeyPrefix
        {
            get { return this._objectKeyPrefix; }
            set { this._objectKeyPrefix = value; }
        }

        // Check to see if ObjectKeyPrefix property is set
        internal bool IsSetObjectKeyPrefix()
        {
            return this._objectKeyPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property TopicArn. 
        /// <para>
        /// The ARN of the Amazon SNS topic to notify when the message is saved to the Amazon
        /// S3 bucket. You can find the ARN of a topic by using the <a href="https://docs.aws.amazon.com/sns/latest/api/API_ListTopics.html">ListTopics</a>
        /// operation in Amazon SNS.
        /// </para>
        ///  
        /// <para>
        /// For more information about Amazon SNS topics, see the <a href="https://docs.aws.amazon.com/sns/latest/dg/CreateTopic.html">Amazon
        /// SNS Developer Guide</a>.
        /// </para>
        /// </summary>
        public string TopicArn
        {
            get { return this._topicArn; }
            set { this._topicArn = value; }
        }

        // Check to see if TopicArn property is set
        internal bool IsSetTopicArn()
        {
            return this._topicArn != null;
        }

    }
}