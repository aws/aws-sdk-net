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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
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
        private long? _bandwidthThrottling;
        private string _name;
        private string _recoveryInstanceID;
        private bool? _usePrivateIP;

        /// <summary>
        /// Gets and sets the property BandwidthThrottling. 
        /// <para>
        /// Configure bandwidth throttling for the outbound data transfer rate of the Recovery
        /// Instance in Mbps.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? BandwidthThrottling
        {
            get { return this._bandwidthThrottling; }
            set { this._bandwidthThrottling = value; }
        }

        // Check to see if BandwidthThrottling property is set
        internal bool IsSetBandwidthThrottling()
        {
            return this._bandwidthThrottling.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Failback Replication Configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
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
        /// Gets and sets the property RecoveryInstanceID. 
        /// <para>
        /// The ID of the Recovery Instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=19)]
        public string RecoveryInstanceID
        {
            get { return this._recoveryInstanceID; }
            set { this._recoveryInstanceID = value; }
        }

        // Check to see if RecoveryInstanceID property is set
        internal bool IsSetRecoveryInstanceID()
        {
            return this._recoveryInstanceID != null;
        }

        /// <summary>
        /// Gets and sets the property UsePrivateIP. 
        /// <para>
        /// Whether to use Private IP for the failback replication of the Recovery Instance.
        /// </para>
        /// </summary>
        public bool? UsePrivateIP
        {
            get { return this._usePrivateIP; }
            set { this._usePrivateIP = value; }
        }

        // Check to see if UsePrivateIP property is set
        internal bool IsSetUsePrivateIP()
        {
            return this._usePrivateIP.HasValue; 
        }

    }
}