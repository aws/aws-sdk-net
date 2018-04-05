/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the RemoveTagsFromResource operation.
    /// Removes all tags from the specified resource.
    /// </summary>
    public partial class RemoveTagsFromResourceRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _resourceId;
        private ResourceTypeForTagging _resourceType;
        private List<string> _tagKeys = new List<string>();

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The resource ID for which you want to remove tags. Use the ID of the resource. Here
        /// are some examples:
        /// </para>
        ///  
        /// <para>
        /// ManagedInstance: mi-012345abcde
        /// </para>
        ///  
        /// <para>
        /// MaintenanceWindow: mw-012345abcde
        /// </para>
        ///  
        /// <para>
        /// PatchBaseline: pb-012345abcde
        /// </para>
        ///  
        /// <para>
        /// For the Document and Parameter values, use the name of the resource.
        /// </para>
        ///  <note> 
        /// <para>
        /// The ManagedInstance type for this API action is only for on-premises managed instances.
        /// You must specify the the name of the managed instance in the following format: mi-ID_number.
        /// For example, mi-1a2b3c4d5e6f.
        /// </para>
        ///  </note>
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource of which you want to remove a tag.
        /// </para>
        ///  <note> 
        /// <para>
        /// The ManagedInstance type for this API action is only for on-premises managed instances.
        /// You must specify the the name of the managed instance in the following format: mi-ID_number.
        /// For example, mi-1a2b3c4d5e6f.
        /// </para>
        ///  </note>
        /// </summary>
        public ResourceTypeForTagging ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property TagKeys. 
        /// <para>
        /// Tag keys that you want to remove from the specified resource.
        /// </para>
        /// </summary>
        public List<string> TagKeys
        {
            get { return this._tagKeys; }
            set { this._tagKeys = value; }
        }

        // Check to see if TagKeys property is set
        internal bool IsSetTagKeys()
        {
            return this._tagKeys != null && this._tagKeys.Count > 0; 
        }

    }
}