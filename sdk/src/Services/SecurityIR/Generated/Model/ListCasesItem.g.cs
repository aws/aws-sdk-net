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

namespace Amazon.SecurityIR.Model
{
    /// <summary>
    /// </summary>
    public partial class ListCasesItem
    {
        /// <summary>
        /// Gets and sets the property CaseArn.
        /// </summary>
        [AWSProperty(Min = 12, Max = 80)]
        public string CaseArn { get; set; }

        /// <summary>
        /// Checks to see if the CaseArn property is set.
        /// </summary>
        internal bool IsSetCaseArn() => this.CaseArn != null;

        /// <summary>
        /// Gets and sets the property CaseId.
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 32)]
        public string CaseId { get; set; }

        /// <summary>
        /// Checks to see if the CaseId property is set.
        /// </summary>
        internal bool IsSetCaseId() => this.CaseId != null;

        /// <summary>
        /// Gets and sets the property CaseStatus.
        /// </summary>
        public CaseStatus CaseStatus { get; set; }

        /// <summary>
        /// Checks to see if the CaseStatus property is set.
        /// </summary>
        internal bool IsSetCaseStatus() => this.CaseStatus != null;

        /// <summary>
        /// Gets and sets the property ClosedDate.
        /// </summary>
        public DateTime? ClosedDate { get; set; }

        /// <summary>
        /// Checks to see if the ClosedDate property is set.
        /// </summary>
        internal bool IsSetClosedDate() => this.ClosedDate.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedDate.
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property EngagementType.
        /// </summary>
        public EngagementType EngagementType { get; set; }

        /// <summary>
        /// Checks to see if the EngagementType property is set.
        /// </summary>
        internal bool IsSetEngagementType() => this.EngagementType != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedDate.
        /// </summary>
        public DateTime? LastUpdatedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDate property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDate() => this.LastUpdatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property PendingAction.
        /// </summary>
        public PendingAction PendingAction { get; set; }

        /// <summary>
        /// Checks to see if the PendingAction property is set.
        /// </summary>
        internal bool IsSetPendingAction() => this.PendingAction != null;

        /// <summary>
        /// Gets and sets the property ResolverType.
        /// </summary>
        public ResolverType ResolverType { get; set; }

        /// <summary>
        /// Checks to see if the ResolverType property is set.
        /// </summary>
        internal bool IsSetResolverType() => this.ResolverType != null;

        /// <summary>
        /// Gets and sets the property Title.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 300)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
