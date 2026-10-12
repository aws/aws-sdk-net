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
    /// Defines sorting options for retrieving Engagement Invitations. Sorting can be done
    /// based on various criteria like the invitation date or status.
    /// </summary>
    public partial class OpportunityEngagementInvitationSort
    {
        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// Specifies the field by which the Engagement Invitations are sorted. Common values
        /// include <c>InvitationDate</c> and <c>Status</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OpportunityEngagementInvitationSortName SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// Defines the order in which the Engagement Invitations are sorted. The values can be
        /// <c>ASC</c> (ascending) or <c>DESC</c> (descending).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;
    }
}
