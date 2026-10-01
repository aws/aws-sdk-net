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

namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// This is the response object from the CreateSoftwareUpdateJob operation.
    /// </summary>
    public partial class CreateSoftwareUpdateJobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property IotJobArn. The IoT Job ARN corresponding to this update.
        /// </summary>
        public string IotJobArn { get; set; }

        /// <summary>
        /// Checks to see if the IotJobArn property is set.
        /// </summary>
        internal bool IsSetIotJobArn() => this.IotJobArn != null;

        /// <summary>
        /// Gets and sets the property IotJobId. The IoT Job Id corresponding to this update.
        /// </summary>
        public string IotJobId { get; set; }

        /// <summary>
        /// Checks to see if the IotJobId property is set.
        /// </summary>
        internal bool IsSetIotJobId() => this.IotJobId != null;

        /// <summary>
        /// Gets and sets the property PlatformSoftwareVersion. The software version installed
        /// on the device or devices after the update.
        /// </summary>
        public string PlatformSoftwareVersion { get; set; }

        /// <summary>
        /// Checks to see if the PlatformSoftwareVersion property is set.
        /// </summary>
        internal bool IsSetPlatformSoftwareVersion() => this.PlatformSoftwareVersion != null;
    }
}
