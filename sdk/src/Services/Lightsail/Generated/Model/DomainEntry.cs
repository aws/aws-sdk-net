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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes a domain recordset entry.
    /// </summary>
    public partial class DomainEntry
    {
        private string _id;
        private bool? _isAlias;
        private string _name;
        private Dictionary<string, string> _options = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _target;
        private string _type;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the domain recordset entry.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property IsAlias. 
        /// <para>
        /// When <c>true</c>, specifies whether the domain entry is an alias used by the Lightsail
        /// load balancer, Lightsail container service, Lightsail content delivery network (CDN)
        /// distribution, or another Amazon Web Services resource. You can include an alias (A
        /// type) record in your request, which points to the DNS name of a load balancer, container
        /// service, CDN distribution, or other Amazon Web Services resource and routes traffic
        /// to that resource.
        /// </para>
        /// </summary>
        public bool? IsAlias
        {
            get { return this._isAlias; }
            set { this._isAlias = value; }
        }

        // Check to see if IsAlias property is set
        internal bool IsSetIsAlias()
        {
            return this._isAlias.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the domain.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Options. 
        /// <para>
        /// (Discontinued) The options for the domain entry.
        /// </para>
        ///  <note> 
        /// <para>
        /// In releases prior to November 29, 2017, this parameter was not included in the API
        /// response. It is now discontinued.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("In releases prior to November 29, 2017, this parameter was not included in the API response. It is now deprecated.")]
        public Dictionary<string, string> Options
        {
            get { return this._options; }
            set { this._options = value; }
        }

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this._options != null && (this._options.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The target IP address (<c>192.0.2.0</c>), or AWS name server (<c>ns-111.awsdns-22.com.</c>).
        /// </para>
        ///  
        /// <para>
        /// For Lightsail load balancers, the value looks like <c>ab1234c56789c6b86aba6fb203d443bc-123456789.us-east-2.elb.amazonaws.com</c>.
        /// For Lightsail distributions, the value looks like <c>exampled1182ne.cloudfront.net</c>.
        /// For Lightsail container services, the value looks like <c>container-service-1.example23scljs.us-west-2.cs.amazonlightsail.com</c>.
        /// Be sure to also set <c>isAlias</c> to <c>true</c> when setting up an A record for
        /// a Lightsail load balancer, distribution, or container service.
        /// </para>
        /// </summary>
        public string Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of domain entry, such as address for IPv4 (A), address for IPv6 (AAAA), canonical
        /// name (CNAME), mail exchanger (MX), name server (NS), start of authority (SOA), service
        /// locator (SRV), or text (TXT).
        /// </para>
        ///  
        /// <para>
        /// The following domain entry types can be used:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>A</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AAAA</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CNAME</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MX</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NS</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SOA</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SRV</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TXT</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}