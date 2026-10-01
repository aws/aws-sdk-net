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

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Container for the parameters to the ListSuppressedDestinations operation. Retrieves
    /// a list of email addresses that are on the suppression list for your account or for
    /// a specific tenant. To target a tenant's suppression list, specify the <c>TenantName</c>
    /// parameter. If you omit <c>TenantName</c>, the operation targets the account-level
    /// suppression list.
    /// </summary>
    public partial class ListSuppressedDestinationsRequest : AmazonSimpleEmailServiceV2Request
    {
        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// Used to filter the list of suppressed email destinations so that it only includes
        /// addresses that were added to the list before a specific date.
        /// </para>
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Checks to see if the EndDate property is set.
        /// </summary>
        internal bool IsSetEndDate() => this.EndDate.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token returned from a previous call to <c>ListSuppressedDestinations</c> to indicate
        /// the position in the list of suppressed email addresses.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PageSize. 
        /// <para>
        /// The number of results to show in a single call to <c>ListSuppressedDestinations</c>.
        /// If the number of results is larger than the number you specified in this parameter,
        /// then the response includes a <c>NextToken</c> element, which you can use to obtain
        /// additional results.
        /// </para>
        /// </summary>
        public int? PageSize { get; set; }

        /// <summary>
        /// Checks to see if the PageSize property is set.
        /// </summary>
        internal bool IsSetPageSize() => this.PageSize.HasValue;

        /// <summary>
        /// Gets and sets the property Reasons. 
        /// <para>
        /// The factors that caused the email address to be added to the suppression list for
        /// your account or for a specific tenant.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Reasons { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Reasons property is set.
        /// </summary>
        internal bool IsSetReasons() => this.Reasons != null && (this.Reasons.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// Used to filter the list of suppressed email destinations so that it only includes
        /// addresses that were added to the list after a specific date.
        /// </para>
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Checks to see if the StartDate property is set.
        /// </summary>
        internal bool IsSetStartDate() => this.StartDate.HasValue;

        /// <summary>
        /// Gets and sets the property TenantName. 
        /// <para>
        /// The name of the tenant whose suppression list you want to retrieve. If you omit this
        /// parameter, the operation targets the account-level suppression list.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string TenantName { get; set; }

        /// <summary>
        /// Checks to see if the TenantName property is set.
        /// </summary>
        internal bool IsSetTenantName() => this.TenantName != null;
    }
}
