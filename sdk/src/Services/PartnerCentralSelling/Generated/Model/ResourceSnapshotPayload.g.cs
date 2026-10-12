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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Represents the payload of a resource snapshot. This structure is designed to accommodate
    /// different types of resource snapshots, currently supporting opportunity summaries.
    /// </summary>
    public partial class ResourceSnapshotPayload
    {
        /// <summary>
        /// Gets and sets the property AwsOpportunitySummaryFullView. 
        /// <para>
        /// Provides a comprehensive view of AwsOpportunitySummaryFullView template.
        /// </para>
        /// </summary>
        public AwsOpportunitySummaryFullView AwsOpportunitySummaryFullView { get; set; }

        /// <summary>
        /// Checks to see if the AwsOpportunitySummaryFullView property is set.
        /// </summary>
        internal bool IsSetAwsOpportunitySummaryFullView() => this.AwsOpportunitySummaryFullView != null;

        /// <summary>
        /// Gets and sets the property OpportunitySummary. 
        /// <para>
        ///  An object that contains an <c>opportunity</c>'s subset of fields. 
        /// </para>
        /// </summary>
        public OpportunitySummaryView OpportunitySummary { get; set; }

        /// <summary>
        /// Checks to see if the OpportunitySummary property is set.
        /// </summary>
        internal bool IsSetOpportunitySummary() => this.OpportunitySummary != null;
    }
}
