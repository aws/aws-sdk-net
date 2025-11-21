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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteAssetType operation.
    /// Deletes an asset type in Amazon DataZone.
    /// 
    ///  
    /// <para>
    /// Prerequisites:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The asset type must exist in the domain. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You must have DeleteAssetType permission.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The asset type must not be in use (e.g., assigned to any asset). If used, deletion
    /// will fail.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You should retrieve the asset type using get-asset-type to confirm its presence before
    /// deletion.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DeleteAssetTypeRequest : AmazonDataZoneRequest
    {
        private string _domainIdentifier;
        private string _identifier;

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The ID of the Amazon DataZone domain in which the asset type is deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainIdentifier
        {
            get { return this._domainIdentifier; }
            set { this._domainIdentifier = value; }
        }

        // Check to see if DomainIdentifier property is set
        internal bool IsSetDomainIdentifier()
        {
            return this._domainIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The identifier of the asset type that is deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=513)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

    }
}