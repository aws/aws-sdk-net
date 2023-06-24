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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The custom credentials required for custom authentication.
    /// </summary>
    public partial class CustomAuthCredentials
    {
        private Dictionary<string, string> _credentialsMap = new Dictionary<string, string>();
        private string _customAuthenticationType;

        /// <summary>
        /// Gets and sets the property CredentialsMap. 
        /// <para>
        /// A map that holds custom authentication credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> CredentialsMap
        {
            get { return this._credentialsMap; }
            set { this._credentialsMap = value; }
        }

        // Check to see if CredentialsMap property is set
        internal bool IsSetCredentialsMap()
        {
            return this._credentialsMap != null && this._credentialsMap.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CustomAuthenticationType. 
        /// <para>
        /// The custom authentication type that the connector uses.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string CustomAuthenticationType
        {
            get { return this._customAuthenticationType; }
            set { this._customAuthenticationType = value; }
        }

        // Check to see if CustomAuthenticationType property is set
        internal bool IsSetCustomAuthenticationType()
        {
            return this._customAuthenticationType != null;
        }

    }
}