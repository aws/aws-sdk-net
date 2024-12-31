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
 * Do not modify this file. This file is generated from the timestream-query-2018-11-01.normal.json service model.
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
namespace Amazon.TimestreamQuery.Model
{
    /// <summary>
    /// This is the response object from the UpdateAccountSettings operation.
    /// </summary>
    public partial class UpdateAccountSettingsResponse : AmazonWebServiceResponse
    {
        private int? _maxQueryTCU;
        private QueryComputeResponse _queryCompute;
        private QueryPricingModel _queryPricingModel;

        /// <summary>
        /// Gets and sets the property MaxQueryTCU. 
        /// <para>
        /// The configured maximum number of compute units the service will use at any point in
        /// time to serve your queries.
        /// </para>
        /// </summary>
        public int? MaxQueryTCU
        {
            get { return this._maxQueryTCU; }
            set { this._maxQueryTCU = value; }
        }

        // Check to see if MaxQueryTCU property is set
        internal bool IsSetMaxQueryTCU()
        {
            return this._maxQueryTCU.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueryCompute. 
        /// <para>
        /// Confirms the updated account settings for querying data in your account.
        /// </para>
        /// </summary>
        public QueryComputeResponse QueryCompute
        {
            get { return this._queryCompute; }
            set { this._queryCompute = value; }
        }

        // Check to see if QueryCompute property is set
        internal bool IsSetQueryCompute()
        {
            return this._queryCompute != null;
        }

        /// <summary>
        /// Gets and sets the property QueryPricingModel. 
        /// <para>
        /// The pricing model for an account.
        /// </para>
        /// </summary>
        public QueryPricingModel QueryPricingModel
        {
            get { return this._queryPricingModel; }
            set { this._queryPricingModel = value; }
        }

        // Check to see if QueryPricingModel property is set
        internal bool IsSetQueryPricingModel()
        {
            return this._queryPricingModel != null;
        }

    }
}