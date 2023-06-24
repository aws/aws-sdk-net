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
    /// The connector-specific profile credentials required when using Trend Micro.
    /// </summary>
    public partial class TrendmicroConnectorProfileCredentials
    {
        private string _apiSecretKey;

        /// <summary>
        /// Gets and sets the property ApiSecretKey. 
        /// <para>
        ///  The Secret Access Key portion of the credentials. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Max=256)]
        public string ApiSecretKey
        {
            get { return this._apiSecretKey; }
            set { this._apiSecretKey = value; }
        }

        // Check to see if ApiSecretKey property is set
        internal bool IsSetApiSecretKey()
        {
            return this._apiSecretKey != null;
        }

    }
}