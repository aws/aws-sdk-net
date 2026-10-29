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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// This is the response object from the CreateAttachedFile operation.
    /// </summary>
    public partial class CreateAttachedFileResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time of Creation of the file resource as an ISO timestamp. It's specified in ISO
        /// 8601 format: <c>yyyy-MM-ddThh:mm:ss.SSSZ</c>. For example, <c>2024-05-03T02:41:28.172Z</c>.
        /// </para>
        /// </summary>
        public string CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime != null;

        /// <summary>
        /// Gets and sets the property FileArn. 
        /// <para>
        /// The unique identifier of the attached file resource (ARN).
        /// </para>
        /// </summary>
        public string FileArn { get; set; }

        /// <summary>
        /// Checks to see if the FileArn property is set.
        /// </summary>
        internal bool IsSetFileArn() => this.FileArn != null;

        /// <summary>
        /// Gets and sets the property FileId. 
        /// <para>
        /// The unique identifier of the attached file resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string FileId { get; set; }

        /// <summary>
        /// Checks to see if the FileId property is set.
        /// </summary>
        internal bool IsSetFileId() => this.FileId != null;

        /// <summary>
        /// Gets and sets the property FileStatus. 
        /// <para>
        /// The current status of the attached file. Valid values: <c>PROCESSING</c> | <c>APPROVED</c>
        /// | <c>REJECTED</c> | <c>FAILED</c>.
        /// </para>
        /// </summary>
        public FileStatusType FileStatus { get; set; }

        /// <summary>
        /// Checks to see if the FileStatus property is set.
        /// </summary>
        internal bool IsSetFileStatus() => this.FileStatus != null;
    }
}
