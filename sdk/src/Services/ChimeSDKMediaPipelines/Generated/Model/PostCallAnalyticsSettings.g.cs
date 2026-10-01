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

namespace Amazon.ChimeSDKMediaPipelines.Model
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
    ///  <c>PostCallAnalyticsSettings</c> provides the same insights as a Call Analytics post-call
    /// transcription. For more information, refer to <a href="https://docs.aws.amazon.com/transcribe/latest/dg/tca-post-call.html">Post-call
    /// analytics with real-time transcriptions</a> in the <i>Amazon Transcribe Developer
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial class PostCallAnalyticsSettings
    {
        /// <summary>
        /// Gets and sets the property ContentRedactionOutput. 
        /// <para>
        /// The content redaction output settings for a post-call analysis task.
        /// </para>
        /// </summary>
        public ContentRedactionOutput ContentRedactionOutput { get; set; }

        /// <summary>
        /// Checks to see if the ContentRedactionOutput property is set.
        /// </summary>
        internal bool IsSetContentRedactionOutput() => this.ContentRedactionOutput != null;

        /// <summary>
        /// Gets and sets the property DataAccessRoleArn. 
        /// <para>
        /// The ARN of the role used by Amazon Web Services Transcribe to upload your post call
        /// analysis. For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/tca-post-call.html">Post-call
        /// analytics with real-time transcriptions</a> in the <i>Amazon Transcribe Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 4096)]
        public string DataAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the DataAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetDataAccessRoleArn() => this.DataAccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property OutputEncryptionKMSKeyId. 
        /// <para>
        /// The ID of the KMS (Key Management Service) key used to encrypt the output.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string OutputEncryptionKMSKeyId { get; set; }

        /// <summary>
        /// Checks to see if the OutputEncryptionKMSKeyId property is set.
        /// </summary>
        internal bool IsSetOutputEncryptionKMSKeyId() => this.OutputEncryptionKMSKeyId != null;

        /// <summary>
        /// Gets and sets the property OutputLocation. 
        /// <para>
        /// The URL of the Amazon S3 bucket that contains the post-call data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 4096)]
        public string OutputLocation { get; set; }

        /// <summary>
        /// Checks to see if the OutputLocation property is set.
        /// </summary>
        internal bool IsSetOutputLocation() => this.OutputLocation != null;
    }
}
