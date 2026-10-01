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

namespace Amazon.SecurityIR.Model
{
    /// <summary>
    /// </summary>
    public partial class CaseAttachmentAttributes
    {
        /// <summary>
        /// Gets and sets the property AttachmentId.
        /// </summary>
        [AWSProperty(Required = true)]
        public string AttachmentId { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentId property is set.
        /// </summary>
        internal bool IsSetAttachmentId() => this.AttachmentId != null;

        /// <summary>
        /// Gets and sets the property AttachmentStatus.
        /// </summary>
        [AWSProperty(Required = true)]
        public CaseAttachmentStatus AttachmentStatus { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentStatus property is set.
        /// </summary>
        internal bool IsSetAttachmentStatus() => this.AttachmentStatus != null;

        /// <summary>
        /// Gets and sets the property CreatedDate.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property Creator.
        /// </summary>
        [AWSProperty(Required = true)]
        public string Creator { get; set; }

        /// <summary>
        /// Checks to see if the Creator property is set.
        /// </summary>
        internal bool IsSetCreator() => this.Creator != null;

        /// <summary>
        /// Gets and sets the property FileName.
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 255)]
        public string FileName { get; set; }

        /// <summary>
        /// Checks to see if the FileName property is set.
        /// </summary>
        internal bool IsSetFileName() => this.FileName != null;
    }
}
