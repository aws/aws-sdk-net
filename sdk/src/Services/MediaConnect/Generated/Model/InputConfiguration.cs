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
    /// The transport parameters that are associated with an incoming media stream.
    /// </summary>
    public partial class InputConfiguration
    {
        private string _inputIp;
        private int? _inputPort;
        private Interface _interface;

        /// <summary>
        /// Gets and sets the property InputIp. 
        /// <para>
        ///  The IP address that the flow listens on for incoming content for a media stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InputIp
        {
            get { return this._inputIp; }
            set { this._inputIp = value; }
        }

        // Check to see if InputIp property is set
        internal bool IsSetInputIp()
        {
            return this._inputIp != null;
        }

        /// <summary>
        /// Gets and sets the property InputPort. 
        /// <para>
        ///  The port that the flow listens on for an incoming media stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? InputPort
        {
            get { return this._inputPort; }
            set { this._inputPort = value; }
        }

        // Check to see if InputPort property is set
        internal bool IsSetInputPort()
        {
            return this._inputPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Interface. 
        /// <para>
        ///  The VPC interface where the media stream comes in from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Interface Interface
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