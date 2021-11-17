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
    /// Container for the parameters to the GetLatestConfiguration operation.
    /// Retrieves the latest deployed configuration. This API may return empty Configuration
    /// data if the client already has the latest version. See StartConfigurationSession to
    /// obtain an InitialConfigurationToken to call this API.
    /// 
    ///  <important> 
    /// <para>
    /// Each call to GetLatestConfiguration returns a new ConfigurationToken (NextPollConfigurationToken
    /// in the response). This new token MUST be provided to the next call to GetLatestConfiguration
    /// when polling for configuration updates.
    /// </para>
    ///  
    /// <para>
    /// To avoid excess charges, we recommend that you include the <code>ClientConfigurationVersion</code>
    /// value with every call to <code>GetConfiguration</code>. This value must be saved on
    /// your client. Subsequent calls to <code>GetConfiguration</code> must pass this value
    /// by using the <code>ClientConfigurationVersion</code> parameter. 
    /// </para>
    ///  </important>
    /// </summary>
    public partial class GetLatestConfigurationRequest : AmazonAppConfigDataRequest
    {
        private string _configurationToken;

        /// <summary>
        /// Gets and sets the property ConfigurationToken. 
        /// <para>
        /// Token describing the current state of the configuration session. To obtain a token,
        /// first call the StartConfigurationSession API. Note that every call to GetLatestConfiguration
        /// will return a new ConfigurationToken (NextPollConfigurationToken in the response)
        /// and MUST be provided to subsequent GetLatestConfiguration API calls.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConfigurationToken
        {
            get { return this._configurationToken; }
            set { this._configurationToken = value; }
        }

        // Check to see if ConfigurationToken property is set
        internal bool IsSetConfigurationToken()
        {
            return this._configurationToken != null;
        }

    }
}