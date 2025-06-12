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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudWatchRUM.Model
{
    /// <summary>
    /// This is the response object from the BatchDeleteRumMetricDefinitions operation.
    /// </summary>
    public partial class BatchDeleteRumMetricDefinitionsResponse : AmazonWebServiceResponse
    {
        private List<BatchDeleteRumMetricDefinitionsError> _errors = AWSConfigs.InitializeCollections ? new List<BatchDeleteRumMetricDefinitionsError>() : null;
        private List<string> _metricDefinitionIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// An array of error objects, if the operation caused any errors.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BatchDeleteRumMetricDefinitionsError> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && (this._errors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MetricDefinitionIds. 
        /// <para>
        /// The IDs of the metric definitions that were deleted.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> MetricDefinitionIds
        {
            get { return this._metricDefinitionIds; }
            set { this._metricDefinitionIds = value; }
        }

        // Check to see if MetricDefinitionIds property is set
        internal bool IsSetMetricDefinitionIds()
        {
            return this._metricDefinitionIds != null && (this._metricDefinitionIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}