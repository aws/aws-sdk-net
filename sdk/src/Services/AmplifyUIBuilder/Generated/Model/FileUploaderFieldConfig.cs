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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AmplifyUIBuilder.Model
{
    /// <summary>
    /// Describes the configuration for the file uploader field.
    /// </summary>
    public partial class FileUploaderFieldConfig
    {
        private List<string> _acceptedFileTypes = new List<string>();
        private StorageAccessLevel _accessLevel;
        private bool? _isResumable;
        private int? _maxFileCount;
        private int? _maxSize;
        private bool? _showThumbnails;

        /// <summary>
        /// Gets and sets the property AcceptedFileTypes. 
        /// <para>
        /// The file types that are allowed to be uploaded by the file uploader. Provide this
        /// information in an array of strings specifying the valid file extensions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> AcceptedFileTypes
        {
            get { return this._acceptedFileTypes; }
            set { this._acceptedFileTypes = value; }
        }

        // Check to see if AcceptedFileTypes property is set
        internal bool IsSetAcceptedFileTypes()
        {
            return this._acceptedFileTypes != null && this._acceptedFileTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AccessLevel. 
        /// <para>
        /// The access level to assign to the uploaded files in the Amazon S3 bucket where they
        /// are stored. The valid values for this property are <code>private</code>, <code>protected</code>,
        /// or <code>public</code>. For detailed information about the permissions associated
        /// with each access level, see <a href="https://docs.amplify.aws/lib/storage/configureaccess/q/platform/js/">File
        /// access levels</a> in the <i>Amplify documentation</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StorageAccessLevel AccessLevel
        {
            get { return this._accessLevel; }
            set { this._accessLevel = value; }
        }

        // Check to see if AccessLevel property is set
        internal bool IsSetAccessLevel()
        {
            return this._accessLevel != null;
        }

        /// <summary>
        /// Gets and sets the property IsResumable. 
        /// <para>
        /// Allows the file upload operation to be paused and resumed. The default value is <code>false</code>.
        /// </para>
        ///  
        /// <para>
        /// When <code>isResumable</code> is set to <code>true</code>, the file uploader uses
        /// a multipart upload to break the files into chunks before upload. The progress of the
        /// upload isn't continuous, because the file uploader uploads a chunk at a time.
        /// </para>
        /// </summary>
        public bool IsResumable
        {
            get { return this._isResumable.GetValueOrDefault(); }
            set { this._isResumable = value; }
        }

        // Check to see if IsResumable property is set
        internal bool IsSetIsResumable()
        {
            return this._isResumable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxFileCount. 
        /// <para>
        /// Specifies the maximum number of files that can be selected to upload. The default
        /// value is an unlimited number of files.
        /// </para>
        /// </summary>
        public int MaxFileCount
        {
            get { return this._maxFileCount.GetValueOrDefault(); }
            set { this._maxFileCount = value; }
        }

        // Check to see if MaxFileCount property is set
        internal bool IsSetMaxFileCount()
        {
            return this._maxFileCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxSize. 
        /// <para>
        /// The maximum file size in bytes that the file uploader will accept. The default value
        /// is an unlimited file size.
        /// </para>
        /// </summary>
        public int MaxSize
        {
            get { return this._maxSize.GetValueOrDefault(); }
            set { this._maxSize = value; }
        }

        // Check to see if MaxSize property is set
        internal bool IsSetMaxSize()
        {
            return this._maxSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ShowThumbnails. 
        /// <para>
        /// Specifies whether to display or hide the image preview after selecting a file for
        /// upload. The default value is <code>true</code> to display the image preview.
        /// </para>
        /// </summary>
        public bool ShowThumbnails
        {
            get { return this._showThumbnails.GetValueOrDefault(); }
            set { this._showThumbnails = value; }
        }

        // Check to see if ShowThumbnails property is set
        internal bool IsSetShowThumbnails()
        {
            return this._showThumbnails.HasValue; 
        }

    }
}