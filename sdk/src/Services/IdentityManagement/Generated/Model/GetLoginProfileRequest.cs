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
    /// Container for the parameters to the GetLoginProfile operation.
    /// Retrieves the user name for the specified IAM user. A login profile is created when
    /// you create a password for the user to access the Amazon Web Services Management Console.
    /// If the user does not exist or does not have a password, the operation returns a 404
    /// (<c>NoSuchEntity</c>) error.
    /// 
    ///  
    /// <para>
    /// If you create an IAM user with access to the console, the <c>CreateDate</c> reflects
    /// the date you created the initial password for the user.
    /// </para>
    ///  
    /// <para>
    /// If you create an IAM user with programmatic access, and then later add a password
    /// for the user to access the Amazon Web Services Management Console, the <c>CreateDate</c>
    /// reflects the initial password creation date. A user with programmatic access does
    /// not have a login profile unless you create a password for the user to access the Amazon
    /// Web Services Management Console.
    /// </para>
    /// </summary>
    public partial class GetLoginProfileRequest : AmazonIdentityManagementServiceRequest
    {
        private string _userName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public GetLoginProfileRequest() { }

        /// <summary>
        /// Instantiates GetLoginProfileRequest with the parameterized properties
        /// </summary>
        /// <param name="userName">The name of the user whose login profile you want to retrieve. This parameter is optional. If no user name is included, it defaults to the principal making the request. When you make this request with root user credentials, you must use an <a href="https://docs.aws.amazon.com/STS/latest/APIReference/API_AssumeRoot.html">AssumeRoot</a> session to omit the user name. This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>) a string of characters consisting of upper and lowercase alphanumeric characters with no spaces. You can also include any of the following characters: _+=,.@-</param>
        public GetLoginProfileRequest(string userName)
        {
            _userName = userName;
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the user whose login profile you want to retrieve.
        /// </para>
        ///  
        /// <para>
        /// This parameter is optional. If no user name is included, it defaults to the principal
        /// making the request. When you make this request with root user credentials, you must
        /// use an <a href="https://docs.aws.amazon.com/STS/latest/APIReference/API_AssumeRoot.html">AssumeRoot</a>
        /// session to omit the user name.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex
        /// pattern</a>) a string of characters consisting of upper and lowercase alphanumeric
        /// characters with no spaces. You can also include any of the following characters: _+=,.@-
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

    }
}