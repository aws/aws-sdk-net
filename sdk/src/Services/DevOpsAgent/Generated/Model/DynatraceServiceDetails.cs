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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Complete service details for Dynatrace integration.
    /// </summary>
    public partial class DynatraceServiceDetails
    {
        private string _accountUrn;
        private DynatraceServiceAuthorizationConfig _authorizationConfig;

        /// <summary>
        /// Gets and sets the property AccountUrn. 
        /// <para>
        /// Dynatrace resource account urn.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string AccountUrn
        {
            get { return this._accountUrn; }
            set { this._accountUrn = value; }
        }

        // Check to see if AccountUrn property is set
        internal bool IsSetAccountUrn()
        {
            return this._accountUrn != null;
        }

        /// <summary>
        /// Gets and sets the property AuthorizationConfig. 
        /// <para>
        /// Dynatrace OAuth client credentials configuration. Use this when registering with OAuth
        /// client credentials flow.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public DynatraceServiceAuthorizationConfig AuthorizationConfig
        {
            get { return this._authorizationConfig; }
            set { this._authorizationConfig = value; }
        }

        // Check to see if AuthorizationConfig property is set
        internal bool IsSetAuthorizationConfig()
        {
            return this._authorizationConfig != null;
        }

    }
}