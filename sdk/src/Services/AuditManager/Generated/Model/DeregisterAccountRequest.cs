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
    /// When you deregister your account from Audit Manager, your data isn’t deleted. If you
    /// want to delete your resource data, you must perform that task separately before you
    /// deregister your account. Either, you can do this in the Audit Manager console. Or,
    /// you can use one of the delete API operations that are provided by Audit Manager. 
    /// </para>
    ///  
    /// <para>
    /// To delete your Audit Manager resource data, see the following instructions: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/API_DeleteAssessment.html">DeleteAssessment</a>
    /// (see also: <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/delete-assessment.html">Deleting
    /// an assessment</a> in the <i>Audit Manager User Guide</i>)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/API_DeleteAssessmentFramework.html">DeleteAssessmentFramework</a>
    /// (see also: <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/delete-custom-framework.html">Deleting
    /// a custom framework</a> in the <i>Audit Manager User Guide</i>)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/API_DeleteAssessmentFrameworkShare.html">DeleteAssessmentFrameworkShare</a>
    /// (see also: <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/deleting-shared-framework-requests.html">Deleting
    /// a share request</a> in the <i>Audit Manager User Guide</i>)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/API_DeleteAssessmentReport.html">DeleteAssessmentReport</a>
    /// (see also: <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/generate-assessment-report.html#delete-assessment-report-steps">Deleting
    /// an assessment report</a> in the <i>Audit Manager User Guide</i>)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/API_DeleteControl.html">DeleteControl</a>
    /// (see also: <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/delete-controls.html">Deleting
    /// a custom control</a> in the <i>Audit Manager User Guide</i>)
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// At this time, Audit Manager doesn't provide an option to delete evidence. All available
    /// delete operations are listed above.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeregisterAccountRequest : AmazonAuditManagerRequest
    {

    }
}