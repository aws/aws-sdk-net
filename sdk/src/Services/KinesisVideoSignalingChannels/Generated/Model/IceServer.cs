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
 * Do not modify this file. This file is generated from the kinesis-video-signaling-2019-12-04.normal.json service model.
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
namespace Amazon.KinesisVideoSignalingChannels.Model
{
    /// <summary>
    /// A structure for the ICE server connection data.
    /// </summary>
    public partial class IceServer
    {
        private string _password;
        private int? _ttl;
        private List<string> _uris = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _username;

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// A password to login to the ICE server.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }

        // Check to see if Password property is set
        internal bool IsSetPassword()
        {
            return this._password != null;
        }

        /// <summary>
        /// Gets and sets the property Ttl. 
        /// <para>
        /// The period of time, in seconds, during which the username and password are valid.
        /// </para>
        /// </summary>
        [AWSProperty(Min=30, Max=86400)]
        public int? Ttl
        {
            get { return this._ttl; }
            set { this._ttl = value; }
        }

        // Check to see if Ttl property is set
        internal bool IsSetTtl()
        {
            return this._ttl.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Uris. 
        /// <para>
        /// An array of URIs, in the form specified in the <a href="https://tools.ietf.org/html/draft-petithuguenin-behave-turn-uris-03">I-D.petithuguenin-behave-turn-uris</a>
        /// spec. These URIs provide the different addresses and/or protocols that can be used
        /// to reach the TURN server.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Uris
        {
            get { return this._uris; }
            set { this._uris = value; }
        }

        // Check to see if Uris property is set
        internal bool IsSetUris()
        {
            return this._uris != null && (this._uris.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// A username to login to the ICE server.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

    }
}