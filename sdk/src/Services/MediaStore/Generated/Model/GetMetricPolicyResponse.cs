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
 * Do not modify this file. This file is generated from the mediastore-2017-09-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaStore.Model
{
    /// <summary>
    /// This is the response object from the GetMetricPolicy operation.
    /// </summary>
    public partial class GetMetricPolicyResponse : AmazonWebServiceResponse
    {
        private MetricPolicy _metricPolicy;

        /// <summary>
        /// Gets and sets the property MetricPolicy. 
        /// <para>
        /// The metric policy that is associated with the specific container.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MetricPolicy MetricPolicy
        {
            get { return this._metricPolicy; }
            set { this._metricPolicy = value; }
        }

        // Check to see if MetricPolicy property is set
        internal bool IsSetMetricPolicy()
        {
            return this._metricPolicy != null;
        }

    }
}