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
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKMediaPipelines.Model
{
    /// <summary>
    /// The settings for a post-call voice analytics task.
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
        /// The content redaction output settings for a post-call analysis task.
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
        /// The ARN of the role used by Amazon Web Services Transcribe to upload your post call
        /// analysis. For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/tca-post-call.html">Post-call
        /// analytics with real-time transcriptions</a> in the <i>Amazon Transcribe Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=4096)]
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
        /// The ID of the KMS (Key Management System) key used to encrypt the output.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
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
        /// The URL of the Amazon S3 bucket that contains the post-call data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=4096)]
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