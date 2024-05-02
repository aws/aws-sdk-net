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
 * Do not modify this file. This file is generated from the connectparticipant-2018-09-07.normal.json service model.
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
namespace Amazon.ConnectParticipant.Model
{
    /// <summary>
    /// The websocket for the participant's connection.
    /// </summary>
    public partial class Websocket
    {
        private string _connectionExpiry;
        private string _url;

        /// <summary>
        /// Gets and sets the property ConnectionExpiry. 
        /// <para>
        /// The URL expiration timestamp in ISO date format.
        /// </para>
        ///  
        /// <para>
        /// It's specified in ISO 8601 format: yyyy-MM-ddThh:mm:ss.SSSZ. For example, 2019-11-08T02:41:28.172Z.
        /// </para>
        /// </summary>
        public string ConnectionExpiry
        {
            get { return this._connectionExpiry; }
            set { this._connectionExpiry = value; }
        }

        // Check to see if ConnectionExpiry property is set
        internal bool IsSetConnectionExpiry()
        {
            return this._connectionExpiry != null;
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL of the websocket.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}