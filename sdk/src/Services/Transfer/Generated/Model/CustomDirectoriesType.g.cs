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

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Contains Amazon S3 locations for storing specific types of AS2 message files.
    /// </summary>
    public partial class CustomDirectoriesType
    {
        /// <summary>
        /// Gets and sets the property FailedFilesDirectory. 
        /// <para>
        /// Specifies a location to store failed AS2 message files.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string FailedFilesDirectory { get; set; }

        /// <summary>
        /// Checks to see if the FailedFilesDirectory property is set.
        /// </summary>
        internal bool IsSetFailedFilesDirectory() => this.FailedFilesDirectory != null;

        /// <summary>
        /// Gets and sets the property MdnFilesDirectory. 
        /// <para>
        /// Specifies a location to store MDN files.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string MdnFilesDirectory { get; set; }

        /// <summary>
        /// Checks to see if the MdnFilesDirectory property is set.
        /// </summary>
        internal bool IsSetMdnFilesDirectory() => this.MdnFilesDirectory != null;

        /// <summary>
        /// Gets and sets the property PayloadFilesDirectory. 
        /// <para>
        /// Specifies a location to store the payload for AS2 message files.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string PayloadFilesDirectory { get; set; }

        /// <summary>
        /// Checks to see if the PayloadFilesDirectory property is set.
        /// </summary>
        internal bool IsSetPayloadFilesDirectory() => this.PayloadFilesDirectory != null;

        /// <summary>
        /// Gets and sets the property StatusFilesDirectory. 
        /// <para>
        /// Specifies a location to store AS2 status messages.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string StatusFilesDirectory { get; set; }

        /// <summary>
        /// Checks to see if the StatusFilesDirectory property is set.
        /// </summary>
        internal bool IsSetStatusFilesDirectory() => this.StatusFilesDirectory != null;

        /// <summary>
        /// Gets and sets the property TemporaryFilesDirectory. 
        /// <para>
        /// Specifies a location to store temporary AS2 message files.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string TemporaryFilesDirectory { get; set; }

        /// <summary>
        /// Checks to see if the TemporaryFilesDirectory property is set.
        /// </summary>
        internal bool IsSetTemporaryFilesDirectory() => this.TemporaryFilesDirectory != null;
    }
}
