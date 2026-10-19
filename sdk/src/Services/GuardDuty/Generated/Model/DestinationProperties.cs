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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains the Amazon Resource Name (ARN) of the resource to publish to, such as an
    /// S3 bucket, and the ARN of the KMS key to use to encrypt published findings.
    /// </summary>
    public partial class DestinationProperties
    {
        private string _destinationArn;
        private string _expectedBucketOwner;
        private string _kmsKeyArn;

        /// <summary>
        /// Gets and sets the property DestinationArn. 
        /// <para>
        /// The ARN of the resource to publish to.
        /// </para>
        ///  
        /// <para>
        /// To specify an S3 bucket folder use the following format: <c>arn:aws:s3:::DOC-EXAMPLE-BUCKET/myFolder/</c>
        /// 
        /// </para>
        /// </summary>
        public string DestinationArn
        {
            get { return this._destinationArn; }
            set { this._destinationArn = value; }
        }

        // Check to see if DestinationArn property is set
        internal bool IsSetDestinationArn()
        {
            return this._destinationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        /// The 12-digit Amazon Web Services account ID of the account that owns the Amazon S3
        /// bucket specified in the <c>DestinationArn</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// When you provide this value, GuardDuty verifies that the specified account owns the
        /// bucket before it exports findings. If the account ID doesn't match the actual owner
        /// of the bucket, GuardDuty doesn't export findings to that bucket. This helps prevent
        /// GuardDuty from exporting your findings to a bucket that a different Amazon Web Services
        /// account owns (for example, if the original bucket was deleted and its name was later
        /// claimed by another account). If you don't specify this value, GuardDuty doesn't perform
        /// this verification. GuardDuty strongly recommends that you provide the expected bucket
        /// owner when possible.
        /// </para>
        ///  
        /// <para>
        /// When you update a publishing destination, omitting this field leaves the currently
        /// stored value unchanged. This field appears in the response only if it was provided
        /// when the publishing destination was created or updated.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty_exportfindings.html#guardduty-exportfindings-expected-bucket-owner">Verifying
        /// the Amazon S3 bucket owner</a> in the <i>Amazon GuardDuty User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string ExpectedBucketOwner
        {
            get { return this._expectedBucketOwner; }
            set { this._expectedBucketOwner = value; }
        }

        // Check to see if ExpectedBucketOwner property is set
        internal bool IsSetExpectedBucketOwner()
        {
            return this._expectedBucketOwner != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The ARN of the KMS key to use for encryption.
        /// </para>
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

    }
}