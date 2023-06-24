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
 * Do not modify this file. This file is generated from the rum-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchRUM.Model
{
    /// <summary>
    /// This is the response object from the BatchCreateRumMetricDefinitions operation.
    /// </summary>
    public partial class BatchCreateRumMetricDefinitionsResponse : AmazonWebServiceResponse
    {
        private List<BatchCreateRumMetricDefinitionsError> _errors = new List<BatchCreateRumMetricDefinitionsError>();
        private List<MetricDefinition> _metricDefinitions = new List<MetricDefinition>();

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// An array of error objects, if the operation caused any errors.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BatchCreateRumMetricDefinitionsError> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && this._errors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MetricDefinitions. 
        /// <para>
        /// An array of structures that define the extended metrics.
        /// </para>
        /// </summary>
        public List<MetricDefinition> MetricDefinitions
        {
            get { return this._metricDefinitions; }
            set { this._metricDefinitions = value; }
        }

        // Check to see if MetricDefinitions property is set
        internal bool IsSetMetricDefinitions()
        {
            return this._metricDefinitions != null && this._metricDefinitions.Count > 0; 
        }

    }
}