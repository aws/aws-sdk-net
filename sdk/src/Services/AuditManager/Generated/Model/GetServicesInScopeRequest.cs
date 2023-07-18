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
    /// Container for the parameters to the GetServicesInScope operation.
    /// Gets a list of all of the Amazon Web Services that you can choose to include in your
    /// assessment. When you <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/API_CreateAssessment.html">create
    /// an assessment</a>, specify which of these services you want to include to narrow the
    /// assessment's <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/API_Scope.html">scope</a>.
    /// </summary>
    public partial class GetServicesInScopeRequest : AmazonAuditManagerRequest
    {

    }
}