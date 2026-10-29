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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Information about the approval status of a patch.
    /// </summary>
    public partial class PatchStatus
    {
        /// <summary>
        /// Gets and sets the property ApprovalDate. 
        /// <para>
        /// The date the patch was approved (or will be approved if the status is <c>PENDING_APPROVAL</c>).
        /// </para>
        /// </summary>
        public DateTime? ApprovalDate { get; set; }

        /// <summary>
        /// Checks to see if the ApprovalDate property is set.
        /// </summary>
        internal bool IsSetApprovalDate() => this.ApprovalDate.HasValue;

        /// <summary>
        /// Gets and sets the property ComplianceLevel. 
        /// <para>
        /// The compliance severity level for a patch.
        /// </para>
        /// </summary>
        public PatchComplianceLevel ComplianceLevel { get; set; }

        /// <summary>
        /// Checks to see if the ComplianceLevel property is set.
        /// </summary>
        internal bool IsSetComplianceLevel() => this.ComplianceLevel != null;

        /// <summary>
        /// Gets and sets the property DeploymentStatus. 
        /// <para>
        /// The approval status of a patch.
        /// </para>
        /// </summary>
        public PatchDeploymentStatus DeploymentStatus { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentStatus property is set.
        /// </summary>
        internal bool IsSetDeploymentStatus() => this.DeploymentStatus != null;
    }
}
