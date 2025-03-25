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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// The definition of a media stream that you want to associate with the output.
    /// </summary>
    public partial class DestinationConfigurationRequest
    {
        private string _destinationIp;
        private int? _destinationPort;
        private InterfaceRequest _interface;

        /// <summary>
        /// Gets and sets the property DestinationIp. 
        /// <para>
        /// The IP address where you want MediaConnect to send contents of the media stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DestinationIp
        {
            get { return this._destinationIp; }
            set { this._destinationIp = value; }
        }

        // Check to see if DestinationIp property is set
        internal bool IsSetDestinationIp()
        {
            return this._destinationIp != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationPort. 
        /// <para>
        ///  The port that you want MediaConnect to use when it distributes the media stream to
        /// the output.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? DestinationPort
        {
            get { return this._destinationPort; }
            set { this._destinationPort = value; }
        }

        // Check to see if DestinationPort property is set
        internal bool IsSetDestinationPort()
        {
            return this._destinationPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Interface. 
        /// <para>
        ///  The VPC interface that you want to use for the media stream associated with the output.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InterfaceRequest Interface
        {
            get { return this._interface; }
            set { this._interface = value; }
        }

        // Check to see if Interface property is set
        internal bool IsSetInterface()
        {
            return this._interface != null;
        }

    }
}