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
    /// This is the response object from the GetSolutionMetrics operation.
    /// </summary>
    public partial class GetSolutionMetricsResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, double> _metrics = AWSConfigs.InitializeCollections ? new Dictionary<string, double>() : null;
        private string _solutionVersionArn;

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// The metrics for the solution version. For more information, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/working-with-training-metrics.html">
        /// Evaluating a solution version with metrics </a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=100)]
        public Dictionary<string, double> Metrics
        {
            get { return this._metrics; }
            set { this._metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this._metrics != null && (this._metrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SolutionVersionArn. 
        /// <para>
        /// The same solution version ARN as specified in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string SolutionVersionArn
        {
            get { return this._solutionVersionArn; }
            set { this._solutionVersionArn = value; }
        }

        // Check to see if SolutionVersionArn property is set
        internal bool IsSetSolutionVersionArn()
        {
            return this._solutionVersionArn != null;
        }

    }
}