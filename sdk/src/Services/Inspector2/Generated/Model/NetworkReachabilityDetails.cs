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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Contains the details of a network reachability finding.
    /// </summary>
    public partial class NetworkReachabilityDetails
    {
        private NetworkPath _networkPath;
        private PortRange _openPortRange;
        private NetworkProtocol _protocol;

        /// <summary>
        /// Gets and sets the property NetworkPath. 
        /// <para>
        /// An object that contains details about a network path associated with a finding.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NetworkPath NetworkPath
        {
            get { return this._networkPath; }
            set { this._networkPath = value; }
        }

        // Check to see if NetworkPath property is set
        internal bool IsSetNetworkPath()
        {
            return this._networkPath != null;
        }

        /// <summary>
        /// Gets and sets the property OpenPortRange. 
        /// <para>
        /// An object that contains details about the open port range associated with a finding.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PortRange OpenPortRange
        {
            get { return this._openPortRange; }
            set { this._openPortRange = value; }
        }

        // Check to see if OpenPortRange property is set
        internal bool IsSetOpenPortRange()
        {
            return this._openPortRange != null;
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol associated with a finding.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NetworkProtocol Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

    }
}