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
 * Do not modify this file. This file is generated from the autoscaling-plans-2018-01-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScalingPlans.Model
{
    /// <summary>
    /// This is the response object from the GetScalingPlanResourceForecastData operation.
    /// </summary>
    public partial class GetScalingPlanResourceForecastDataResponse : AmazonWebServiceResponse
    {
        private List<Datapoint> _datapoints = new List<Datapoint>();

        /// <summary>
        /// Gets and sets the property Datapoints. 
        /// <para>
        /// The data points to return.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Datapoint> Datapoints
        {
            get { return this._datapoints; }
            set { this._datapoints = value; }
        }

        // Check to see if Datapoints property is set
        internal bool IsSetDatapoints()
        {
            return this._datapoints != null && this._datapoints.Count > 0; 
        }

    }
}