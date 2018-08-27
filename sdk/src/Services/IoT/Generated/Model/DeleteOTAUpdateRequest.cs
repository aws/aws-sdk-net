/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteOTAUpdate operation.
    /// Delete an OTA update.
    /// </summary>
    public partial class DeleteOTAUpdateRequest : AmazonIoTRequest
    {
        private bool? _deleteStream;
        private bool? _forceDeleteAWSJob;
        private string _otaUpdateId;

        /// <summary>
        /// Gets and sets the property DeleteStream. 
        /// <para>
        /// Specifies if the stream associated with an OTA update should be deleted when the OTA
        /// update is deleted.
        /// </para>
        /// </summary>
        public bool DeleteStream
        {
            get { return this._deleteStream.GetValueOrDefault(); }
            set { this._deleteStream = value; }
        }

        // Check to see if DeleteStream property is set
        internal bool IsSetDeleteStream()
        {
            return this._deleteStream.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ForceDeleteAWSJob. 
        /// <para>
        /// Specifies if the AWS Job associated with the OTA update should be deleted with the
        /// OTA update is deleted.
        /// </para>
        /// </summary>
        public bool ForceDeleteAWSJob
        {
            get { return this._forceDeleteAWSJob.GetValueOrDefault(); }
            set { this._forceDeleteAWSJob = value; }
        }

        // Check to see if ForceDeleteAWSJob property is set
        internal bool IsSetForceDeleteAWSJob()
        {
            return this._forceDeleteAWSJob.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OtaUpdateId. 
        /// <para>
        /// The OTA update ID to delete.
        /// </para>
        /// </summary>
        public string OtaUpdateId
        {
            get { return this._otaUpdateId; }
            set { this._otaUpdateId = value; }
        }

        // Check to see if OtaUpdateId property is set
        internal bool IsSetOtaUpdateId()
        {
            return this._otaUpdateId != null;
        }

    }
}