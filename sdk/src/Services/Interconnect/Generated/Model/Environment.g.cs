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
    /// Defines the logical topology that an AWS Interconnect Connection is created upon.
    /// 
    ///  
    /// <para>
    /// Specifically, an Environment defines the partner The remote Cloud Service Provider
    /// of this resource. or The remote Last Mile Provider of this resource. and the region
    /// or location specification to which an AWS Interconnect Connection can be made.
    /// </para>
    /// </summary>
    public partial class Environment
    {
        /// <summary>
        /// Gets and sets the property ActivationPageUrl. 
        /// <para>
        /// An HTTPS URL on the remote partner portal where the Activation Key should be brought
        /// to complete the creation process.
        /// </para>
        /// </summary>
        public string ActivationPageUrl { get; set; }

        /// <summary>
        /// Checks to see if the ActivationPageUrl property is set.
        /// </summary>
        internal bool IsSetActivationPageUrl() => this.ActivationPageUrl != null;

        /// <summary>
        /// Gets and sets the property Bandwidths. 
        /// <para>
        /// The sets of bandwidths that are available and supported on this environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Bandwidths Bandwidths { get; set; }

        /// <summary>
        /// Checks to see if the Bandwidths property is set.
        /// </summary>
        internal bool IsSetBandwidths() => this.Bandwidths != null;

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The identifier of this <a>Environment</a> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentId property is set.
        /// </summary>
        internal bool IsSetEnvironmentId() => this.EnvironmentId != null;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The provider specific location on the remote side of this <a>Connection</a>.
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
        /// The provider on the remote side of this <a>Connection</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Provider Provider { get; set; }

        /// <summary>
        /// Checks to see if the Provider property is set.
        /// </summary>
        internal bool IsSetProvider() => this.Provider != null;

        /// <summary>
        /// Gets and sets the property RemoteIdentifierType. 
        /// <para>
        /// The type of identifying information that should be supplied to the <c>remoteAccount</c>
        /// parameter of a <a>CreateConnection</a> call for this specific Environment.
        /// </para>
        /// </summary>
        public RemoteAccountIdentifierType RemoteIdentifierType { get; set; }

        /// <summary>
        /// Checks to see if the RemoteIdentifierType property is set.
        /// </summary>
        internal bool IsSetRemoteIdentifierType() => this.RemoteIdentifierType != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the <a>Environment</a>. Possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>available</c>: The environment is available and new <a>Connection</a> objects
        /// can be requested.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>limited</c>: The environment is available, but overall capacity is limited. The
        /// set of available bandwidths 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>unavailable</c>: The environment is currently unavailable.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public EnvironmentState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The specific product type of <a>Connection</a> objects provided by this <a>Environment</a>.
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
