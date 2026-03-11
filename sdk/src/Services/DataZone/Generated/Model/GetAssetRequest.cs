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
    /// Container for the parameters to the GetAsset operation.
    /// Gets an Amazon DataZone asset.
    /// 
    ///  
    /// <para>
    /// An asset is the fundamental building block in Amazon DataZone, representing any data
    /// resource that needs to be cataloged and managed. It can take many forms, from Amazon
    /// S3 buckets and database tables to dashboards and machine learning models. Each asset
    /// contains comprehensive metadata about the resource, including its location, schema,
    /// ownership, and lineage information. Assets are essential for organizing and managing
    /// data resources across an organization, making them discoverable and usable while maintaining
    /// proper governance.
    /// </para>
    ///  
    /// <para>
    /// Before using the Amazon DataZone GetAsset command, ensure the following prerequisites
    /// are met:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Domain identifier must exist and be valid
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Asset identifier must exist
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// User must have the required permissions to perform the action
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetAssetRequest : AmazonDataZoneRequest
    {
        private string _domainIdentifier;
        private string _identifier;
        private string _revision;

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The ID of the Amazon DataZone domain to which the asset belongs.
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
        /// The ID of the Amazon DataZone asset.
        /// </para>
        ///  
        /// <para>
        /// This parameter supports either the value of <c>assetId</c> or <c>externalIdentifier</c>
        /// as input. If you are passing the value of <c>externalIdentifier</c>, you must prefix
        /// this value with <c>externalIdentifer%2F</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The revision of the Amazon DataZone asset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Revision
        {
            get { return this._revision; }
            set { this._revision = value; }
        }

        // Check to see if Revision property is set
        internal bool IsSetRevision()
        {
            return this._revision != null;
        }

    }
}