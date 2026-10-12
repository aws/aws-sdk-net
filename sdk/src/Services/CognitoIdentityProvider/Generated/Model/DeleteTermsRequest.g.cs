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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the DeleteTerms operation. Deletes the terms documents
    /// with the requested ID from your app client. <note> <para> Amazon Cognito evaluates
    /// Identity and Access Management (IAM) policies in requests for this API operation.
    /// For this operation, you must use IAM credentials to authorize requests, and you must
    /// grant yourself the corresponding IAM permission in a policy. </para> <para> <b>Learn
    /// more</b> </para> <ul> <li> <para> <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
    /// Amazon Web Services API Requests</a> </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
    /// the Amazon Cognito user pools API and user pool endpoints</a> </para> </li> </ul>
    /// </note>
    /// </summary>
    public partial class DeleteTermsRequest : AmazonCognitoIdentityProviderRequest
    {
        /// <summary>
        /// Gets and sets the property TermsId. 
        /// <para>
        /// The ID of the terms documents that you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TermsId { get; set; }

        /// <summary>
        /// Checks to see if the TermsId property is set.
        /// </summary>
        internal bool IsSetTermsId() => this.TermsId != null;

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The ID of the user pool that contains the terms documents that you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 55)]
        public string UserPoolId { get; set; }

        /// <summary>
        /// Checks to see if the UserPoolId property is set.
        /// </summary>
        internal bool IsSetUserPoolId() => this.UserPoolId != null;
    }
}
