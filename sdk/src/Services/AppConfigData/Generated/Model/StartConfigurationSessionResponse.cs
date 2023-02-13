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
 * Do not modify this file. This file is generated from the appconfigdata-2021-11-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppConfigData.Model
{
    /// <summary>
    /// This is the response object from the StartConfigurationSession operation.
    /// </summary>
    public partial class StartConfigurationSessionResponse : AmazonWebServiceResponse
    {
        private string _initialConfigurationToken;

        /// <summary>
        /// Gets and sets the property InitialConfigurationToken. 
        /// <para>
        /// Token encapsulating state about the configuration session. Provide this token to the
        /// <code>GetLatestConfiguration</code> API to retrieve configuration data.
        /// </para>
        ///  <important> 
        /// <para>
        /// This token should only be used once in your first call to <code>GetLatestConfiguration</code>.
        /// You <i>must</i> use the new token in the <code>GetLatestConfiguration</code> response
        /// (<code>NextPollConfigurationToken</code>) in each subsequent call to <code>GetLatestConfiguration</code>.
        /// </para>
        ///  
        /// <para>
        /// The <code>InitialConfigurationToken</code> and <code>NextPollConfigurationToken</code>
        /// should only be used once. To support long poll use cases, the tokens are valid for
        /// up to 24 hours. If a <code>GetLatestConfiguration</code> call uses an expired token,
        /// the system returns <code>BadRequestException</code>.
        /// </para>
        ///  </important>
        /// </summary>
        public string InitialConfigurationToken
        {
            get { return this._initialConfigurationToken; }
            set { this._initialConfigurationToken = value; }
        }

        // Check to see if InitialConfigurationToken property is set
        internal bool IsSetInitialConfigurationToken()
        {
            return this._initialConfigurationToken != null;
        }

    }
}