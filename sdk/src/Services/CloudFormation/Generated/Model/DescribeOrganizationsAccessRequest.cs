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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeOrganizationsAccess operation.
    /// Retrieves information about the account's <c>OrganizationAccess</c> status. This API
    /// can be called either by the management account or the delegated administrator by using
    /// the <c>CallAs</c> parameter. This API can also be called without the <c>CallAs</c>
    /// parameter by the management account.
    /// </summary>
    public partial class DescribeOrganizationsAccessRequest : AmazonCloudFormationRequest
    {
        private CallAs _callAs;

        /// <summary>
        /// Gets and sets the property CallAs. 
        /// <para>
        /// [Service-managed permissions] Specifies whether you are acting as an account administrator
        /// in the organization's management account or as a delegated administrator in a member
        /// account.
        /// </para>
        ///  
        /// <para>
        /// By default, <c>SELF</c> is specified.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you are signed in to the management account, specify <c>SELF</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are signed in to a delegated administrator account, specify <c>DELEGATED_ADMIN</c>.
        /// </para>
        ///  
        /// <para>
        /// Your Amazon Web Services account must be registered as a delegated administrator in
        /// the management account. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-orgs-delegated-admin.html">Register
        /// a delegated administrator</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CallAs CallAs
        {
            get { return this._callAs; }
            set { this._callAs = value; }
        }

        // Check to see if CallAs property is set
        internal bool IsSetCallAs()
        {
            return this._callAs != null;
        }

    }
}