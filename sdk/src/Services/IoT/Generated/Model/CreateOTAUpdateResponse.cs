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
    /// This is the response object from the CreateOTAUpdate operation.
    /// </summary>
    public partial class CreateOTAUpdateResponse : AmazonWebServiceResponse
    {
        private string _awsIotJobArn;
        private string _awsIotJobId;
        private string _otaUpdateArn;
        private string _otaUpdateId;
        private OTAUpdateStatus _otaUpdateStatus;

        /// <summary>
        /// Gets and sets the property AwsIotJobArn. 
        /// <para>
        /// The IoT job ARN associated with the OTA update.
        /// </para>
        /// </summary>
        public string AwsIotJobArn
        {
            get { return this._awsIotJobArn; }
            set { this._awsIotJobArn = value; }
        }

        // Check to see if AwsIotJobArn property is set
        internal bool IsSetAwsIotJobArn()
        {
            return this._awsIotJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property AwsIotJobId. 
        /// <para>
        /// The IoT job ID associated with the OTA update.
        /// </para>
        /// </summary>
        public string AwsIotJobId
        {
            get { return this._awsIotJobId; }
            set { this._awsIotJobId = value; }
        }

        // Check to see if AwsIotJobId property is set
        internal bool IsSetAwsIotJobId()
        {
            return this._awsIotJobId != null;
        }

        /// <summary>
        /// Gets and sets the property OtaUpdateArn. 
        /// <para>
        /// The OTA update ARN.
        /// </para>
        /// </summary>
        public string OtaUpdateArn
        {
            get { return this._otaUpdateArn; }
            set { this._otaUpdateArn = value; }
        }

        // Check to see if OtaUpdateArn property is set
        internal bool IsSetOtaUpdateArn()
        {
            return this._otaUpdateArn != null;
        }

        /// <summary>
        /// Gets and sets the property OtaUpdateId. 
        /// <para>
        /// The OTA update ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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

        /// <summary>
        /// Gets and sets the property OtaUpdateStatus. 
        /// <para>
        /// The OTA update status.
        /// </para>
        /// </summary>
        public OTAUpdateStatus OtaUpdateStatus
        {
            get { return this._otaUpdateStatus; }
            set { this._otaUpdateStatus = value; }
        }

        // Check to see if OtaUpdateStatus property is set
        internal bool IsSetOtaUpdateStatus()
        {
            return this._otaUpdateStatus != null;
        }

    }
}