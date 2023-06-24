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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// Describes an EWS based availability provider. This is only used as input to the service.
    /// </summary>
    public partial class EwsAvailabilityProvider
    {
        private string _ewsEndpoint;
        private string _ewsPassword;
        private string _ewsUsername;

        /// <summary>
        /// Gets and sets the property EwsEndpoint. 
        /// <para>
        /// The endpoint of the remote EWS server.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string EwsEndpoint
        {
            get { return this._ewsEndpoint; }
            set { this._ewsEndpoint = value; }
        }

        // Check to see if EwsEndpoint property is set
        internal bool IsSetEwsEndpoint()
        {
            return this._ewsEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property EwsPassword. 
        /// <para>
        /// The password used to authenticate the remote EWS server.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Max=256)]
        public string EwsPassword
        {
            get { return this._ewsPassword; }
            set { this._ewsPassword = value; }
        }

        // Check to see if EwsPassword property is set
        internal bool IsSetEwsPassword()
        {
            return this._ewsPassword != null;
        }

        /// <summary>
        /// Gets and sets the property EwsUsername. 
        /// <para>
        /// The username used to authenticate the remote EWS server.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string EwsUsername
        {
            get { return this._ewsUsername; }
            set { this._ewsUsername = value; }
        }

        // Check to see if EwsUsername property is set
        internal bool IsSetEwsUsername()
        {
            return this._ewsUsername != null;
        }

    }
}