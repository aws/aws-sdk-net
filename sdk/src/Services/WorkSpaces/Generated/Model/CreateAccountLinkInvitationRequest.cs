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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
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
namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAccountLinkInvitation operation.
    /// Creates the account link invitation.
    /// </summary>
    public partial class CreateAccountLinkInvitationRequest : AmazonWorkSpacesRequest
    {
        private string _clientToken;
        private string _targetAccountId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A string of up to 64 ASCII characters that Amazon WorkSpaces uses to ensure idempotent
        /// creation.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property TargetAccountId. 
        /// <para>
        /// The identifier of the target account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TargetAccountId
        {
            get { return this._targetAccountId; }
            set { this._targetAccountId = value; }
        }

        // Check to see if TargetAccountId property is set
        internal bool IsSetTargetAccountId()
        {
            return this._targetAccountId != null;
        }

    }
}