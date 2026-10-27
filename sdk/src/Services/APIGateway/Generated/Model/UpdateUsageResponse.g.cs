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

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// This is the response object from the UpdateUsage operation.
    /// </summary>
    public partial class UpdateUsageResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The ending date of the usage data.
        /// </para>
        /// </summary>
        public string EndDate { get; set; }

        /// <summary>
        /// Checks to see if the EndDate property is set.
        /// </summary>
        internal bool IsSetEndDate() => this.EndDate != null;

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// The usage data, as daily logs of used and remaining quotas, over the specified time
        /// interval indexed over the API keys in a usage plan. For example, <c>{..., "values"
        /// : { "{api_key}" : [ [0, 100], [10, 90], [100, 10]]}</c>, where <c>{api_key}</c> stands
        /// for an API key value and the daily log entry is of the format <c>[used quota, remaining
        /// quota]</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<List<long>>> Items { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<List<long>>>() : null;

        /// <summary>
        /// Checks to see if the Items property is set.
        /// </summary>
        internal bool IsSetItems() => this.Items != null && (this.Items.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Position. 
        /// <para>
        /// The current pagination position in the paged result set.
        /// </para>
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Checks to see if the Position property is set.
        /// </summary>
        internal bool IsSetPosition() => this.Position != null;

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The starting date of the usage data.
        /// </para>
        /// </summary>
        public string StartDate { get; set; }

        /// <summary>
        /// Checks to see if the StartDate property is set.
        /// </summary>
        internal bool IsSetStartDate() => this.StartDate != null;

        /// <summary>
        /// Gets and sets the property UsagePlanId. 
        /// <para>
        /// The plan Id associated with this usage data.
        /// </para>
        /// </summary>
        public string UsagePlanId { get; set; }

        /// <summary>
        /// Checks to see if the UsagePlanId property is set.
        /// </summary>
        internal bool IsSetUsagePlanId() => this.UsagePlanId != null;
    }
}
