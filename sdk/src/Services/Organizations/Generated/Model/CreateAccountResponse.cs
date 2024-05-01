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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
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
namespace Amazon.Organizations.Model
{
    /// <summary>
    /// This is the response object from the CreateAccount operation.
    /// </summary>
    public partial class CreateAccountResponse : AmazonWebServiceResponse
    {
        private CreateAccountStatus _createAccountStatus;

        /// <summary>
        /// Gets and sets the property CreateAccountStatus. 
        /// <para>
        /// A structure that contains details about the request to create an account. This response
        /// structure might not be fully populated when you first receive it because account creation
        /// is an asynchronous process. You can pass the returned <c>CreateAccountStatus</c> ID
        /// as a parameter to <a>DescribeCreateAccountStatus</a> to get status about the progress
        /// of the request at later times. You can also check the CloudTrail log for the <c>CreateAccountResult</c>
        /// event. For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_security_incident-response.html">Logging
        /// and monitoring in Organizations</a> in the <i>Organizations User Guide</i>.
        /// </para>
        /// </summary>
        public CreateAccountStatus CreateAccountStatus
        {
            get { return this._createAccountStatus; }
            set { this._createAccountStatus = value; }
        }

        // Check to see if CreateAccountStatus property is set
        internal bool IsSetCreateAccountStatus()
        {
            return this._createAccountStatus != null;
        }

    }
}