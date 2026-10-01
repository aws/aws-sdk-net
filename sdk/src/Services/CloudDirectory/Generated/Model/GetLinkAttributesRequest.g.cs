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

namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// Container for the parameters to the GetLinkAttributes operation. Retrieves attributes
    /// that are associated with a typed link.
    /// </summary>
    public partial class GetLinkAttributesRequest : AmazonCloudDirectoryRequest
    {
        /// <summary>
        /// Gets and sets the property AttributeNames. 
        /// <para>
        /// A list of attribute names whose values will be retrieved.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> AttributeNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AttributeNames property is set.
        /// </summary>
        internal bool IsSetAttributeNames() => this.AttributeNames != null && (this.AttributeNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ConsistencyLevel. 
        /// <para>
        /// The consistency level at which to retrieve the attributes on a typed link.
        /// </para>
        /// </summary>
        public ConsistencyLevel ConsistencyLevel { get; set; }

        /// <summary>
        /// Checks to see if the ConsistencyLevel property is set.
        /// </summary>
        internal bool IsSetConsistencyLevel() => this.ConsistencyLevel != null;

        /// <summary>
        /// Gets and sets the property DirectoryArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that is associated with the Directory where the typed
        /// link resides. For more information, see <a>arns</a> or <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/directory_objects_links.html#directory_objects_links_typedlink">Typed
        /// Links</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DirectoryArn { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryArn property is set.
        /// </summary>
        internal bool IsSetDirectoryArn() => this.DirectoryArn != null;

        /// <summary>
        /// Gets and sets the property TypedLinkSpecifier. 
        /// <para>
        /// Allows a typed link specifier to be accepted as input.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TypedLinkSpecifier TypedLinkSpecifier { get; set; }

        /// <summary>
        /// Checks to see if the TypedLinkSpecifier property is set.
        /// </summary>
        internal bool IsSetTypedLinkSpecifier() => this.TypedLinkSpecifier != null;
    }
}
