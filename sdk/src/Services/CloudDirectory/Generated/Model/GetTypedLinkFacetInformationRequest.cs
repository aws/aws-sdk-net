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
    /// Container for the parameters to the GetTypedLinkFacetInformation operation.
    /// Returns the identity attribute order for a specific <a>TypedLinkFacet</a>. For more
    /// information, see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/directory_objects_links.html#directory_objects_links_typedlink">Typed
    /// Links</a>.
    /// </summary>
    public partial class GetTypedLinkFacetInformationRequest : AmazonCloudDirectoryRequest
    {
        private string _name;
        private string _schemaArn;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The unique name of the typed link facet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that is associated with the schema. For more information,
        /// see <a>arns</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SchemaArn
        {
            get { return this._schemaArn; }
            set { this._schemaArn = value; }
        }

        // Check to see if SchemaArn property is set
        internal bool IsSetSchemaArn()
        {
            return this._schemaArn != null;
        }

    }
}