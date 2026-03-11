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
    /// Container for the parameters to the GetAssetType operation.
    /// Gets an Amazon DataZone asset type.
    /// 
    ///  
    /// <para>
    /// Asset types define the categories and characteristics of different kinds of data assets
    /// within Amazon DataZone.. They determine what metadata fields are required, what operations
    /// are possible, and how the asset integrates with other Amazon Web Services services.
    /// Asset types can range from built-in types like Amazon S3 buckets and Amazon Web Services
    /// Glue tables to custom types defined for specific organizational needs. Understanding
    /// asset types is crucial for properly organizing and managing different kinds of data
    /// resources.
    /// </para>
    ///  
    /// <para>
    /// Prerequisites:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The asset type with identifier must exist in the domain. ResourceNotFoundException.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You must have the GetAssetType permission.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Ensure the domain-identifier value is correct and accessible.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetAssetTypeRequest : AmazonDataZoneRequest
    {
        private string _domainIdentifier;
        private string _identifier;
        private string _revision;

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The ID of the Amazon DataZone domain in which the asset type exists.
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
        /// The ID of the asset type.
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

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The revision of the asset type.
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