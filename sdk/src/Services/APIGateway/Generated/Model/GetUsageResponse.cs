/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Represents the usage data of a usage plan.
    /// 
    ///  <div class="remarks"/> <div class="seeAlso"> <a href="[[AwsDocsUrlPrefix]]/apigateway/latest/developerguide/api-gateway-api-usage-plans.html">Create
    /// and Use Usage Plans</a>, <a href="[[AwsDocsUrlPrefix]]/apigateway/latest/developerguide/api-gateway-create-usage-plans-with-console.html#api-gateway-usage-plan-manage-usage">Manage
    /// Usage in a Usage Plan</a> </div>
    /// </summary>
    public partial class GetUsageResponse : AmazonWebServiceResponse
    {
        private string _endDate;
        private Dictionary<string, List<List<long>>> _items = new Dictionary<string, List<List<long>>>();
        private string _position;
        private string _startDate;
        private string _usagePlanId;

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The ending date of the usage data.
        /// </para>
        /// </summary>
        public string EndDate
        {
            get { return this._endDate; }
            set { this._endDate = value; }
        }

        // Check to see if EndDate property is set
        internal bool IsSetEndDate()
        {
            return this._endDate != null;
        }

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// The usage data, as daily logs of used and remaining quotas, over the specified time
        /// interval indexed over the API keys in a usage plan. For example, <code>{..., "values"
        /// : { "{api_key}" : [ [0, 100], [10, 90], [100, 10]]}</code>, where <code>{api_key}</code>
        /// stands for an API key value and the daily log entry is of the format <code>[used quota,
        /// remaining quota]</code>.
        /// </para>
        /// </summary>
        public Dictionary<string, List<List<long>>> Items
        {
            get { return this._items; }
            set { this._items = value; }
        }

        // Check to see if Items property is set
        internal bool IsSetItems()
        {
            return this._items != null && this._items.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Position.
        /// </summary>
        public string Position
        {
            get { return this._position; }
            set { this._position = value; }
        }

        // Check to see if Position property is set
        internal bool IsSetPosition()
        {
            return this._position != null;
        }

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The starting date of the usage data.
        /// </para>
        /// </summary>
        public string StartDate
        {
            get { return this._startDate; }
            set { this._startDate = value; }
        }

        // Check to see if StartDate property is set
        internal bool IsSetStartDate()
        {
            return this._startDate != null;
        }

        /// <summary>
        /// Gets and sets the property UsagePlanId. 
        /// <para>
        /// The plan Id associated with this usage data.
        /// </para>
        /// </summary>
        public string UsagePlanId
        {
            get { return this._usagePlanId; }
            set { this._usagePlanId = value; }
        }

        // Check to see if UsagePlanId property is set
        internal bool IsSetUsagePlanId()
        {
            return this._usagePlanId != null;
        }

    }
}