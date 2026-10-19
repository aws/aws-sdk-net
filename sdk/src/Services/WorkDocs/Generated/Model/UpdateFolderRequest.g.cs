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

namespace Amazon.WorkDocs.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateFolder operation. Updates the specified
    /// attributes of the specified folder. The user must have access to both the folder and
    /// its parent folder, if applicable.
    /// </summary>
    public partial class UpdateFolderRequest : AmazonWorkDocsRequest
    {
        /// <summary>
        /// Gets and sets the property AuthenticationToken. 
        /// <para>
        /// Amazon WorkDocs authentication token. Not required when using Amazon Web Services
        /// administrator credentials to access the API.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 8199)]
        public string AuthenticationToken { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationToken property is set.
        /// </summary>
        internal bool IsSetAuthenticationToken() => this.AuthenticationToken != null;

        /// <summary>
        /// Gets and sets the property FolderId. 
        /// <para>
        /// The ID of the folder.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string FolderId { get; set; }

        /// <summary>
        /// Checks to see if the FolderId property is set.
        /// </summary>
        internal bool IsSetFolderId() => this.FolderId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the folder.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ParentFolderId. 
        /// <para>
        /// The ID of the parent folder.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ParentFolderId { get; set; }

        /// <summary>
        /// Checks to see if the ParentFolderId property is set.
        /// </summary>
        internal bool IsSetParentFolderId() => this.ParentFolderId != null;

        /// <summary>
        /// Gets and sets the property ResourceState. 
        /// <para>
        /// The resource state of the folder. Only ACTIVE and RECYCLED are accepted values from
        /// the API.
        /// </para>
        /// </summary>
        public ResourceStateType ResourceState { get; set; }

        /// <summary>
        /// Checks to see if the ResourceState property is set.
        /// </summary>
        internal bool IsSetResourceState() => this.ResourceState != null;
    }
}
