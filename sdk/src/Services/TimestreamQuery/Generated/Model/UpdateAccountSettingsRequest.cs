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
    /// Container for the parameters to the UpdateAccountSettings operation.
    /// Transitions your account to use TCUs for query pricing and modifies the maximum query
    /// compute units that you've configured. If you reduce the value of <c>MaxQueryTCU</c>
    /// to a desired configuration, the new value can take up to 24 hours to be effective.
    /// 
    ///  <note> 
    /// <para>
    /// After you've transitioned your account to use TCUs for query pricing, you can't transition
    /// to using bytes scanned for query pricing.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateAccountSettingsRequest : AmazonTimestreamQueryRequest
    {
        private int? _maxQueryTCU;
        private QueryComputeRequest _queryCompute;
        private QueryPricingModel _queryPricingModel;

        /// <summary>
        /// Gets and sets the property MaxQueryTCU. 
        /// <para>
        /// The maximum number of compute units the service will use at any point in time to serve
        /// your queries. To run queries, you must set a minimum capacity of 4 TCU. You can set
        /// the maximum number of TCU in multiples of 4, for example, 4, 8, 16, 32, and so on.
        /// The maximum value supported for <c>MaxQueryTCU</c> is 1000. To request an increase
        /// to this soft limit, contact Amazon Web Services Support. For information about the
        /// default quota for maxQueryTCU, see Default quotas. This configuration is applicable
        /// only for on-demand usage of Timestream Compute Units (TCUs).
        /// </para>
        ///  
        /// <para>
        /// The maximum value supported for <c>MaxQueryTCU</c> is 1000. To request an increase
        /// to this soft limit, contact Amazon Web Services Support. For information about the
        /// default quota for <c>maxQueryTCU</c>, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html#limits.default">Default
        /// quotas</a>.
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
        /// Modifies the query compute settings configured in your account, including the query
        /// pricing model and provisioned Timestream Compute Units (TCUs) in your account.
        /// </para>
        ///  <note> 
        /// <para>
        /// This API is idempotent, meaning that making the same request multiple times will have
        /// the same effect as making the request once.
        /// </para>
        ///  </note>
        /// </summary>
        public QueryComputeRequest QueryCompute
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
        /// The pricing model for queries in an account.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>QueryPricingModel</c> parameter is used by several Timestream operations; however,
        /// the <c>UpdateAccountSettings</c> API operation doesn't recognize any values other
        /// than <c>COMPUTE_UNITS</c>.
        /// </para>
        ///  </note>
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