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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the GetInvitationsCount operation.
    /// <note> 
    /// <para>
    /// We recommend using Organizations instead of Security Hub invitations to manage your
    /// member accounts. For information, see <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/securityhub-accounts-orgs.html">Managing
    /// Security Hub administrator and member accounts with Organizations</a> in the <i>Security
    /// Hub User Guide</i>.
    /// </para>
    ///  </note> 
    /// <para>
    /// Returns the count of all Security Hub membership invitations that were sent to the
    /// calling member account, not including the currently accepted invitation. 
    /// </para>
    /// </summary>
    public partial class GetInvitationsCountRequest : AmazonSecurityHubRequest
    {

    }
}