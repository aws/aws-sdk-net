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
 * Do not modify this file. This file is generated from the synthetics-2017-10-11.normal.json service model.
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
namespace Amazon.Synthetics.Model
{
    /// <summary>
    /// Container for the parameters to the GetCanaryRuns operation.
    /// Retrieves a list of runs for a specified canary.
    /// </summary>
    public partial class GetCanaryRunsRequest : AmazonSyntheticsRequest
    {
        private string _dryRunId;
        private int? _maxResults;
        private string _name;
        private string _nextToken;
        private RunType _runType;

        /// <summary>
        /// Gets and sets the property DryRunId. 
        /// <para>
        /// The DryRunId associated with an existing canary’s dry run. You can use this DryRunId
        /// to retrieve information about the dry run.
        /// </para>
        /// </summary>
        public string DryRunId
        {
            get { return this._dryRunId; }
            set { this._dryRunId = value; }
        }

        // Check to see if DryRunId property is set
        internal bool IsSetDryRunId()
        {
            return this._dryRunId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Specify this parameter to limit how many runs are returned each time you use the <c>GetCanaryRuns</c>
        /// operation. If you omit this parameter, the default of 100 is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the canary that you want to see runs for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates that there is more data available. You can use this token in
        /// a subsequent <c>GetCanaryRuns</c> operation to retrieve the next set of results.
        /// </para>
        ///  <note> 
        /// <para>
        /// When auto retry is enabled for the canary, the first subsequent retry is suffixed
        /// with *1 indicating its the first retry and the next subsequent try is suffixed with
        /// *2.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=4, Max=252)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property RunType. <ul> <li> 
        /// <para>
        /// When you provide <c>RunType=CANARY_RUN</c> and <c>dryRunId</c>, you will get an exception
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When a value is not provided for <c>RunType</c>, the default value is <c>CANARY_RUN</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When <c>CANARY_RUN</c> is provided, all canary runs excluding dry runs are returned
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When <c>DRY_RUN</c> is provided, all dry runs excluding canary runs are returned
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public RunType RunType
        {
            get { return this._runType; }
            set { this._runType = value; }
        }

        // Check to see if RunType property is set
        internal bool IsSetRunType()
        {
            return this._runType != null;
        }

    }
}