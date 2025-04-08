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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Container for the parameters to the StartCostAllocationTagBackfill operation.
    /// Request a cost allocation tag backfill. This will backfill the activation status
    /// (either <c>active</c> or <c>inactive</c>) for all tag keys from <c>para:BackfillFrom</c>
    /// up to the time this request is made.
    /// 
    ///  
    /// <para>
    /// You can request a backfill once every 24 hours. 
    /// </para>
    /// </summary>
    public partial class StartCostAllocationTagBackfillRequest : AmazonCostExplorerRequest
    {
        private string _backfillFrom;

        /// <summary>
        /// Gets and sets the property BackfillFrom. 
        /// <para>
        ///  The date you want the backfill to start from. The date can only be a first day of
        /// the month (a billing start date). Dates can't precede the previous twelve months,
        /// or in the future.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=25)]
        public string BackfillFrom
        {
            get { return this._backfillFrom; }
            set { this._backfillFrom = value; }
        }

        // Check to see if BackfillFrom property is set
        internal bool IsSetBackfillFrom()
        {
            return this._backfillFrom != null;
        }

    }
}