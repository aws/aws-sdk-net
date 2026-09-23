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

namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// Container for the parameters to the ListServiceStates operation. Returns information
    /// about the last deployment and other change states of services. This API provides visibility
    /// into recent changes that may have affected service performance, helping with troubleshooting
    /// and change correlation.
    /// </summary>
    public partial class ListServiceStatesRequest : AmazonApplicationSignalsRequest
    {
        /// <summary>
        /// Gets and sets the property AttributeFilters. 
        /// <para>
        /// A list of attribute filters to narrow down the services. You can filter by platform,
        /// environment, or other service attributes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 20)]
        public List<AttributeFilter> AttributeFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<AttributeFilter>() : null;

        /// <summary>
        /// Checks to see if the AttributeFilters property is set.
        /// </summary>
        internal bool IsSetAttributeFilters() => this.AttributeFilters != null && (this.AttributeFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The Amazon Web Services account ID to filter service states by. Use this to limit
        /// results to services from a specific account.
        /// </para>
        /// </summary>
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end of the time period to retrieve service state information for. When used in
        /// a raw HTTP Query API, it is formatted as epoch time in seconds. For example, <c>1698778057</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeLinkedAccounts. 
        /// <para>
        /// If you are using this operation in a monitoring account, specify <c>true</c> to include
        /// service states from source accounts in the returned data.
        /// </para>
        /// </summary>
        public bool? IncludeLinkedAccounts { get; set; }

        /// <summary>
        /// Checks to see if the IncludeLinkedAccounts property is set.
        /// </summary>
        internal bool IsSetIncludeLinkedAccounts() => this.IncludeLinkedAccounts.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of service states to return in one operation. If you omit this
        /// parameter, the default of 20 is used.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 250)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Include this value, if it was returned by the previous operation, to get the next
        /// set of service states.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start of the time period to retrieve service state information for. When used
        /// in a raw HTTP Query API, it is formatted as epoch time in seconds. For example, <c>1698778057</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}
