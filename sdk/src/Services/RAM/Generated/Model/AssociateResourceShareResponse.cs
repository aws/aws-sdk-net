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
 * Do not modify this file. This file is generated from the ram-2018-01-04.normal.json service model.
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
namespace Amazon.RAM.Model
{
    /// <summary>
    /// This is the response object from the AssociateResourceShare operation.
    /// </summary>
    public partial class AssociateResourceShareResponse : AmazonWebServiceResponse
    {
        private string _clientToken;
        private List<ResourceShareAssociation> _resourceShareAssociations = AWSConfigs.InitializeCollections ? new List<ResourceShareAssociation>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The idempotency identifier associated with this request. If you want to repeat the
        /// same operation in an idempotent manner then you must include this value in the <c>clientToken</c>
        /// request parameter of that later call. All other parameters must also have the same
        /// values that you used in the first call.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceShareAssociations. 
        /// <para>
        /// An array of objects that contain information about the associations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResourceShareAssociation> ResourceShareAssociations
        {
            get { return this._resourceShareAssociations; }
            set { this._resourceShareAssociations = value; }
        }

        // Check to see if ResourceShareAssociations property is set
        internal bool IsSetResourceShareAssociations()
        {
            return this._resourceShareAssociations != null && (this._resourceShareAssociations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}