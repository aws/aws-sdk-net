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
    /// A summary of information about an existing Quick Sight folder.
    /// </summary>
    public partial class FolderSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the folder.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time that the folder was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property FolderId. 
        /// <para>
        /// The ID of the folder.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string FolderId { get; set; }

        /// <summary>
        /// Checks to see if the FolderId property is set.
        /// </summary>
        internal bool IsSetFolderId() => this.FolderId != null;

        /// <summary>
        /// Gets and sets the property FolderType. 
        /// <para>
        /// The type of folder.
        /// </para>
        /// </summary>
        public FolderType FolderType { get; set; }

        /// <summary>
        /// Checks to see if the FolderType property is set.
        /// </summary>
        internal bool IsSetFolderType() => this.FolderType != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time that the folder was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The display name of the folder.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SharingModel. 
        /// <para>
        /// The sharing scope of the folder.
        /// </para>
        /// </summary>
        public SharingModel SharingModel { get; set; }

        /// <summary>
        /// Checks to see if the SharingModel property is set.
        /// </summary>
        internal bool IsSetSharingModel() => this.SharingModel != null;
    }
}
