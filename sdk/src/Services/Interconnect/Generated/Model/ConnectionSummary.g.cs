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

namespace Amazon.Interconnect.Model
{
    /// <summary>
    /// Summarized view of a Connection object.
    /// </summary>
    public partial class ConnectionSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the <a>Connection</a> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 59, Max = 150)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AttachPoint. 
        /// <para>
        /// The Attach Point to which the connection should be associated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AttachPoint AttachPoint { get; set; }

        /// <summary>
        /// Checks to see if the AttachPoint property is set.
        /// </summary>
        internal bool IsSetAttachPoint() => this.AttachPoint != null;

        /// <summary>
        /// Gets and sets the property Bandwidth. 
        /// <para>
        /// The bandwidth of the <a>Connection</a> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 8)]
        public string Bandwidth { get; set; }

        /// <summary>
        /// Checks to see if the Bandwidth property is set.
        /// </summary>
        internal bool IsSetBandwidth() => this.Bandwidth != null;

        /// <summary>
        /// Gets and sets the property BillingTier. 
        /// <para>
        /// The billing tier this connection is currently assigned.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8)]
        public int? BillingTier { get; set; }

        /// <summary>
        /// Checks to see if the BillingTier property is set.
        /// </summary>
        internal bool IsSetBillingTier() => this.BillingTier.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A descriptive name of the <a>Connection</a> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The <a>Environment</a> that this <a>Connection</a> is created on.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentId property is set.
        /// </summary>
        internal bool IsSetEnvironmentId() => this.EnvironmentId != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the requested <a>Connection</a> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The provider specific location at the remote end of this <a>Connection</a> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 255)]
        public string Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// The provider on the remote end of this <a>Connection</a> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Provider Provider { get; set; }

        /// <summary>
        /// Checks to see if the Provider property is set.
        /// </summary>
        internal bool IsSetProvider() => this.Provider != null;

        /// <summary>
        /// Gets and sets the property SharedId. 
        /// <para>
        /// An identifier used by both AWS and the remote partner to identify the specific connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string SharedId { get; set; }

        /// <summary>
        /// Checks to see if the SharedId property is set.
        /// </summary>
        internal bool IsSetSharedId() => this.SharedId != null;

        /// <summary>
        /// Gets and sets the property State. <ul> <li> 
        /// <para>
        ///  <c>requested</c>: The initial state of a connection. The state will remain here until
        /// the Connection is accepted on the Partner portal.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>pending</c>: The connection has been accepted and is being provisioned between
        /// AWS and the Partner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>available</c>: The connection has been fully provisioned between AWS and the Partner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deleting</c>: The connection is being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deleted</c>: The connection has been deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>failed</c>: The connection has failed to be created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>updating</c>: The connection is being updated.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public ConnectionState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The product variant supplied by this resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 32)]
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
