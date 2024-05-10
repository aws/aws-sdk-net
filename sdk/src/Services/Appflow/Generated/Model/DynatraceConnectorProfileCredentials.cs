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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The connector-specific profile credentials required by Dynatrace.
    /// </summary>
    public partial class DynatraceConnectorProfileCredentials
    {
        private string _apiToken;

        /// <summary>
        /// Gets and sets the property ApiToken. 
        /// <para>
        ///  The API tokens used by Dynatrace API to authenticate various API calls. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string ApiToken
        {
            get { return this._apiToken; }
            set { this._apiToken = value; }
        }

        // Check to see if ApiToken property is set
        internal bool IsSetApiToken()
        {
            return this._apiToken != null;
        }

    }
}