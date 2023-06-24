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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The Amazon S3 location and configuration for storing inference request and response
    /// data.
    /// </summary>
    public partial class InferenceExperimentDataStorageConfig
    {
        private CaptureContentTypeHeader _contentType;
        private string _destination;
        private string _kmsKey;

        /// <summary>
        /// Gets and sets the property ContentType.
        /// </summary>
        public CaptureContentTypeHeader ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The Amazon S3 bucket where the inference request and response data is stored. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=512)]
        public string Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKey. 
        /// <para>
        ///  The Amazon Web Services Key Management Service key that Amazon SageMaker uses to
        /// encrypt captured data at rest using Amazon S3 server-side encryption. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string KmsKey
        {
            get { return this._kmsKey; }
            set { this._kmsKey = value; }
        }

        // Check to see if KmsKey property is set
        internal bool IsSetKmsKey()
        {
            return this._kmsKey != null;
        }

    }
}