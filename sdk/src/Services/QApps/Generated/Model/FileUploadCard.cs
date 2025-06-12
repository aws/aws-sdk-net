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
 * Do not modify this file. This file is generated from the qapps-2023-11-27.normal.json service model.
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
        private bool? _allowOverride;
        private List<string> _dependencies = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _fileId;
        private string _filename;
        private string _id;
        private string _title;
        private CardType _type;

        /// <summary>
        /// Gets and sets the property AllowOverride. 
        /// <para>
        /// A flag indicating if the user can override the default file for the upload card.
        /// </para>
        /// </summary>
        public bool? AllowOverride
        {
            get { return this._allowOverride; }
            set { this._allowOverride = value; }
        }

        // Check to see if AllowOverride property is set
        internal bool IsSetAllowOverride()
        {
            return this._allowOverride.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Dependencies. 
        /// <para>
        /// Any dependencies or requirements for the file upload card.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Dependencies
        {
            get { return this._dependencies; }
            set { this._dependencies = value; }
        }

        // Check to see if Dependencies property is set
        internal bool IsSetDependencies()
        {
            return this._dependencies != null && (this._dependencies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FileId. 
        /// <para>
        /// The unique identifier of the file associated with the card.
        /// </para>
        /// </summary>
        public string FileId
        {
            get { return this._fileId; }
            set { this._fileId = value; }
        }

        // Check to see if FileId property is set
        internal bool IsSetFileId()
        {
            return this._fileId != null;
        }

        /// <summary>
        /// Gets and sets the property Filename. 
        /// <para>
        /// The name of the file being uploaded.
        /// </para>
        /// </summary>
        public string Filename
        {
            get { return this._filename; }
            set { this._filename = value; }
        }

        // Check to see if Filename property is set
        internal bool IsSetFilename()
        {
            return this._filename != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the file upload card.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the file upload card.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the card.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CardType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}