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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Resource sharing configuration.
    /// </summary>
    public partial class ResourceSharingConfig
    {
        private int? _borrowLimit;
        private ResourceSharingStrategy _strategy;

        /// <summary>
        /// Gets and sets the property BorrowLimit. 
        /// <para>
        /// The limit on how much idle compute can be borrowed.The values can be 1 - 500 percent
        /// of idle compute that the team is allowed to borrow.
        /// </para>
        ///  
        /// <para>
        /// Default is <c>50</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public int? BorrowLimit
        {
            get { return this._borrowLimit; }
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
        /// The strategy of how idle compute is shared within the cluster. The following are the
        /// options of strategies.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DontLend</c>: entities do not lend idle compute.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Lend</c>: entities can lend idle compute to entities that can borrow.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LendandBorrow</c>: entities can lend idle compute and borrow idle compute from
        /// other entities.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default is <c>LendandBorrow</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceSharingStrategy Strategy
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