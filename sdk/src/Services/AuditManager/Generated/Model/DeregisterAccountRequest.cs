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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// Container for the parameters to the DeregisterAccount operation.
    /// Deregisters an account in Audit Manager. 
    /// 
    ///  <note> 
    /// <para>
    /// Before you deregister, you can use the <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/API_UpdateSettings.html">UpdateSettings</a>
    /// API operation to set your preferred data retention policy. By default, Audit Manager
    /// retains your data. If you want to delete your data, you can use the <code>DeregistrationPolicy</code>
    /// attribute to request the deletion of your data. 
    /// </para>
    ///  
    /// <para>
    /// For more information about data retention, see <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/data-protection.html">Data
    /// Protection</a> in the <i>Audit Manager User Guide</i>. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeregisterAccountRequest : AmazonAuditManagerRequest
    {

    }
}