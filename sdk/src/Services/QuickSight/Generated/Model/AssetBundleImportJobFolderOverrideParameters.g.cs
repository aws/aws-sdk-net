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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The override parameters for a single folder that is being imported.
    /// </summary>
    public partial class AssetBundleImportJobFolderOverrideParameters
    {
        /// <summary>
        /// Gets and sets the property FolderId. 
        /// <para>
        /// The ID of the folder that you want to apply overrides to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FolderId { get; set; }

        /// <summary>
        /// Checks to see if the FolderId property is set.
        /// </summary>
        internal bool IsSetFolderId() => this.FolderId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A new name for the folder.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ParentFolderArn. 
        /// <para>
        /// A new parent folder arn. This change can only be applied if the import creates a brand
        /// new folder. Existing folders cannot be moved.
        /// </para>
        /// </summary>
        public string ParentFolderArn { get; set; }

        /// <summary>
        /// Checks to see if the ParentFolderArn property is set.
        /// </summary>
        internal bool IsSetParentFolderArn() => this.ParentFolderArn != null;
    }
}
