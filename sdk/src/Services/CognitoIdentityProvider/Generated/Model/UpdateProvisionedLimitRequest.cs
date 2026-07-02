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
    /// Container for the parameters to the UpdateProvisionedLimit operation.
    /// Sets the provisioned limit for a specific API category. The value must be between
    /// the default limit and your account-level maximum limit in Service Quotas.
    /// 
    ///  
    /// <para>
    /// Managed login user pools don't support adjustments to the <c>UserAuthentication</c>
    /// or <c>UserFederation</c> categories. To increase these limits, submit a Service Quotas
    /// increase request.
    /// </para>
    ///  <note> 
    /// <para>
    /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
    /// for this API operation. For this operation, you must use IAM credentials to authorize
    /// requests, and you must grant yourself the corresponding IAM permission in a policy.
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
    /// Amazon Web Services API Requests</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
    /// the Amazon Cognito user pools API and user pool endpoints</a> 
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class UpdateProvisionedLimitRequest : AmazonCognitoIdentityProviderRequest
    {
        private LimitDefinitionType _limitDefinition;
        private int? _requestedLimitValue;

        /// <summary>
        /// Gets and sets the property LimitDefinition. 
        /// <para>
        /// The limit to update. Specify the limit class and the attributes that identify the
        /// limit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LimitDefinitionType LimitDefinition
        {
            get { return this._limitDefinition; }
            set { this._limitDefinition = value; }
        }

        // Check to see if LimitDefinition property is set
        internal bool IsSetLimitDefinition()
        {
            return this._limitDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property RequestedLimitValue. 
        /// <para>
        /// The provisioned rate to set, in requests per second (RPS).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? RequestedLimitValue
        {
            get { return this._requestedLimitValue; }
            set { this._requestedLimitValue = value; }
        }

        // Check to see if RequestedLimitValue property is set
        internal bool IsSetRequestedLimitValue()
        {
            return this._requestedLimitValue.HasValue; 
        }

    }
}