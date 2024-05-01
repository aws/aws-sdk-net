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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
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
namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// An object representing a port mapping.
    /// </summary>
    public partial class PortMapping
    {
        private int? _applicationPort;
        private bool? _enableOnPublicIp;
        private int? _jobPort;

        /// <summary>
        /// Gets and sets the property ApplicationPort. 
        /// <para>
        /// The port number on the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1024, Max=65535)]
        public int? ApplicationPort
        {
            get { return this._applicationPort; }
            set { this._applicationPort = value; }
        }

        // Check to see if ApplicationPort property is set
        internal bool IsSetApplicationPort()
        {
            return this._applicationPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableOnPublicIp. 
        /// <para>
        /// A Boolean indicating whether to enable this port mapping on public IP.
        /// </para>
        /// </summary>
        public bool? EnableOnPublicIp
        {
            get { return this._enableOnPublicIp; }
            set { this._enableOnPublicIp = value; }
        }

        // Check to see if EnableOnPublicIp property is set
        internal bool IsSetEnableOnPublicIp()
        {
            return this._enableOnPublicIp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobPort. 
        /// <para>
        /// The port number on the simulation job instance to use as a remote connection point.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=65535)]
        public int? JobPort
        {
            get { return this._jobPort; }
            set { this._jobPort = value; }
        }

        // Check to see if JobPort property is set
        internal bool IsSetJobPort()
        {
            return this._jobPort.HasValue; 
        }

    }
}