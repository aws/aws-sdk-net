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

namespace Amazon.Drs.Model
{
    /// <summary>
    /// This is the response object from the GetFailbackReplicationConfiguration operation.
    /// </summary>
    public partial class GetFailbackReplicationConfigurationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BandwidthThrottling. 
        /// <para>
        /// Configure bandwidth throttling for the outbound data transfer rate of the Recovery
        /// Instance in Mbps.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? BandwidthThrottling { get; set; }

        /// <summary>
        /// Checks to see if the BandwidthThrottling property is set.
        /// </summary>
        internal bool IsSetBandwidthThrottling() => this.BandwidthThrottling.HasValue;

        /// <summary>
        /// Gets and sets the property InternetProtocol. 
        /// <para>
        /// Which version of the Internet Protocol to use for replication of data. (IPv4 or IPv6)
        /// </para>
        /// </summary>
        public InternetProtocol InternetProtocol { get; set; }

        /// <summary>
        /// Checks to see if the InternetProtocol property is set.
        /// </summary>
        internal bool IsSetInternetProtocol() => this.InternetProtocol != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Failback Replication Configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RecoveryInstanceID. 
        /// <para>
        /// The ID of the Recovery Instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 19)]
        public string RecoveryInstanceID { get; set; }

        /// <summary>
        /// Checks to see if the RecoveryInstanceID property is set.
        /// </summary>
        internal bool IsSetRecoveryInstanceID() => this.RecoveryInstanceID != null;

        /// <summary>
        /// Gets and sets the property UsePrivateIP. 
        /// <para>
        /// Whether to use Private IP for the failback replication of the Recovery Instance.
        /// </para>
        /// </summary>
        public bool? UsePrivateIP { get; set; }

        /// <summary>
        /// Checks to see if the UsePrivateIP property is set.
        /// </summary>
        internal bool IsSetUsePrivateIP() => this.UsePrivateIP.HasValue;
    }
}
