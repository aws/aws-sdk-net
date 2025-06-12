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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the AddTagsToResource operation.
    /// Adds or overwrites one or more tags for the specified resource. <i>Tags</i> are metadata
    /// that you can assign to your automations, documents, managed nodes, maintenance windows,
    /// Parameter Store parameters, and patch baselines. Tags enable you to categorize your
    /// resources in different ways, for example, by purpose, owner, or environment. Each
    /// tag consists of a key and an optional value, both of which you define. For example,
    /// you could define a set of tags for your account's managed nodes that helps you track
    /// each node's owner and stack level. For example:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>Key=Owner,Value=DbAdmin</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Key=Owner,Value=SysAdmin</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Key=Owner,Value=Dev</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Key=Stack,Value=Production</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Key=Stack,Value=Pre-Production</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Key=Stack,Value=Test</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Most resources can have a maximum of 50 tags. Automations can have a maximum of 5
    /// tags.
    /// </para>
    ///  
    /// <para>
    /// We recommend that you devise a set of tag keys that meets your needs for each resource
    /// type. Using a consistent set of tag keys makes it easier for you to manage your resources.
    /// You can search and filter the resources based on the tags you add. Tags don't have
    /// any semantic meaning to and are interpreted strictly as a string of characters.
    /// </para>
    ///  
    /// <para>
    /// For more information about using tags with Amazon Elastic Compute Cloud (Amazon EC2)
    /// instances, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tag
    /// your Amazon EC2 resources</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AddTagsToResourceRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _resourceId;
        private ResourceTypeForTagging _resourceType;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

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
        ///  <c>MaintenanceWindow</c>: <c>mw-012345abcde</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>PatchBaseline</c>: <c>pb-012345abcde</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>Automation</c>: <c>example-c160-4567-8519-012345abcde</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>OpsMetadata</c> object: <c>ResourceID</c> for tagging is created from the Amazon
        /// Resource Name (ARN) for the object. Specifically, <c>ResourceID</c> is created from
        /// the strings that come after the word <c>opsmetadata</c> in the ARN. For example, an
        /// OpsMetadata object with an ARN of <c>arn:aws:ssm:us-east-2:1234567890:opsmetadata/aws/ssm/MyGroup/appmanager</c>
        /// has a <c>ResourceID</c> of either <c>aws/ssm/MyGroup/appmanager</c> or <c>/aws/ssm/MyGroup/appmanager</c>.
        /// </para>
        ///  
        /// <para>
        /// For the <c>Document</c> and <c>Parameter</c> values, use the name of the resource.
        /// If you're tagging a shared document, you must use the full ARN of the document.
        /// </para>
        ///  
        /// <para>
        ///  <c>ManagedInstance</c>: <c>mi-012345abcde</c> 
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>ManagedInstance</c> type for this API operation is only for on-premises managed
        /// nodes. You must specify the name of the managed node in the following format: <c>mi-<i>ID_number</i>
        /// </c>. For example, <c>mi-1a2b3c4d5e6f</c>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The <c>ManagedInstance</c> type for this API operation is for on-premises managed
        /// nodes. You must specify the name of the managed node in the following format: <c>mi-<i>ID_number</i>
        /// </c>. For example, <c>mi-1a2b3c4d5e6f</c>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// One or more tags. The value parameter is required.
        /// </para>
        ///  <important> 
        /// <para>
        /// Don't enter personally identifiable information in this field.
        /// </para>
        ///  </important>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Max=1000)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}