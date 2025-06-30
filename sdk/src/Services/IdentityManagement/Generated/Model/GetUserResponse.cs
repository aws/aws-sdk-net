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
    /// Contains the response to a successful <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetUser.html">GetUser</a>
    /// request.
    /// </summary>
    public partial class GetUserResponse : AmazonWebServiceResponse
    {
        private User _user;

        /// <summary>
        /// Gets and sets the property User. 
        /// <para>
        /// A structure containing details about the IAM user.
        /// </para>
        ///  <important> 
        /// <para>
        /// Due to a service issue, password last used data does not include password use from
        /// May 3, 2018 22:50 PDT to May 23, 2018 14:08 PDT. This affects <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_finding-unused.html">last
        /// sign-in</a> dates shown in the IAM console and password last used dates in the <a
        /// href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_getting-report.html">IAM
        /// credential report</a>, and returned by this operation. If users signed in during the
        /// affected time, the password last used date that is returned is the date the user last
        /// signed in before May 3, 2018. For users that signed in after May 23, 2018 14:08 PDT,
        /// the returned password last used date is accurate.
        /// </para>
        ///  
        /// <para>
        /// You can use password last used information to identify unused credentials for deletion.
        /// For example, you might delete users who did not sign in to Amazon Web Services in
        /// the last 90 days. In cases like this, we recommend that you adjust your evaluation
        /// window to include dates after May 23, 2018. Alternatively, if your users use access
        /// keys to access Amazon Web Services programmatically you can refer to access key last
        /// used information because it is accurate for all dates. 
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true)]
        public User User
        {
            get { return this._user; }
            set { this._user = value; }
        }

        // Check to see if User property is set
        internal bool IsSetUser()
        {
            return this._user != null;
        }

    }
}