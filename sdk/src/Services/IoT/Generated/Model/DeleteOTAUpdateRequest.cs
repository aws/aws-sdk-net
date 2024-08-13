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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteOTAUpdate operation.
    /// Delete an OTA update.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeleteOTAUpdate</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class DeleteOTAUpdateRequest : AmazonIoTRequest
    {
        private bool? _deleteStream;
        private bool? _forceDeleteAWSJob;
        private string _otaUpdateId;

        /// <summary>
        /// Gets and sets the property DeleteStream. 
        /// <para>
        /// When true, the stream created by the OTAUpdate process is deleted when the OTA update
        /// is deleted. Ignored if the stream specified in the OTAUpdate is supplied by the user.
        /// </para>
        /// </summary>
        public bool? DeleteStream
        {
            get { return this._deleteStream; }
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
        /// When true, deletes the IoT job created by the OTAUpdate process even if it is "IN_PROGRESS".
        /// Otherwise, if the job is not in a terminal state ("COMPLETED" or "CANCELED") an exception
        /// will occur. The default is false.
        /// </para>
        /// </summary>
        public bool? ForceDeleteAWSJob
        {
            get { return this._forceDeleteAWSJob; }
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
        /// The ID of the OTA update to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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