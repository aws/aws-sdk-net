/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the globalaccelerator-2018-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GlobalAccelerator.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateListener operation.
    /// Update a listener.
    /// </summary>
    public partial class UpdateListenerRequest : AmazonGlobalAcceleratorRequest
    {
        private ClientAffinity _clientAffinity;
        private string _listenerArn;
        private List<PortRange> _portRanges = new List<PortRange>();
        private Protocol _protocol;

        /// <summary>
        /// Gets and sets the property ClientAffinity. 
        /// <para>
        /// Client affinity lets you direct all requests from a user to the same endpoint, if
        /// you have stateful applications, regardless of the source port and protocol of the
        /// user request. This gives you control over whether and how to maintain client affinity
        /// to a given endpoint.
        /// </para>
        ///  
        /// <para>
        /// The default value is <code>NONE</code>.
        /// </para>
        /// </summary>
        public ClientAffinity ClientAffinity
        {
            get { return this._clientAffinity; }
            set { this._clientAffinity = value; }
        }

        // Check to see if ClientAffinity property is set
        internal bool IsSetClientAffinity()
        {
            return this._clientAffinity != null;
        }

        /// <summary>
        /// Gets and sets the property ListenerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the listener to update.
        /// </para>
        /// </summary>
        public string ListenerArn
        {
            get { return this._listenerArn; }
            set { this._listenerArn = value; }
        }

        // Check to see if ListenerArn property is set
        internal bool IsSetListenerArn()
        {
            return this._listenerArn != null;
        }

        /// <summary>
        /// Gets and sets the property PortRanges. 
        /// <para>
        /// The updated list of port ranges for the connections from clients to the accelerator.
        /// </para>
        /// </summary>
        public List<PortRange> PortRanges
        {
            get { return this._portRanges; }
            set { this._portRanges = value; }
        }

        // Check to see if PortRanges property is set
        internal bool IsSetPortRanges()
        {
            return this._portRanges != null && this._portRanges.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The updated protocol for the connections from clients to the accelerator.
        /// </para>
        /// </summary>
        public Protocol Protocol
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