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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
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
namespace Amazon.Personalize.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteMetricAttribution operation.
    /// Deletes a metric attribution.
    /// </summary>
    public partial class DeleteMetricAttributionRequest : AmazonPersonalizeRequest
    {
        private string _metricAttributionArn;

        /// <summary>
        /// Gets and sets the property MetricAttributionArn. 
        /// <para>
        /// The metric attribution's Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string MetricAttributionArn
        {
            get { return this._metricAttributionArn; }
            set { this._metricAttributionArn = value; }
        }

        // Check to see if MetricAttributionArn property is set
        internal bool IsSetMetricAttributionArn()
        {
            return this._metricAttributionArn != null;
        }

    }
}