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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the GetCostEstimate operation.
    /// Retrieves information about the cost estimate for a specified resource. A cost estimate
    /// will not generate for a resource that has been deleted.
    /// </summary>
    public partial class GetCostEstimateRequest : AmazonLightsailRequest
    {
        private DateTime? _endTime;
        private string _resourceName;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The cost estimate end time.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specified in Coordinated Universal Time (UTC).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specified in the Unix time format.
        /// </para>
        ///  
        /// <para>
        /// For example, if you wish to use an end time of October 1, 2018, at 9 PM UTC, specify
        /// <code>1538427600</code> as the end time.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can convert a human-friendly time to Unix time format using a converter like <a
        /// href="https://www.epochconverter.com/">Epoch converter</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The resource name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceName
        {
            get { return this._resourceName; }
            set { this._resourceName = value; }
        }

        // Check to see if ResourceName property is set
        internal bool IsSetResourceName()
        {
            return this._resourceName != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The cost estimate start time.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specified in Coordinated Universal Time (UTC).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specified in the Unix time format.
        /// </para>
        ///  
        /// <para>
        /// For example, if you wish to use a start time of October 1, 2018, at 8 PM UTC, specify
        /// <code>1538424000</code> as the start time.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can convert a human-friendly time to Unix time format using a converter like <a
        /// href="https://www.epochconverter.com/">Epoch converter</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}