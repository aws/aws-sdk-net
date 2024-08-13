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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Information about the approval status of a patch.
    /// </summary>
    public partial class PatchStatus
    {
        private DateTime? _approvalDate;
        private PatchComplianceLevel _complianceLevel;
        private PatchDeploymentStatus _deploymentStatus;

        /// <summary>
        /// Gets and sets the property ApprovalDate. 
        /// <para>
        /// The date the patch was approved (or will be approved if the status is <c>PENDING_APPROVAL</c>).
        /// </para>
        /// </summary>
        public DateTime? ApprovalDate
        {
            get { return this._approvalDate; }
            set { this._approvalDate = value; }
        }

        // Check to see if ApprovalDate property is set
        internal bool IsSetApprovalDate()
        {
            return this._approvalDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ComplianceLevel. 
        /// <para>
        /// The compliance severity level for a patch.
        /// </para>
        /// </summary>
        public PatchComplianceLevel ComplianceLevel
        {
            get { return this._complianceLevel; }
            set { this._complianceLevel = value; }
        }

        // Check to see if ComplianceLevel property is set
        internal bool IsSetComplianceLevel()
        {
            return this._complianceLevel != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentStatus. 
        /// <para>
        /// The approval status of a patch.
        /// </para>
        /// </summary>
        public PatchDeploymentStatus DeploymentStatus
        {
            get { return this._deploymentStatus; }
            set { this._deploymentStatus = value; }
        }

        // Check to see if DeploymentStatus property is set
        internal bool IsSetDeploymentStatus()
        {
            return this._deploymentStatus != null;
        }

    }
}