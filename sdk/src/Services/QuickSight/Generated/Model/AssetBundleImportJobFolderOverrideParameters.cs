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
    /// The override parameters for a single folder that is being imported.
    /// </summary>
    public partial class AssetBundleImportJobFolderOverrideParameters
    {
        private string _folderId;
        private string _name;
        private string _parentFolderArn;

        /// <summary>
        /// Gets and sets the property FolderId. 
        /// <para>
        /// The ID of the folder that you want to apply overrides to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// A new name for the folder.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// A new parent folder arn. This change can only be applied if the import creates a brand
        /// new folder. Existing folders cannot be moved.
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

    }
}