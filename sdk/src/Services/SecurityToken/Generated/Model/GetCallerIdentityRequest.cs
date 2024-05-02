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
 * Do not modify this file. This file is generated from the sts-2011-06-15.normal.json service model.
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
namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// Container for the parameters to the GetCallerIdentity operation.
    /// Returns details about the IAM user or role whose credentials are used to call the
    /// operation.
    /// 
    ///  <note> 
    /// <para>
    /// No permissions are required to perform this operation. If an administrator attaches
    /// a policy to your identity that explicitly denies access to the <c>sts:GetCallerIdentity</c>
    /// action, you can still perform this operation. Permissions are not required because
    /// the same information is returned when access is denied. To view an example response,
    /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/troubleshoot_general.html#troubleshoot_general_access-denied-delete-mfa">I
    /// Am Not Authorized to Perform: iam:DeleteVirtualMFADevice</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetCallerIdentityRequest : AmazonSecurityTokenServiceRequest
    {

    }
}