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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// Container for the parameters to the GetServicesInScope operation.
    /// Gets a list of the Amazon Web Services services from which Audit Manager can collect
    /// evidence. 
    /// 
    ///  
    /// <para>
    /// Audit Manager defines which Amazon Web Services services are in scope for an assessment.
    /// Audit Manager infers this scope by examining the assessment’s controls and their data
    /// sources, and then mapping this information to one or more of the corresponding Amazon
    /// Web Services services that are in this list.
    /// </para>
    ///  <note> 
    /// <para>
    /// For information about why it's no longer possible to specify services in scope manually,
    /// see <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/evidence-collection-issues.html#unable-to-edit-services">I
    /// can't edit the services in scope for my assessment</a> in the <i>Troubleshooting</i>
    /// section of the Audit Manager user guide.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetServicesInScopeRequest : AmazonAuditManagerRequest
    {

    }
}