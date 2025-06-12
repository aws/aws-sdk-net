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
    /// Container for the parameters to the SetLogDeliveryConfiguration operation.
    /// Sets up or modifies the logging configuration of a user pool. User pools can export
    /// user notification logs and, when threat protection is active, user-activity logs.
    /// For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/exporting-quotas-and-usage.html">Exporting
    /// user pool logs</a>.
    /// </summary>
    public partial class SetLogDeliveryConfigurationRequest : AmazonCognitoIdentityProviderRequest
    {
        private List<LogConfigurationType> _logConfigurations = AWSConfigs.InitializeCollections ? new List<LogConfigurationType>() : null;
        private string _userPoolId;

        /// <summary>
        /// Gets and sets the property LogConfigurations. 
        /// <para>
        /// A collection of the logging configurations for a user pool.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2)]
        public List<LogConfigurationType> LogConfigurations
        {
            get { return this._logConfigurations; }
            set { this._logConfigurations = value; }
        }

        // Check to see if LogConfigurations property is set
        internal bool IsSetLogConfigurations()
        {
            return this._logConfigurations != null && (this._logConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The ID of the user pool where you want to configure logging.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=55)]
        public string UserPoolId
        {
            get { return this._userPoolId; }
            set { this._userPoolId = value; }
        }

        // Check to see if UserPoolId property is set
        internal bool IsSetUserPoolId()
        {
            return this._userPoolId != null;
        }

    }
}