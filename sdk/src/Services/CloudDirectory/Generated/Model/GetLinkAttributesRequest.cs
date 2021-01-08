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

namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// Container for the parameters to the GetLinkAttributes operation.
    /// Retrieves attributes that are associated with a typed link.
    /// </summary>
    public partial class GetLinkAttributesRequest : AmazonCloudDirectoryRequest
    {
        private List<string> _attributeNames = new List<string>();
        private ConsistencyLevel _consistencyLevel;
        private string _directoryArn;
        private TypedLinkSpecifier _typedLinkSpecifier;

        /// <summary>
        /// Gets and sets the property AttributeNames. 
        /// <para>
        /// A list of attribute names whose values will be retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> AttributeNames
        {
            get { return this._attributeNames; }
            set { this._attributeNames = value; }
        }

        // Check to see if AttributeNames property is set
        internal bool IsSetAttributeNames()
        {
            return this._attributeNames != null && this._attributeNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ConsistencyLevel. 
        /// <para>
        /// The consistency level at which to retrieve the attributes on a typed link.
        /// </para>
        /// </summary>
        public ConsistencyLevel ConsistencyLevel
        {
            get { return this._consistencyLevel; }
            set { this._consistencyLevel = value; }
        }

        // Check to see if ConsistencyLevel property is set
        internal bool IsSetConsistencyLevel()
        {
            return this._consistencyLevel != null;
        }

        /// <summary>
        /// Gets and sets the property DirectoryArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that is associated with the Directory where the typed
        /// link resides. For more information, see <a>arns</a> or <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/directory_objects_links.html#directory_objects_links_typedlink">Typed
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