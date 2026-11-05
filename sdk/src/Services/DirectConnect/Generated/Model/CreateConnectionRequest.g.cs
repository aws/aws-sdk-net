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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Container for the parameters to the CreateConnection operation. Creates a connection
    /// between a customer network and a specific Direct Connect location. <para> A connection
    /// links your internal network to an Direct Connect location over a standard Ethernet
    /// fiber-optic cable. One end of the cable is connected to your router, the other to
    /// an Direct Connect router. </para> <para> To find the locations for your Region, use
    /// <a>DescribeLocations</a>. </para> <para> You can automatically add the new connection
    /// to a link aggregation group (LAG) by specifying a LAG ID in the request. This ensures
    /// that the new connection is allocated on the same Direct Connect endpoint that hosts
    /// the specified LAG. If there are no available ports on the endpoint, the request fails
    /// and no connection is created. </para>
    /// </summary>
    public partial class CreateConnectionRequest : AmazonDirectConnectRequest
    {
        /// <summary>
        /// Gets and sets the property Bandwidth. 
        /// <para>
        /// The bandwidth of the connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Bandwidth { get; set; }

        /// <summary>
        /// Checks to see if the Bandwidth property is set.
        /// </summary>
        internal bool IsSetBandwidth() => this.Bandwidth != null;

        /// <summary>
        /// Gets and sets the property BillingMode. 
        /// <para>
        /// The billing mode for the connection.
        /// </para>
        /// </summary>
        public RequestBillingMode BillingMode { get; set; }

        /// <summary>
        /// Checks to see if the BillingMode property is set.
        /// </summary>
        internal bool IsSetBillingMode() => this.BillingMode != null;

        /// <summary>
        /// Gets and sets the property ConnectionName. 
        /// <para>
        /// The name of the connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ConnectionName { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionName property is set.
        /// </summary>
        internal bool IsSetConnectionName() => this.ConnectionName != null;

        /// <summary>
        /// Gets and sets the property LagId. 
        /// <para>
        /// The ID of the LAG.
        /// </para>
        /// </summary>
        public string LagId { get; set; }

        /// <summary>
        /// Checks to see if the LagId property is set.
        /// </summary>
        internal bool IsSetLagId() => this.LagId != null;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The location of the connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property ProviderName. 
        /// <para>
        /// The name of the service provider associated with the requested connection.
        /// </para>
        /// </summary>
        public string ProviderName { get; set; }

        /// <summary>
        /// Checks to see if the ProviderName property is set.
        /// </summary>
        internal bool IsSetProviderName() => this.ProviderName != null;

        /// <summary>
        /// Gets and sets the property RequestMACSec. 
        /// <para>
        /// Indicates whether you want the connection to support MAC Security (MACsec).
        /// </para>
        ///  
        /// <para>
        /// MAC Security (MACsec) is unavailable on hosted connections. For information about
        /// MAC Security (MACsec) prerequisites, see <a href="https://docs.aws.amazon.com/directconnect/latest/UserGuide/MACSec.html">MAC
        /// Security in Direct Connect</a> in the <i>Direct Connect User Guide</i>.
        /// </para>
        /// </summary>
        public bool? RequestMACSec { get; set; }

        /// <summary>
        /// Checks to see if the RequestMACSec property is set.
        /// </summary>
        internal bool IsSetRequestMACSec() => this.RequestMACSec.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to associate with the lag.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
