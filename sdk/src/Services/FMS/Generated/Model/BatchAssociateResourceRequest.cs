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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
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
namespace Amazon.FMS.Model
{
    /// <summary>
    /// Container for the parameters to the BatchAssociateResource operation.
    /// Associate resources to a Firewall Manager resource set.
    /// </summary>
    public partial class BatchAssociateResourceRequest : AmazonFMSRequest
    {
        private List<string> _items = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _resourceSetIdentifier;

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// The uniform resource identifiers (URIs) of resources that should be associated to
        /// the resource set. The URIs must be Amazon Resource Names (ARNs).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Items
        {
            get { return this._items; }
            set { this._items = value; }
        }

        // Check to see if Items property is set
        internal bool IsSetItems()
        {
            return this._items != null && (this._items.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceSetIdentifier. 
        /// <para>
        /// A unique identifier for the resource set, used in a request to refer to the resource
        /// set.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ResourceSetIdentifier
        {
            get { return this._resourceSetIdentifier; }
            set { this._resourceSetIdentifier = value; }
        }

        // Check to see if ResourceSetIdentifier property is set
        internal bool IsSetResourceSetIdentifier()
        {
            return this._resourceSetIdentifier != null;
        }

    }
}