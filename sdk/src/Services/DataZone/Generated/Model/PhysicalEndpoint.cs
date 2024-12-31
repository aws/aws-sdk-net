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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The physical endpoints of a connection.
    /// </summary>
    public partial class PhysicalEndpoint
    {
        private AwsLocation _awsLocation;
        private GlueConnection _glueConnection;
        private string _glueConnectionName;
        private string _host;
        private int? _port;
        private Protocol _protocol;
        private string _stage;

        /// <summary>
        /// Gets and sets the property AwsLocation. 
        /// <para>
        /// The location of a connection.
        /// </para>
        /// </summary>
        public AwsLocation AwsLocation
        {
            get { return this._awsLocation; }
            set { this._awsLocation = value; }
        }

        // Check to see if AwsLocation property is set
        internal bool IsSetAwsLocation()
        {
            return this._awsLocation != null;
        }

        /// <summary>
        /// Gets and sets the property GlueConnection. 
        /// <para>
        /// The Amazon Web Services Glue connection.
        /// </para>
        /// </summary>
        public GlueConnection GlueConnection
        {
            get { return this._glueConnection; }
            set { this._glueConnection = value; }
        }

        // Check to see if GlueConnection property is set
        internal bool IsSetGlueConnection()
        {
            return this._glueConnection != null;
        }

        /// <summary>
        /// Gets and sets the property GlueConnectionName. 
        /// <para>
        /// The Amazon Web Services Glue connection name.
        /// </para>
        /// </summary>
        public string GlueConnectionName
        {
            get { return this._glueConnectionName; }
            set { this._glueConnectionName = value; }
        }

        // Check to see if GlueConnectionName property is set
        internal bool IsSetGlueConnectionName()
        {
            return this._glueConnectionName != null;
        }

        /// <summary>
        /// Gets and sets the property Host. 
        /// <para>
        /// The host in the physical endpoints of a connection.
        /// </para>
        /// </summary>
        public string Host
        {
            get { return this._host; }
            set { this._host = value; }
        }

        // Check to see if Host property is set
        internal bool IsSetHost()
        {
            return this._host != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port in the physical endpoints of a connection.
        /// </para>
        /// </summary>
        public int? Port
        {
            get { return this._port; }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol in the physical endpoints of a connection.
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

        /// <summary>
        /// Gets and sets the property Stage. 
        /// <para>
        /// The stage in the physical endpoints of a connection.
        /// </para>
        /// </summary>
        public string Stage
        {
            get { return this._stage; }
            set { this._stage = value; }
        }

        // Check to see if Stage property is set
        internal bool IsSetStage()
        {
            return this._stage != null;
        }

    }
}