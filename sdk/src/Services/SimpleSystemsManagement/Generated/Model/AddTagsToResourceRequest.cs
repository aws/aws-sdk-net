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
    /// Container for the parameters to the AddTagsToResource operation.
    /// Adds or overwrites one or more tags for the specified resource. Tags are metadata
    /// that you can assign to your documents, managed instances, Maintenance Windows, Parameter
    /// Store parameters, and patch baselines. Tags enable you to categorize your resources
    /// in different ways, for example, by purpose, owner, or environment. Each tag consists
    /// of a key and an optional value, both of which you define. For example, you could define
    /// a set of tags for your account's managed instances that helps you track each instance's
    /// owner and stack level. For example: Key=Owner and Value=DbAdmin, SysAdmin, or Dev.
    /// Or Key=Stack and Value=Production, Pre-Production, or Test.
    /// 
    ///  
    /// <para>
    /// Each resource can have a maximum of 50 tags. 
    /// </para>
    ///  
    /// <para>
    /// We recommend that you devise a set of tag keys that meets your needs for each resource
    /// type. Using a consistent set of tag keys makes it easier for you to manage your resources.
    /// You can search and filter the resources based on the tags you add. Tags don't have
    /// any semantic meaning to Amazon EC2 and are interpreted strictly as a string of characters.
    /// 
    /// </para>
    ///  
    /// <para>
    /// For more information about tags, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging
    /// Your Amazon EC2 Resources</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AddTagsToResourceRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _resourceId;
        private ResourceTypeForTagging _resourceType;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The resource ID you want to tag.
        /// </para>
        ///  
        /// <para>
        /// Use the ID of the resource. Here are some examples:
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
        /// Specifies the type of resource you are tagging.
        /// </para>
        ///  <note> 
        /// <para>
        /// The ManagedInstance type for this API action is for on-premises managed instances.
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
        /// Gets and sets the property Tags. 
        /// <para>
        ///  One or more tags. The value parameter is required, but if you don't want the tag
        /// to have a value, specify the parameter with no value, and we set the value to an empty
        /// string. 
        /// </para>
        ///  <important> 
        /// <para>
        /// Do not enter personally identifiable information in this field.
        /// </para>
        ///  </important>
        /// </summary>
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