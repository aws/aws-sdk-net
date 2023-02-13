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
    /// Retrieves the latest deployed configuration. This API may return empty configuration
    /// data if the client already has the latest version. For more information about this
    /// API action and to view example CLI commands that show how to use it with the <a>StartConfigurationSession</a>
    /// API action, see <a href="http://docs.aws.amazon.com/appconfig/latest/userguide/appconfig-retrieving-the-configuration">Retrieving
    /// the configuration</a> in the <i>AppConfig User Guide</i>. 
    /// 
    ///  <important> 
    /// <para>
    /// Note the following important information.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Each configuration token is only valid for one call to <code>GetLatestConfiguration</code>.
    /// The <code>GetLatestConfiguration</code> response includes a <code>NextPollConfigurationToken</code>
    /// that should always replace the token used for the just-completed call in preparation
    /// for the next one. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>GetLatestConfiguration</code> is a priced call. For more information, see <a
    /// href="https://aws.amazon.com/systems-manager/pricing/">Pricing</a>.
    /// </para>
    ///  </li> </ul> </important>
    /// </summary>
    public partial class GetLatestConfigurationRequest : AmazonAppConfigDataRequest
    {
        private string _configurationToken;

        /// <summary>
        /// Gets and sets the property ConfigurationToken. 
        /// <para>
        /// Token describing the current state of the configuration session. To obtain a token,
        /// first call the <a>StartConfigurationSession</a> API. Note that every call to <code>GetLatestConfiguration</code>
        /// will return a new <code>ConfigurationToken</code> (<code>NextPollConfigurationToken</code>
        /// in the response) and <i>must</i> be provided to subsequent <code>GetLatestConfiguration</code>
        /// API calls.
        /// </para>
        ///  <important> 
        /// <para>
        /// This token should only be used once. To support long poll use cases, the token is
        /// valid for up to 24 hours. If a <code>GetLatestConfiguration</code> call uses an expired
        /// token, the system returns <code>BadRequestException</code>.
        /// </para>
        ///  </important>
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