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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A folder in QuickSight.
    /// </summary>
    public partial class Folder
    {
        private string _arn;
        private DateTime? _createdTime;
        private string _folderId;
        private List<string> _folderPath = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private FolderType _folderType;
        private DateTime? _lastUpdatedTime;
        private string _name;
        private SharingModel _sharingModel;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the folder.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time that the folder was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FolderId. 
        /// <para>
        /// The ID of the folder.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string FolderId
        {
            get { return this._folderId; }
            set { this._folderId = value; }
        }

        // Check to see if FolderId property is set
        internal bool IsSetFolderId()
        {
            return this._folderId != null;
        }

        /// <summary>
        /// Gets and sets the property FolderPath. 
        /// <para>
        /// An array of ancestor ARN strings for the folder.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> FolderPath
        {
            get { return this._folderPath; }
            set { this._folderPath = value; }
        }

        // Check to see if FolderPath property is set
        internal bool IsSetFolderPath()
        {
            return this._folderPath != null && (this._folderPath.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FolderType. 
        /// <para>
        /// The type of folder it is.
        /// </para>
        /// </summary>
        public FolderType FolderType
        {
            get { return this._folderType; }
            set { this._folderType = value; }
        }

        // Check to see if FolderType property is set
        internal bool IsSetFolderType()
        {
            return this._folderType != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time that the folder was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A display name for the folder.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SharingModel. 
        /// <para>
        /// The sharing scope of the folder.
        /// </para>
        /// </summary>
        public SharingModel SharingModel
        {
            get { return this._sharingModel; }
            set { this._sharingModel = value; }
        }

        // Check to see if SharingModel property is set
        internal bool IsSetSharingModel()
        {
            return this._sharingModel != null;
        }

    }
}