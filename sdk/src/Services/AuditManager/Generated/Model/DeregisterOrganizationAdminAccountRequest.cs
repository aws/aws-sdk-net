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
    /// Container for the parameters to the DeregisterOrganizationAdminAccount operation.
    /// Removes the specified Amazon Web Services account as a delegated administrator for
    /// Audit Manager. 
    /// 
    ///  
    /// <para>
    /// When you remove a delegated administrator from your Audit Manager settings, you continue
    /// to have access to the evidence that you previously collected under that account. This
    /// is also the case when you deregister a delegated administrator from Organizations.
    /// However, Audit Manager stops collecting and attaching evidence to that delegated administrator
    /// account moving forward.
    /// </para>
    ///  <important> 
    /// <para>
    /// Keep in mind the following cleanup task if you use evidence finder:
    /// </para>
    ///  
    /// <para>
    /// Before you use your management account to remove a delegated administrator, make sure
    /// that the current delegated administrator account signs in to Audit Manager and disables
    /// evidence finder first. Disabling evidence finder automatically deletes the event data
    /// store that was created in their account when they enabled evidence finder. If this
    /// task isn’t completed, the event data store remains in their account. In this case,
    /// we recommend that the original delegated administrator goes to CloudTrail Lake and
    /// manually <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/query-eds-disable-termination.html">deletes
    /// the event data store</a>.
    /// </para>
    ///  
    /// <para>
    /// This cleanup task is necessary to ensure that you don't end up with multiple event
    /// data stores. Audit Manager ignores an unused event data store after you remove or
    /// change a delegated administrator account. However, the unused event data store continues
    /// to incur storage costs from CloudTrail Lake if you don't delete it.
    /// </para>
    ///  </important> 
    /// <para>
    /// When you deregister a delegated administrator account for Audit Manager, the data
    /// for that account isn’t deleted. If you want to delete resource data for a delegated
    /// administrator account, you must perform that task separately before you deregister
    /// the account. Either, you can do this in the Audit Manager console. Or, you can use
    /// one of the delete API operations that are provided by Audit Manager. 
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
    /// At this time, Audit Manager doesn't provide an option to delete evidence for a specific
    /// delegated administrator. Instead, when your management account deregisters Audit Manager,
    /// we perform a cleanup for the current delegated administrator account at the time of
    /// deregistration.
    /// </para>
    /// </summary>
    public partial class DeregisterOrganizationAdminAccountRequest : AmazonAuditManagerRequest
    {
        private string _adminAccountId;

        /// <summary>
        /// Gets and sets the property AdminAccountId. 
        /// <para>
        ///  The identifier for the administrator account. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
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