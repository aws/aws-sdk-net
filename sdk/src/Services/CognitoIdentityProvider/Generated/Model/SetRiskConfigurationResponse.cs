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
    /// This is the response object from the SetRiskConfiguration operation.
    /// </summary>
    public partial class SetRiskConfigurationResponse : AmazonWebServiceResponse
    {
        private RiskConfigurationType _riskConfiguration;

        /// <summary>
        /// Gets and sets the property RiskConfiguration. 
        /// <para>
        /// The API response that contains the risk configuration that you set and the timestamp
        /// of the most recent change.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RiskConfigurationType RiskConfiguration
        {
            get { return this._riskConfiguration; }
            set { this._riskConfiguration = value; }
        }

        // Check to see if RiskConfiguration property is set
        internal bool IsSetRiskConfiguration()
        {
            return this._riskConfiguration != null;
        }

    }
}