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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Container for the parameters to the CreateFaceLivenessSession operation.
    /// This API operation initiates a Face Liveness session. It returns a <code>SessionId</code>,
    /// which you can use to start streaming Face Liveness video and get the results for a
    /// Face Liveness session. You can use the <code>OutputConfig</code> option in the Settings
    /// parameter to provide an Amazon S3 bucket location. The Amazon S3 bucket stores reference
    /// images and audit images. You can use <code>AuditImagesLimit</code> to limit the number
    /// of audit images returned. This number is between 0 and 4. By default, it is set to
    /// 0. The limit is best effort and based on the duration of the selfie-video.
    /// </summary>
    public partial class CreateFaceLivenessSessionRequest : AmazonRekognitionRequest
    {
        private string _clientRequestToken;
        private string _kmsKeyId;
        private CreateFaceLivenessSessionRequestSettings _settings;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// Idempotent token is used to recognize the Face Liveness request. If the same token
        /// is used with multiple <code>CreateFaceLivenessSession</code> requests, the same session
        /// is returned. This token is employed to avoid unintentionally creating the same session
        /// multiple times.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        ///  The identifier for your AWS Key Management Service key (AWS KMS key). Used to encrypt
        /// audit images and reference images.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property Settings. 
        /// <para>
        /// A session settings object. It contains settings for the operation to be performed.
        /// For Face Liveness, it accepts <code>OutputConfig</code> and <code>AuditImagesLimit</code>.
        /// </para>
        /// </summary>
        public CreateFaceLivenessSessionRequestSettings Settings
        {
            get { return this._settings; }
            set { this._settings = value; }
        }

        // Check to see if Settings property is set
        internal bool IsSetSettings()
        {
            return this._settings != null;
        }

    }
}