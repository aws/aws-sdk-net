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
 * Do not modify this file. This file is generated from the transcribe-streaming-2017-10-26.normal.json service model.
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
namespace Amazon.TranscribeStreaming.Model
{
    /// <summary>
    /// Allows you to specify additional settings for your Call Analytics post-call request,
    /// including output locations for your redacted transcript, which IAM role to use, and
    /// which encryption key to use.
    /// 
    ///  
    /// <para>
    ///  <c>DataAccessRoleArn</c> and <c>OutputLocation</c> are required fields.
    /// </para>
    ///  
    /// <para>
    ///  <c>PostCallAnalyticsSettings</c> provides you with the same insights as a Call Analytics
    /// post-call transcription. Refer to <a href="https://docs.aws.amazon.com/transcribe/latest/dg/tca-post-call.html">Post-call
    /// analytics</a> for more information on this feature.
    /// </para>
    /// </summary>
    public partial class PostCallAnalyticsSettings
    {
        private ContentRedactionOutput _contentRedactionOutput;
        private string _dataAccessRoleArn;
        private string _outputEncryptionKMSKeyId;
        private string _outputLocation;

        /// <summary>
        /// Gets and sets the property ContentRedactionOutput. 
        /// <para>
        /// Specify whether you want only a redacted transcript or both a redacted and an unredacted
        /// transcript. If you choose redacted and unredacted, two JSON files are generated and
        /// stored in the Amazon S3 output location you specify.
        /// </para>
        ///  
        /// <para>
        /// Note that to include <c>ContentRedactionOutput</c> in your request, you must enable
        /// content redaction (<c>ContentRedactionType</c>).
        /// </para>
        /// </summary>
        public ContentRedactionOutput ContentRedactionOutput
        {
            get { return this._contentRedactionOutput; }
            set { this._contentRedactionOutput = value; }
        }

        // Check to see if ContentRedactionOutput property is set
        internal bool IsSetContentRedactionOutput()
        {
            return this._contentRedactionOutput != null;
        }

        /// <summary>
        /// Gets and sets the property DataAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that has permissions to access the Amazon
        /// S3 bucket that contains your input files. If the role that you specify doesn’t have
        /// the appropriate permissions to access the specified Amazon S3 location, your request
        /// fails.
        /// </para>
        ///  
        /// <para>
        /// IAM role ARNs have the format <c>arn:partition:iam::account:role/role-name-with-path</c>.
        /// For example: <c>arn:aws:iam::111122223333:role/Admin</c>. For more information, see
        /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_identifiers.html#identifiers-arns">IAM
        /// ARNs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DataAccessRoleArn
        {
            get { return this._dataAccessRoleArn; }
            set { this._dataAccessRoleArn = value; }
        }

        // Check to see if DataAccessRoleArn property is set
        internal bool IsSetDataAccessRoleArn()
        {
            return this._dataAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property OutputEncryptionKMSKeyId. 
        /// <para>
        /// The KMS key you want to use to encrypt your Call Analytics post-call output.
        /// </para>
        ///  
        /// <para>
        /// If using a key located in the <b>current</b> Amazon Web Services account, you can
        /// specify your KMS key in one of four ways:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use the KMS key ID itself. For example, <c>1234abcd-12ab-34cd-56ef-1234567890ab</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an alias for the KMS key ID. For example, <c>alias/ExampleAlias</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the Amazon Resource Name (ARN) for the KMS key ID. For example, <c>arn:aws:kms:region:account-ID:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the ARN for the KMS key alias. For example, <c>arn:aws:kms:region:account-ID:alias/ExampleAlias</c>.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// If using a key located in a <b>different</b> Amazon Web Services account than the
        /// current Amazon Web Services account, you can specify your KMS key in one of two ways:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use the ARN for the KMS key ID. For example, <c>arn:aws:kms:region:account-ID:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the ARN for the KMS key alias. For example, <c>arn:aws:kms:region:account-ID:alias/ExampleAlias</c>.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// Note that the role making the request must have permission to use the specified KMS
        /// key.
        /// </para>
        /// </summary>
        public string OutputEncryptionKMSKeyId
        {
            get { return this._outputEncryptionKMSKeyId; }
            set { this._outputEncryptionKMSKeyId = value; }
        }

        // Check to see if OutputEncryptionKMSKeyId property is set
        internal bool IsSetOutputEncryptionKMSKeyId()
        {
            return this._outputEncryptionKMSKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property OutputLocation. 
        /// <para>
        /// The Amazon S3 location where you want your Call Analytics post-call transcription
        /// output stored. You can use any of the following formats to specify the output location:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// s3://DOC-EXAMPLE-BUCKET
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// s3://DOC-EXAMPLE-BUCKET/my-output-folder/
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// s3://DOC-EXAMPLE-BUCKET/my-output-folder/my-call-analytics-job.json
        /// </para>
        ///  </li> </ol>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OutputLocation
        {
            get { return this._outputLocation; }
            set { this._outputLocation = value; }
        }

        // Check to see if OutputLocation property is set
        internal bool IsSetOutputLocation()
        {
            return this._outputLocation != null;
        }

    }
}