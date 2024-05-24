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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
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
namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// A JSON string that contains a list of Insights types that are logged on a trail or
    /// event data store.
    /// </summary>
    public partial class InsightSelector
    {
        private InsightType _insightType;

        /// <summary>
        /// Gets and sets the property InsightType. 
        /// <para>
        /// The type of Insights events to log on a trail or event data store. <c>ApiCallRateInsight</c>
        /// and <c>ApiErrorRateInsight</c> are valid Insight types.
        /// </para>
        ///  
        /// <para>
        /// The <c>ApiCallRateInsight</c> Insights type analyzes write-only management API calls
        /// that are aggregated per minute against a baseline API call volume.
        /// </para>
        ///  
        /// <para>
        /// The <c>ApiErrorRateInsight</c> Insights type analyzes management API calls that result
        /// in error codes. The error is shown if the API call is unsuccessful.
        /// </para>
        /// </summary>
        public InsightType InsightType
        {
            get { return this._insightType; }
            set { this._insightType = value; }
        }

        // Check to see if InsightType property is set
        internal bool IsSetInsightType()
        {
            return this._insightType != null;
        }

    }
}