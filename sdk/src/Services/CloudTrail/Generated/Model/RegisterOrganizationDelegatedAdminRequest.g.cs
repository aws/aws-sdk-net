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

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterOrganizationDelegatedAdmin operation.
    /// Registers an organization’s member account as the CloudTrail <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-delegated-administrator.html">delegated
    /// administrator</a>.
    /// </summary>
    public partial class RegisterOrganizationDelegatedAdminRequest : AmazonCloudTrailRequest
    {
        /// <summary>
        /// Gets and sets the property MemberAccountId. 
        /// <para>
        /// An organization member account ID that you want to designate as a delegated administrator.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 16)]
        public string MemberAccountId { get; set; }

        /// <summary>
        /// Checks to see if the MemberAccountId property is set.
        /// </summary>
        internal bool IsSetMemberAccountId() => this.MemberAccountId != null;
    }
}
