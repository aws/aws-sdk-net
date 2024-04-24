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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
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
namespace Amazon.FMS.Model
{
    /// <summary>
    /// Container for the parameters to the DisassociateAdminAccount operation.
    /// Disassociates an Firewall Manager administrator account. To set a different account
    /// as an Firewall Manager administrator, submit a <a>PutAdminAccount</a> request. To
    /// set an account as a default administrator account, you must submit an <a>AssociateAdminAccount</a>
    /// request.
    /// 
    ///  
    /// <para>
    /// Disassociation of the default administrator account follows the first in, last out
    /// principle. If you are the default administrator, all Firewall Manager administrators
    /// within the organization must first disassociate their accounts before you can disassociate
    /// your account.
    /// </para>
    /// </summary>
    public partial class DisassociateAdminAccountRequest : AmazonFMSRequest
    {

    }
}