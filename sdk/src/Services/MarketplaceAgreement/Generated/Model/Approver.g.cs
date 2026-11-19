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

namespace Amazon.MarketplaceAgreement.Model
{
    /// <summary>
    /// An approver in an approval plan.
    /// </summary>
    public partial class Approver
    {
        /// <summary>
        /// Gets and sets the property AwsOrganizationAdminApprover. 
        /// <para>
        /// The administrators of the buyer's AWS organization.
        /// </para>
        /// </summary>
        public AwsOrganizationAdminApprover AwsOrganizationAdminApprover { get; set; }

        /// <summary>
        /// Checks to see if the AwsOrganizationAdminApprover property is set.
        /// </summary>
        internal bool IsSetAwsOrganizationAdminApprover() => this.AwsOrganizationAdminApprover != null;

        /// <summary>
        /// Gets and sets the property EmailApprover. 
        /// <para>
        /// An approver who is identified by an email address.
        /// </para>
        /// </summary>
        public EmailApprover EmailApprover { get; set; }

        /// <summary>
        /// Checks to see if the EmailApprover property is set.
        /// </summary>
        internal bool IsSetEmailApprover() => this.EmailApprover != null;

        /// <summary>
        /// Gets and sets the property ProcurementToolApprover. 
        /// <para>
        /// A procurement system that approves through the buyer's procurement integration.
        /// </para>
        /// </summary>
        public ProcurementToolApprover ProcurementToolApprover { get; set; }

        /// <summary>
        /// Checks to see if the ProcurementToolApprover property is set.
        /// </summary>
        internal bool IsSetProcurementToolApprover() => this.ProcurementToolApprover != null;
    }
}
