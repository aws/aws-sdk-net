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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Container for the parameters to the CreateInterconnect operation.
    /// Creates an interconnect between an AWS Direct Connect Partner's network and a specific
    /// AWS Direct Connect location.
    /// 
    ///  
    /// <para>
    /// An interconnect is a connection that is capable of hosting other connections. The
    /// AWS Direct Connect partner can use an interconnect to provide AWS Direct Connect hosted
    /// connections to customers through their own network services. Like a standard connection,
    /// an interconnect links the partner's network to an AWS Direct Connect location over
    /// a standard Ethernet fiber-optic cable. One end is connected to the partner's router,
    /// the other to an AWS Direct Connect router.
    /// </para>
    ///  
    /// <para>
    /// You can automatically add the new interconnect to a link aggregation group (LAG) by
    /// specifying a LAG ID in the request. This ensures that the new interconnect is allocated
    /// on the same AWS Direct Connect endpoint that hosts the specified LAG. If there are
    /// no available ports on the endpoint, the request fails and no interconnect is created.
    /// </para>
    ///  
    /// <para>
    /// For each end customer, the AWS Direct Connect Partner provisions a connection on their
    /// interconnect by calling <a>AllocateHostedConnection</a>. The end customer can then
    /// connect to AWS resources by creating a virtual interface on their connection, using
    /// the VLAN assigned to them by the AWS Direct Connect Partner.
    /// </para>
    ///  <note> 
    /// <para>
    /// Intended for use by AWS Direct Connect Partners only.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateInterconnectRequest : AmazonDirectConnectRequest
    {
        private string _bandwidth;
        private string _interconnectName;
        private string _lagId;
        private string _location;
        private string _providerName;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property Bandwidth. 
        /// <para>
        /// The port bandwidth, in Gbps. The possible values are 1 and 10.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Bandwidth
        {
            get { return this._bandwidth; }
            set { this._bandwidth = value; }
        }

        // Check to see if Bandwidth property is set
        internal bool IsSetBandwidth()
        {
            return this._bandwidth != null;
        }

        /// <summary>
        /// Gets and sets the property InterconnectName. 
        /// <para>
        /// The name of the interconnect.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InterconnectName
        {
            get { return this._interconnectName; }
            set { this._interconnectName = value; }
        }

        // Check to see if InterconnectName property is set
        internal bool IsSetInterconnectName()
        {
            return this._interconnectName != null;
        }

        /// <summary>
        /// Gets and sets the property LagId. 
        /// <para>
        /// The ID of the LAG.
        /// </para>
        /// </summary>
        public string LagId
        {
            get { return this._lagId; }
            set { this._lagId = value; }
        }

        // Check to see if LagId property is set
        internal bool IsSetLagId()
        {
            return this._lagId != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The location of the interconnect.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property ProviderName. 
        /// <para>
        /// The name of the service provider associated with the interconnect.
        /// </para>
        /// </summary>
        public string ProviderName
        {
            get { return this._providerName; }
            set { this._providerName = value; }
        }

        // Check to see if ProviderName property is set
        internal bool IsSetProviderName()
        {
            return this._providerName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to associate with the interconnect.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}