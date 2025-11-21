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
    /// This is the response object from the CreateDelegationRequest operation.
    /// </summary>
    public partial class CreateDelegationRequestResponse : AmazonWebServiceResponse
    {
        private string _consoleDeepLink;
        private string _delegationRequestId;

        /// <summary>
        /// Gets and sets the property ConsoleDeepLink. 
        /// <para>
        /// A deep link URL to the Amazon Web Services Management Console for managing the delegation
        /// request.
        /// </para>
        ///  
        /// <para>
        /// For a console based workflow, partners should redirect the customer to this URL. If
        /// the customer is not logged in to any Amazon Web Services account, the Amazon Web Services
        /// workflow will automatically direct the customer to log in and then display the delegation
        /// request approval page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ConsoleDeepLink
        {
            get { return this._consoleDeepLink; }
            set { this._consoleDeepLink = value; }
        }

        // Check to see if ConsoleDeepLink property is set
        internal bool IsSetConsoleDeepLink()
        {
            return this._consoleDeepLink != null;
        }

        /// <summary>
        /// Gets and sets the property DelegationRequestId. 
        /// <para>
        /// The unique identifier for the created delegation request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=16, Max=128)]
        public string DelegationRequestId
        {
            get { return this._delegationRequestId; }
            set { this._delegationRequestId = value; }
        }

        // Check to see if DelegationRequestId property is set
        internal bool IsSetDelegationRequestId()
        {
            return this._delegationRequestId != null;
        }

    }
}