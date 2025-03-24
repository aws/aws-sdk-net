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
    /// Container for the parameters to the DeleteUserPool operation.
    /// Deletes a user pool. After you delete a user pool, users can no longer sign in to
    /// any associated applications. 
    /// 
    ///  
    /// <para>
    /// When you delete a user pool, it's no longer visible or operational in your Amazon
    /// Web Services account. Amazon Cognito retains deleted user pools in an inactive state
    /// for 14 days, then begins a cleanup process that fully removes them from Amazon Web
    /// Services systems. In case of accidental deletion, contact Amazon Web ServicesSupport
    /// within 14 days for restoration assistance.
    /// </para>
    ///  
    /// <para>
    /// Amazon Cognito begins full deletion of all resources from deleted user pools after
    /// 14 days. In the case of large user pools, the cleanup process might take significant
    /// additional time before all user data is permanently deleted.
    /// </para>
    /// </summary>
    public partial class DeleteUserPoolRequest : AmazonCognitoIdentityProviderRequest
    {
        private string _userPoolId;

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The ID of the user pool that you want to delete.
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