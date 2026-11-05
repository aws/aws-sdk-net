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
    /// Container for the parameters to the GetUsage operation. Gets the usage data of a usage
    /// plan in a specified time interval.
    /// </summary>
    public partial class GetUsageRequest : AmazonAPIGatewayRequest
    {
        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The ending date (e.g., 2016-12-31) of the usage data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EndDate { get; set; }

        /// <summary>
        /// Checks to see if the EndDate property is set.
        /// </summary>
        internal bool IsSetEndDate() => this.EndDate != null;

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// The Id of the API key associated with the resultant usage data.
        /// </para>
        /// </summary>
        public string KeyId { get; set; }

        /// <summary>
        /// Checks to see if the KeyId property is set.
        /// </summary>
        internal bool IsSetKeyId() => this.KeyId != null;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of returned results per page. The default value is 25 and the maximum
        /// value is 500.
        /// </para>
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

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
        /// The starting date (e.g., 2016-01-01) of the usage data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string StartDate { get; set; }

        /// <summary>
        /// Checks to see if the StartDate property is set.
        /// </summary>
        internal bool IsSetStartDate() => this.StartDate != null;

        /// <summary>
        /// Gets and sets the property UsagePlanId. 
        /// <para>
        /// The Id of the usage plan associated with the usage data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string UsagePlanId { get; set; }

        /// <summary>
        /// Checks to see if the UsagePlanId property is set.
        /// </summary>
        internal bool IsSetUsagePlanId() => this.UsagePlanId != null;
    }
}
