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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
namespace Amazon.Batch.Model
{
    /// <summary>
    /// Specifies whether a quota share reserves, lends, or both lends and borrows idle compute
    /// capacity.
    /// </summary>
    public partial class QuotaShareResourceSharingConfiguration
    {
        private int? _borrowLimit;
        private QuotaShareResourceSharingStrategy _strategy;

        /// <summary>
        /// Gets and sets the property BorrowLimit. 
        /// <para>
        /// The maximum percentage of additional capacity that the quota share can borrow from
        /// other shares. <c>borrowLimit</c> can only be applied to quota shares with a strategy
        /// of <c>LEND_AND_BORROW</c>. This value is expressed as a percentage of the quota share's
        /// configured <a href="https://docs.aws.amazon.com/batch/latest/APIReference/API_QuotaShareCapacityLimit.html">CapacityLimits</a>.
        /// </para>
        ///  
        /// <para>
        /// The <c>borrowLimit</c> is applied uniformly across all capacity units. For example,
        /// if the <c>borrowLimit</c> is 200, the quota share can borrow up to 200% of its configured
        /// <c>maxCapacity</c> for each capacity unit. The default <c>borrowLimit</c> is -1, which
        /// indicates unlimited borrowing.
        /// </para>
        /// </summary>
        public int BorrowLimit
        {
            get { return this._borrowLimit.GetValueOrDefault(); }
            set { this._borrowLimit = value; }
        }

        // Check to see if BorrowLimit property is set
        internal bool IsSetBorrowLimit()
        {
            return this._borrowLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Strategy. 
        /// <para>
        /// The resource sharing strategy for the quota share. The <c>RESERVE</c> strategy allows
        /// a quota share to reserve idle capacity for itself. <c>LEND</c> configures the share
        /// to lend its idle capacity to another share in need of capacity. The <c>LEND_AND_BORROW</c>
        /// strategy configures the share to borrow idle capacity from an underutilized share,
        /// as well as lend to another share.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public QuotaShareResourceSharingStrategy Strategy
        {
            get { return this._strategy; }
            set { this._strategy = value; }
        }

        // Check to see if Strategy property is set
        internal bool IsSetStrategy()
        {
            return this._strategy != null;
        }

    }
}