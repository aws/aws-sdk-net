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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the SetSecurityTokenServicePreferences operation.
    /// Sets the specified version of the global endpoint token as the token version used
    /// for the Amazon Web Services account.
    /// 
    ///  
    /// <para>
    /// By default, Security Token Service (STS) is available as a global service, and all
    /// STS requests go to a single endpoint at <c>https://sts.amazonaws.com</c>. Amazon Web
    /// Services recommends using Regional STS endpoints to reduce latency, build in redundancy,
    /// and increase session token availability. For information about Regional endpoints
    /// for STS, see <a href="https://docs.aws.amazon.com/general/latest/gr/sts.html">Security
    /// Token Service endpoints and quotas</a> in the <i>Amazon Web Services General Reference</i>.
    /// </para>
    ///  
    /// <para>
    /// If you make an STS call to the global endpoint, the resulting session tokens might
    /// be valid in some Regions but not others. It depends on the version that is set in
    /// this operation. Version 1 tokens are valid only in Amazon Web Services Regions that
    /// are available by default. These tokens do not work in manually enabled Regions, such
    /// as Asia Pacific (Hong Kong). Version 2 tokens are valid in all Regions. However, version
    /// 2 tokens are longer and might affect systems where you temporarily store tokens. For
    /// information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
    /// and deactivating STS in an Amazon Web Services Region</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// To view the current session token version, see the <c>GlobalEndpointTokenVersion</c>
    /// entry in the response of the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetAccountSummary.html">GetAccountSummary</a>
    /// operation.
    /// </para>
    /// </summary>
    public partial class SetSecurityTokenServicePreferencesRequest : AmazonIdentityManagementServiceRequest
    {
        private GlobalEndpointTokenVersion _globalEndpointTokenVersion;

        /// <summary>
        /// Gets and sets the property GlobalEndpointTokenVersion. 
        /// <para>
        /// The version of the global endpoint token. Version 1 tokens are valid only in Amazon
        /// Web Services Regions that are available by default. These tokens do not work in manually
        /// enabled Regions, such as Asia Pacific (Hong Kong). Version 2 tokens are valid in all
        /// Regions. However, version 2 tokens are longer and might affect systems where you temporarily
        /// store tokens.
        /// </para>
        ///  
        /// <para>
        /// For information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
        /// and deactivating STS in an Amazon Web Services Region</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GlobalEndpointTokenVersion GlobalEndpointTokenVersion
        {
            get { return this._globalEndpointTokenVersion; }
            set { this._globalEndpointTokenVersion = value; }
        }

        // Check to see if GlobalEndpointTokenVersion property is set
        internal bool IsSetGlobalEndpointTokenVersion()
        {
            return this._globalEndpointTokenVersion != null;
        }

    }
}