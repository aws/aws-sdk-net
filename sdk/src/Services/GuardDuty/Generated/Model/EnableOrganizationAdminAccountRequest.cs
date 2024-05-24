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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Container for the parameters to the EnableOrganizationAdminAccount operation.
    /// Designates an Amazon Web Services account within the organization as your GuardDuty
    /// delegated administrator. Only the organization's management account can run this API
    /// operation.
    /// </summary>
    public partial class EnableOrganizationAdminAccountRequest : AmazonGuardDutyRequest
    {
        private string _adminAccountId;

        /// <summary>
        /// Gets and sets the property AdminAccountId. 
        /// <para>
        /// The Amazon Web Services account ID for the organization account to be enabled as a
        /// GuardDuty delegated administrator.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AdminAccountId
        {
            get { return this._adminAccountId; }
            set { this._adminAccountId = value; }
        }

        // Check to see if AdminAccountId property is set
        internal bool IsSetAdminAccountId()
        {
            return this._adminAccountId != null;
        }

    }
}