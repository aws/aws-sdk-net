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
    /// This is the response object from the GetTypedLinkFacetInformation operation.
    /// </summary>
    public partial class GetTypedLinkFacetInformationResponse : AmazonWebServiceResponse
    {
        private List<string> _identityAttributeOrder = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property IdentityAttributeOrder. 
        /// <para>
        /// The order of identity attributes for the facet, from most significant to least significant.
        /// The ability to filter typed links considers the order that the attributes are defined
        /// on the typed link facet. When providing ranges to typed link selection, any inexact
        /// ranges must be specified at the end. Any attributes that do not have a range specified
        /// are presumed to match the entire range. Filters are interpreted in the order of the
        /// attributes on the typed link facet, not the order in which they are supplied to any
        /// API calls. For more information about identity attributes, see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/directory_objects_links.html#directory_objects_links_typedlink">Typed
        /// Links</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> IdentityAttributeOrder
        {
            get { return this._identityAttributeOrder; }
            set { this._identityAttributeOrder = value; }
        }

        // Check to see if IdentityAttributeOrder property is set
        internal bool IsSetIdentityAttributeOrder()
        {
            return this._identityAttributeOrder != null && (this._identityAttributeOrder.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}