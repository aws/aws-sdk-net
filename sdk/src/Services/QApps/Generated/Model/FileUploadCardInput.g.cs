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

namespace Amazon.QApps.Model
{
    /// <summary>
    /// Represents a file upload card. It can optionally receive a <c>filename</c> and <c>fileId</c>
    /// to set a default file. If not received, the user must provide the file when the Q
    /// App runs.
    /// </summary>
    public partial class FileUploadCardInput
    {
        /// <summary>
        /// Gets and sets the property AllowOverride. 
        /// <para>
        /// A flag indicating if the user can override the default file for the upload card.
        /// </para>
        /// </summary>
        public bool? AllowOverride { get; set; }

        /// <summary>
        /// Checks to see if the AllowOverride property is set.
        /// </summary>
        internal bool IsSetAllowOverride() => this.AllowOverride.HasValue;

        /// <summary>
        /// Gets and sets the property FileId. 
        /// <para>
        /// The identifier of a pre-uploaded file associated with the card.
        /// </para>
        /// </summary>
        public string FileId { get; set; }

        /// <summary>
        /// Checks to see if the FileId property is set.
        /// </summary>
        internal bool IsSetFileId() => this.FileId != null;

        /// <summary>
        /// Gets and sets the property Filename. 
        /// <para>
        /// The default filename to use for the file upload card.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 100)]
        public string Filename { get; set; }

        /// <summary>
        /// Checks to see if the Filename property is set.
        /// </summary>
        internal bool IsSetFilename() => this.Filename != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the file upload card.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title or label of the file upload card.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 100)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the card.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CardType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
