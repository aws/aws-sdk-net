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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the CreateOTAUpdate operation.
    /// </summary>
    public partial class CreateOTAUpdateResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AwsIotJobArn. 
        /// <para>
        /// The IoT job ARN associated with the OTA update.
        /// </para>
        /// </summary>
        public string AwsIotJobArn { get; set; }

        /// <summary>
        /// Checks to see if the AwsIotJobArn property is set.
        /// </summary>
        internal bool IsSetAwsIotJobArn() => this.AwsIotJobArn != null;

        /// <summary>
        /// Gets and sets the property AwsIotJobId. 
        /// <para>
        /// The IoT job ID associated with the OTA update.
        /// </para>
        /// </summary>
        public string AwsIotJobId { get; set; }

        /// <summary>
        /// Checks to see if the AwsIotJobId property is set.
        /// </summary>
        internal bool IsSetAwsIotJobId() => this.AwsIotJobId != null;

        /// <summary>
        /// Gets and sets the property OtaUpdateArn. 
        /// <para>
        /// The OTA update ARN.
        /// </para>
        /// </summary>
        public string OtaUpdateArn { get; set; }

        /// <summary>
        /// Checks to see if the OtaUpdateArn property is set.
        /// </summary>
        internal bool IsSetOtaUpdateArn() => this.OtaUpdateArn != null;

        /// <summary>
        /// Gets and sets the property OtaUpdateId. 
        /// <para>
        /// The OTA update ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string OtaUpdateId { get; set; }

        /// <summary>
        /// Checks to see if the OtaUpdateId property is set.
        /// </summary>
        internal bool IsSetOtaUpdateId() => this.OtaUpdateId != null;

        /// <summary>
        /// Gets and sets the property OtaUpdateStatus. 
        /// <para>
        /// The OTA update status.
        /// </para>
        /// </summary>
        public OTAUpdateStatus OtaUpdateStatus { get; set; }

        /// <summary>
        /// Checks to see if the OtaUpdateStatus property is set.
        /// </summary>
        internal bool IsSetOtaUpdateStatus() => this.OtaUpdateStatus != null;
    }
}
