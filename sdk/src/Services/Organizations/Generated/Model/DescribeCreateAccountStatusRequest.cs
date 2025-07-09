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
    /// Container for the parameters to the DescribeCreateAccountStatus operation.
    /// Retrieves the current status of an asynchronous request to create an account.
    /// 
    ///  
    /// <para>
    /// This operation can be called only from the organization's management account or by
    /// a member account that is a delegated administrator.
    /// </para>
    /// </summary>
    public partial class DescribeCreateAccountStatusRequest : AmazonOrganizationsRequest
    {
        private string _createAccountRequestId;

        /// <summary>
        /// Gets and sets the property CreateAccountRequestId. 
        /// <para>
        /// Specifies the <c>Id</c> value that uniquely identifies the <c>CreateAccount</c> request.
        /// You can get the value from the <c>CreateAccountStatus.Id</c> response in an earlier
        /// <a>CreateAccount</a> request, or from the <a>ListCreateAccountStatus</a> operation.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for a create account
        /// request ID string requires "car-" followed by from 8 to 32 lowercase letters or digits.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=36)]
        public string CreateAccountRequestId
        {
            get { return this._createAccountRequestId; }
            set { this._createAccountRequestId = value; }
        }

        // Check to see if CreateAccountRequestId property is set
        internal bool IsSetCreateAccountRequestId()
        {
            return this._createAccountRequestId != null;
        }

    }
}