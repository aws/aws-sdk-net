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

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Describes a file share. Only supported S3 File Gateway.
    /// </summary>
    public partial class FileShareInfo
    {
        /// <summary>
        /// Gets and sets the property FileShareARN.
        /// </summary>
        [AWSProperty(Min = 50, Max = 500)]
        public string FileShareARN { get; set; }

        /// <summary>
        /// Checks to see if the FileShareARN property is set.
        /// </summary>
        internal bool IsSetFileShareARN() => this.FileShareARN != null;

        /// <summary>
        /// Gets and sets the property FileShareId.
        /// </summary>
        [AWSProperty(Min = 12, Max = 30)]
        public string FileShareId { get; set; }

        /// <summary>
        /// Checks to see if the FileShareId property is set.
        /// </summary>
        internal bool IsSetFileShareId() => this.FileShareId != null;

        /// <summary>
        /// Gets and sets the property FileShareStatus.
        /// </summary>
        [AWSProperty(Min = 3, Max = 50)]
        public string FileShareStatus { get; set; }

        /// <summary>
        /// Checks to see if the FileShareStatus property is set.
        /// </summary>
        internal bool IsSetFileShareStatus() => this.FileShareStatus != null;

        /// <summary>
        /// Gets and sets the property FileShareType.
        /// </summary>
        public FileShareType FileShareType { get; set; }

        /// <summary>
        /// Checks to see if the FileShareType property is set.
        /// </summary>
        internal bool IsSetFileShareType() => this.FileShareType != null;

        /// <summary>
        /// Gets and sets the property GatewayARN.
        /// </summary>
        [AWSProperty(Min = 50, Max = 500)]
        public string GatewayARN { get; set; }

        /// <summary>
        /// Checks to see if the GatewayARN property is set.
        /// </summary>
        internal bool IsSetGatewayARN() => this.GatewayARN != null;
    }
}
