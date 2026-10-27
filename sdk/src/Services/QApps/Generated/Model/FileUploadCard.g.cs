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
    /// A card in an Amazon Q App that allows the user to upload a file.
    /// </summary>
    public partial class FileUploadCard
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
        /// Gets and sets the property Dependencies. 
        /// <para>
        /// Any dependencies or requirements for the file upload card.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> Dependencies { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Dependencies property is set.
        /// </summary>
        internal bool IsSetDependencies() => this.Dependencies != null && (this.Dependencies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FileId. 
        /// <para>
        /// The unique identifier of the file associated with the card.
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
        /// The name of the file being uploaded.
        /// </para>
        /// </summary>
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
        /// The title of the file upload card.
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
