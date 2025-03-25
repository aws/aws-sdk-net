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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
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
namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Contains settings for activation of threat protection, including the operating mode
    /// and additional authentication types. To log user security information but take no
    /// action, set to <c>AUDIT</c>. To configure automatic security responses to potentially
    /// unwanted traffic to your user pool, set to <c>ENFORCED</c>.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pool-settings-advanced-security.html">Adding
    /// advanced security to a user pool</a>. To activate this setting, your user pool must
    /// be on the <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/feature-plans-features-plus.html">
    /// Plus tier</a>.
    /// </para>
    /// </summary>
    public partial class UserPoolAddOnsType
    {
        private AdvancedSecurityAdditionalFlowsType _advancedSecurityAdditionalFlows;
        private AdvancedSecurityModeType _advancedSecurityMode;

        /// <summary>
        /// Gets and sets the property AdvancedSecurityAdditionalFlows. 
        /// <para>
        /// Threat protection configuration options for additional authentication types in your
        /// user pool, including custom authentication. 
        /// </para>
        /// </summary>
        public AdvancedSecurityAdditionalFlowsType AdvancedSecurityAdditionalFlows
        {
            get { return this._advancedSecurityAdditionalFlows; }
            set { this._advancedSecurityAdditionalFlows = value; }
        }

        // Check to see if AdvancedSecurityAdditionalFlows property is set
        internal bool IsSetAdvancedSecurityAdditionalFlows()
        {
            return this._advancedSecurityAdditionalFlows != null;
        }

        /// <summary>
        /// Gets and sets the property AdvancedSecurityMode. 
        /// <para>
        /// The operating mode of threat protection for standard authentication types in your
        /// user pool, including username-password and secure remote password (SRP) authentication.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AdvancedSecurityModeType AdvancedSecurityMode
        {
            get { return this._advancedSecurityMode; }
            set { this._advancedSecurityMode = value; }
        }

        // Check to see if AdvancedSecurityMode property is set
        internal bool IsSetAdvancedSecurityMode()
        {
            return this._advancedSecurityMode != null;
        }

    }
}