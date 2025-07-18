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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Configuration to control how SageMaker AI captures inference data.
    /// </summary>
    public partial class DataCaptureConfig
    {
        private CaptureContentTypeHeader _captureContentTypeHeader;
        private List<CaptureOption> _captureOptions = AWSConfigs.InitializeCollections ? new List<CaptureOption>() : null;
        private string _destinationS3Uri;
        private bool? _enableCapture;
        private int? _initialSamplingPercentage;
        private string _kmsKeyId;

        /// <summary>
        /// Gets and sets the property CaptureContentTypeHeader. 
        /// <para>
        /// Configuration specifying how to treat different headers. If no headers are specified
        /// SageMaker AI will by default base64 encode when capturing the data.
        /// </para>
        /// </summary>
        public CaptureContentTypeHeader CaptureContentTypeHeader
        {
            get { return this._captureContentTypeHeader; }
            set { this._captureContentTypeHeader = value; }
        }

        // Check to see if CaptureContentTypeHeader property is set
        internal bool IsSetCaptureContentTypeHeader()
        {
            return this._captureContentTypeHeader != null;
        }

        /// <summary>
        /// Gets and sets the property CaptureOptions. 
        /// <para>
        /// Specifies data Model Monitor will capture. You can configure whether to collect only
        /// input, only output, or both
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public List<CaptureOption> CaptureOptions
        {
            get { return this._captureOptions; }
            set { this._captureOptions = value; }
        }

        // Check to see if CaptureOptions property is set
        internal bool IsSetCaptureOptions()
        {
            return this._captureOptions != null && (this._captureOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DestinationS3Uri. 
        /// <para>
        /// The Amazon S3 location used to capture the data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=512)]
        public string DestinationS3Uri
        {
            get { return this._destinationS3Uri; }
            set { this._destinationS3Uri = value; }
        }

        // Check to see if DestinationS3Uri property is set
        internal bool IsSetDestinationS3Uri()
        {
            return this._destinationS3Uri != null;
        }

        /// <summary>
        /// Gets and sets the property EnableCapture. 
        /// <para>
        /// Whether data capture should be enabled or disabled (defaults to enabled).
        /// </para>
        /// </summary>
        public bool? EnableCapture
        {
            get { return this._enableCapture; }
            set { this._enableCapture = value; }
        }

        // Check to see if EnableCapture property is set
        internal bool IsSetEnableCapture()
        {
            return this._enableCapture.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InitialSamplingPercentage. 
        /// <para>
        /// The percentage of requests SageMaker AI will capture. A lower value is recommended
        /// for Endpoints with high traffic.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public int? InitialSamplingPercentage
        {
            get { return this._initialSamplingPercentage; }
            set { this._initialSamplingPercentage = value; }
        }

        // Check to see if InitialSamplingPercentage property is set
        internal bool IsSetInitialSamplingPercentage()
        {
            return this._initialSamplingPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an Key Management Service key that SageMaker AI
        /// uses to encrypt the captured data at rest using Amazon S3 server-side encryption.
        /// </para>
        ///  
        /// <para>
        /// The KmsKeyId can be any of the following formats: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ID: <c>1234abcd-12ab-34cd-56ef-1234567890ab</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key ARN: <c>arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias name: <c>alias/ExampleAlias</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias name ARN: <c>arn:aws:kms:us-west-2:111122223333:alias/ExampleAlias</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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

    }
}