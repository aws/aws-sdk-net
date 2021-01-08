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
    /// 
    /// </summary>
    public partial class DataCaptureConfigSummary
    {
        private CaptureStatus _captureStatus;
        private int? _currentSamplingPercentage;
        private string _destinationS3Uri;
        private bool? _enableCapture;
        private string _kmsKeyId;

        /// <summary>
        /// Gets and sets the property CaptureStatus.
        /// </summary>
        [AWSProperty(Required=true)]
        public CaptureStatus CaptureStatus
        {
            get { return this._captureStatus; }
            set { this._captureStatus = value; }
        }

        // Check to see if CaptureStatus property is set
        internal bool IsSetCaptureStatus()
        {
            return this._captureStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentSamplingPercentage.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public int CurrentSamplingPercentage
        {
            get { return this._currentSamplingPercentage.GetValueOrDefault(); }
            set { this._currentSamplingPercentage = value; }
        }

        // Check to see if CurrentSamplingPercentage property is set
        internal bool IsSetCurrentSamplingPercentage()
        {
            return this._currentSamplingPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DestinationS3Uri.
        /// </summary>
        [AWSProperty(Required=true, Max=512)]
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
        /// </summary>
        [AWSProperty(Required=true)]
        public bool EnableCapture
        {
            get { return this._enableCapture.GetValueOrDefault(); }
            set { this._enableCapture = value; }
        }

        // Check to see if EnableCapture property is set
        internal bool IsSetEnableCapture()
        {
            return this._enableCapture.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId.
        /// </summary>
        [AWSProperty(Required=true, Max=2048)]
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