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
 * Do not modify this file. This file is generated from the clouddirectory-2017-01-11.normal.json service model.
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
namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateLinkAttributes operation.
    /// Updates a given typed link’s attributes. Attributes to be updated must not contribute
    /// to the typed link’s identity, as defined by its <c>IdentityAttributeOrder</c>.
    /// </summary>
    public partial class UpdateLinkAttributesRequest : AmazonCloudDirectoryRequest
    {
        private List<LinkAttributeUpdate> _attributeUpdates = AWSConfigs.InitializeCollections ? new List<LinkAttributeUpdate>() : null;
        private string _directoryArn;
        private TypedLinkSpecifier _typedLinkSpecifier;

        /// <summary>
        /// Gets and sets the property AttributeUpdates. 
        /// <para>
        /// The attributes update structure.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<LinkAttributeUpdate> AttributeUpdates
        {
            get { return this._attributeUpdates; }
            set { this._attributeUpdates = value; }
        }

        // Check to see if AttributeUpdates property is set
        internal bool IsSetAttributeUpdates()
        {
            return this._attributeUpdates != null && (this._attributeUpdates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DirectoryArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that is associated with the Directory where the updated
        /// typed link resides. For more information, see <a>arns</a> or <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/directory_objects_links.html#directory_objects_links_typedlink">Typed
        /// Links</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DirectoryArn
        {
            get { return this._directoryArn; }
            set { this._directoryArn = value; }
        }

        // Check to see if DirectoryArn property is set
        internal bool IsSetDirectoryArn()
        {
            return this._directoryArn != null;
        }

        /// <summary>
        /// Gets and sets the property TypedLinkSpecifier. 
        /// <para>
        /// Allows a typed link specifier to be accepted as input.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TypedLinkSpecifier TypedLinkSpecifier
        {
            get { return this._typedLinkSpecifier; }
            set { this._typedLinkSpecifier = value; }
        }

        // Check to see if TypedLinkSpecifier property is set
        internal bool IsSetTypedLinkSpecifier()
        {
            return this._typedLinkSpecifier != null;
        }

    }
}