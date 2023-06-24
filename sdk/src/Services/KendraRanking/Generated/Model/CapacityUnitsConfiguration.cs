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
 * Do not modify this file. This file is generated from the kendra-ranking-2022-10-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KendraRanking.Model
{
    /// <summary>
    /// Sets additional capacity units configured for your rescore execution plan. A rescore
    /// execution plan is an Amazon Kendra Intelligent Ranking resource used for provisioning
    /// the <code>Rescore</code> API. You can add and remove capacity units to fit your usage
    /// requirements.
    /// </summary>
    public partial class CapacityUnitsConfiguration
    {
        private int? _rescoreCapacityUnits;

        /// <summary>
        /// Gets and sets the property RescoreCapacityUnits. 
        /// <para>
        /// The amount of extra capacity for your rescore execution plan.
        /// </para>
        ///  
        /// <para>
        /// A single extra capacity unit for a rescore execution plan provides 0.01 rescore requests
        /// per second. You can add up to 1000 extra capacity units.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int RescoreCapacityUnits
        {
            get { return this._rescoreCapacityUnits.GetValueOrDefault(); }
            set { this._rescoreCapacityUnits = value; }
        }

        // Check to see if RescoreCapacityUnits property is set
        internal bool IsSetRescoreCapacityUnits()
        {
            return this._rescoreCapacityUnits.HasValue; 
        }

    }
}