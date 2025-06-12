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
    /// Container for the parameters to the RemoveTagsFromResource operation.
    /// Removes tag keys from the specified resource.
    /// </summary>
    public partial class RemoveTagsFromResourceRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _resourceId;
        private ResourceTypeForTagging _resourceType;
        private List<string> _tagKeys = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the resource from which you want to remove tags. For example:
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
        ///  <c>Automation</c>: <c>example-c160-4567-8519-012345abcde</c> 
        /// </para>
        ///  
        /// <para>
        /// PatchBaseline: pb-012345abcde
        /// </para>
        ///  
        /// <para>
        /// OpsMetadata object: <c>ResourceID</c> for tagging is created from the Amazon Resource
        /// Name (ARN) for the object. Specifically, <c>ResourceID</c> is created from the strings
        /// that come after the word <c>opsmetadata</c> in the ARN. For example, an OpsMetadata
        /// object with an ARN of <c>arn:aws:ssm:us-east-2:1234567890:opsmetadata/aws/ssm/MyGroup/appmanager</c>
        /// has a <c>ResourceID</c> of either <c>aws/ssm/MyGroup/appmanager</c> or <c>/aws/ssm/MyGroup/appmanager</c>.
        /// </para>
        ///  
        /// <para>
        /// For the Document and Parameter values, use the name of the resource.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>ManagedInstance</c> type for this API operation is only for on-premises managed
        /// nodes. Specify the name of the managed node in the following format: mi-ID_number.
        /// For example, mi-1a2b3c4d5e6f.
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
        /// The type of resource from which you want to remove a tag.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>ManagedInstance</c> type for this API operation is only for on-premises managed
        /// nodes. Specify the name of the managed node in the following format: <c>mi-<i>ID_number</i>
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
        /// Gets and sets the property TagKeys. 
        /// <para>
        /// Tag keys that you want to remove from the specified resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> TagKeys
        {
            get { return this._tagKeys; }
            set { this._tagKeys = value; }
        }

        // Check to see if TagKeys property is set
        internal bool IsSetTagKeys()
        {
            return this._tagKeys != null && (this._tagKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}