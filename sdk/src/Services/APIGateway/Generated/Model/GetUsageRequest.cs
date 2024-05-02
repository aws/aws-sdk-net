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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
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
    /// Container for the parameters to the GetUsage operation.
    /// Gets the usage data of a usage plan in a specified time interval.
    /// </summary>
    public partial class GetUsageRequest : AmazonAPIGatewayRequest
    {
        private string _endDate;
        private string _keyId;
        private int? _limit;
        private string _position;
        private string _startDate;
        private string _usagePlanId;

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The ending date (e.g., 2016-12-31) of the usage data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property KeyId. 
        /// <para>
        /// The Id of the API key associated with the resultant usage data.
        /// </para>
        /// </summary>
        public string KeyId
        {
            get { return this._keyId; }
            set { this._keyId = value; }
        }

        // Check to see if KeyId property is set
        internal bool IsSetKeyId()
        {
            return this._keyId != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of returned results per page. The default value is 25 and the maximum
        /// value is 500.
        /// </para>
        /// </summary>
        public int? Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Position. 
        /// <para>
        /// The current pagination position in the paged result set.
        /// </para>
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
        /// The starting date (e.g., 2016-01-01) of the usage data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The Id of the usage plan associated with the usage data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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