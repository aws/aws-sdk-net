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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.NetworkSecurityManager.Model
{
    /// <summary>
    /// Container for the parameters to the PutAdminAccount operation. Sets the AWS account
    /// that serves as an AWS Network Security Manager administrator account, and optionally
    /// configures the scope of resources that the administrator can manage. <para> You can't
    /// set an administrator account again immediately after you remove it, or while the service
    /// creates its service-linked role. Retry the request after a few minutes. </para>
    /// </summary>
    public partial class PutAdminAccountRequest : AmazonNetworkSecurityManagerRequest
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The AWS account ID to set as the AWS Network Security Manager administrator account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property AdminScope. 
        /// <para>
        /// The scope of accounts, organizational units, and firewall types that the administrator
        /// can manage.
        /// </para>
        /// </summary>
        public AdminScopeInput AdminScope { get; set; }

        /// <summary>
        /// Checks to see if the AdminScope property is set.
        /// </summary>
        internal bool IsSetAdminScope() => this.AdminScope != null;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The priority to assign to the administrator account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;
    }
}
