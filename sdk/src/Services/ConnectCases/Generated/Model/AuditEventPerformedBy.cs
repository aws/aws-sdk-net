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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
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
namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// Information of the user which performed the audit.
    /// </summary>
    public partial class AuditEventPerformedBy
    {
        private string _iamPrincipalArn;
        private UserUnion _user;

        /// <summary>
        /// Gets and sets the property IamPrincipalArn. 
        /// <para>
        /// Unique identifier of an IAM role.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string IamPrincipalArn
        {
            get { return this._iamPrincipalArn; }
            set { this._iamPrincipalArn = value; }
        }

        // Check to see if IamPrincipalArn property is set
        internal bool IsSetIamPrincipalArn()
        {
            return this._iamPrincipalArn != null;
        }

        /// <summary>
        /// Gets and sets the property User.
        /// </summary>
        public UserUnion User
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