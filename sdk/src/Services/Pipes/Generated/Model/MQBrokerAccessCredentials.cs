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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pipes.Model
{
    /// <summary>
    /// The Secrets Manager secret that stores your broker credentials.
    /// </summary>
    public partial class MQBrokerAccessCredentials
    {
        private string _basicAuth;

        /// <summary>
        /// Gets and sets the property BasicAuth. 
        /// <para>
        /// The ARN of the Secrets Manager secret.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string BasicAuth
        {
            get { return this._basicAuth; }
            set { this._basicAuth = value; }
        }

        // Check to see if BasicAuth property is set
        internal bool IsSetBasicAuth()
        {
            return this._basicAuth != null;
        }

    }
}