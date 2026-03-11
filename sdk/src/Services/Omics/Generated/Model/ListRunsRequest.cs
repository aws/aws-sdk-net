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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
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
namespace Amazon.Omics.Model
{
    /// <summary>
    /// Container for the parameters to the ListRuns operation.
    /// Retrieves a list of runs and returns each run's metadata and status.
    /// 
    ///  
    /// <para>
    /// Amazon Web Services HealthOmics stores a configurable number of runs, as determined
    /// by service limits, that are available to the console and API. If the <c>ListRuns</c>
    /// response doesn't include specific runs that you expected, you can find all run logs
    /// in the CloudWatch logs. For more information about viewing the run logs, see <a href="https://docs.aws.amazon.com/omics/latest/dev/monitoring-cloudwatch-logs.html">CloudWatch
    /// logs</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ListRunsRequest : AmazonOmicsRequest
    {
        private int? _maxResults;
        private string _name;
        private string _runGroupId;
        private string _startingToken;
        private RunStatus _status;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of runs to return in one page of results.
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
        /// Filter the list by run name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property RunGroupId. 
        /// <para>
        /// Filter the list by run group ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=18)]
        public string RunGroupId
        {
            get { return this._runGroupId; }
            set { this._runGroupId = value; }
        }

        // Check to see if RunGroupId property is set
        internal bool IsSetRunGroupId()
        {
            return this._runGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property StartingToken. 
        /// <para>
        /// Specify the pagination token from a previous request to retrieve the next page of
        /// results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string StartingToken
        {
            get { return this._startingToken; }
            set { this._startingToken = value; }
        }

        // Check to see if StartingToken property is set
        internal bool IsSetStartingToken()
        {
            return this._startingToken != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of a run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public RunStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}