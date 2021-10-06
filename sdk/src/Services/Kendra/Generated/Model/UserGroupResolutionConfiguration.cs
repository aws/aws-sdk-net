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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides the configuration information to fetch access levels of groups and users
    /// from an AWS Single Sign-On identity source. This is useful for setting up user context
    /// filtering, where Amazon Kendra filters search results for different users based on
    /// their group's access to documents. You can also map your users to their groups for
    /// user context filtering using the <a href="https://docs.aws.amazon.com/latest/dg/API_PutPrincipalMapping.html">PutPrincipalMapping
    /// operation</a>.
    /// 
    ///  
    /// <para>
    /// To set up an AWS SSO identity source in the console to use with Amazon Kendra, see
    /// <a href="https://docs.aws.amazon.com/kendra/latest/dg/getting-started-aws-sso.html">Getting
    /// started with an AWS SSO identity source</a>. You must also grant the required permissions
    /// to use AWS SSO with Amazon Kendra. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/iam-roles.html#iam-roles-aws-sso">IAM
    /// roles for AWS Single Sign-On</a>.
    /// </para>
    /// </summary>
    public partial class UserGroupResolutionConfiguration
    {
        private UserGroupResolutionMode _userGroupResolutionMode;

        /// <summary>
        /// Gets and sets the property UserGroupResolutionMode. 
        /// <para>
        /// The identity store provider (mode) you want to use to fetch access levels of groups
        /// and users. AWS Single Sign-On is currently the only available mode. Your users and
        /// groups must exist in an AWS SSO identity source in order to use this mode.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UserGroupResolutionMode UserGroupResolutionMode
        {
            get { return this._userGroupResolutionMode; }
            set { this._userGroupResolutionMode = value; }
        }

        // Check to see if UserGroupResolutionMode property is set
        internal bool IsSetUserGroupResolutionMode()
        {
            return this._userGroupResolutionMode != null;
        }

    }
}