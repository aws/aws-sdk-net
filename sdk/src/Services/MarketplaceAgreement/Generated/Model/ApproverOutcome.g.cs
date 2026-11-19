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
    /// An approver in an agreement approval and the approver's decision.
    /// </summary>
    public partial class ApproverOutcome
    {
        /// <summary>
        /// Gets and sets the property AwsOrganizationApproverOutcome. 
        /// <para>
        /// The decision of the administrators of the buyer's AWS organization.
        /// </para>
        /// </summary>
        public AwsOrganizationApproverOutcome AwsOrganizationApproverOutcome { get; set; }

        /// <summary>
        /// Checks to see if the AwsOrganizationApproverOutcome property is set.
        /// </summary>
        internal bool IsSetAwsOrganizationApproverOutcome() => this.AwsOrganizationApproverOutcome != null;

        /// <summary>
        /// Gets and sets the property EmailApproverOutcome. 
        /// <para>
        /// The decision of an approver who is identified by an email address.
        /// </para>
        /// </summary>
        public EmailApproverOutcome EmailApproverOutcome { get; set; }

        /// <summary>
        /// Checks to see if the EmailApproverOutcome property is set.
        /// </summary>
        internal bool IsSetEmailApproverOutcome() => this.EmailApproverOutcome != null;

        /// <summary>
        /// Gets and sets the property ProcurementToolApproverOutcome. 
        /// <para>
        /// The decision of a procurement system.
        /// </para>
        /// </summary>
        public ProcurementToolApproverOutcome ProcurementToolApproverOutcome { get; set; }

        /// <summary>
        /// Checks to see if the ProcurementToolApproverOutcome property is set.
        /// </summary>
        internal bool IsSetProcurementToolApproverOutcome() => this.ProcurementToolApproverOutcome != null;
    }
}
