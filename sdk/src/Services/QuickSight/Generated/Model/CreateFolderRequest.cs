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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the CreateFolder operation.
    /// Creates an empty shared folder.
    /// </summary>
    public partial class CreateFolderRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private string _folderId;
        private FolderType _folderType;
        private string _name;
        private string _parentFolderArn;
        private List<ResourcePermission> _permissions = new List<ResourcePermission>();
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID for the Amazon Web Services account where you want to create the folder.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property FolderId. 
        /// <para>
        /// The ID of the folder.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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
        /// Gets and sets the property FolderType. 
        /// <para>
        /// The type of folder. By default, <code>folderType</code> is <code>SHARED</code>.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the folder.
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
        /// Gets and sets the property ParentFolderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the parent folder.
        /// </para>
        ///  
        /// <para>
        ///  <code>ParentFolderArn</code> can be null. An empty <code>parentFolderArn</code> creates
        /// a root-level folder.
        /// </para>
        /// </summary>
        public string ParentFolderArn
        {
            get { return this._parentFolderArn; }
            set { this._parentFolderArn = value; }
        }

        // Check to see if ParentFolderArn property is set
        internal bool IsSetParentFolderArn()
        {
            return this._parentFolderArn != null;
        }

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// A structure that describes the principals and the resource-level permissions of a
        /// folder.
        /// </para>
        ///  
        /// <para>
        /// To specify no permissions, omit <code>Permissions</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public List<ResourcePermission> Permissions
        {
            get { return this._permissions; }
            set { this._permissions = value; }
        }

        // Check to see if Permissions property is set
        internal bool IsSetPermissions()
        {
            return this._permissions != null && this._permissions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags for the folder.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}