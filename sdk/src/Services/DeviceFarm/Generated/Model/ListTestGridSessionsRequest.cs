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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
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
namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Container for the parameters to the ListTestGridSessions operation.
    /// Retrieves a list of sessions for a <a>TestGridProject</a>.
    /// </summary>
    public partial class ListTestGridSessionsRequest : AmazonDeviceFarmRequest
    {
        private DateTime? _creationTimeAfter;
        private DateTime? _creationTimeBefore;
        private DateTime? _endTimeAfter;
        private DateTime? _endTimeBefore;
        private int? _maxResult;
        private string _nextToken;
        private string _projectArn;
        private TestGridSessionStatus _status;

        /// <summary>
        /// Gets and sets the property CreationTimeAfter. 
        /// <para>
        /// Return only sessions created after this time.
        /// </para>
        /// </summary>
        public DateTime? CreationTimeAfter
        {
            get { return this._creationTimeAfter; }
            set { this._creationTimeAfter = value; }
        }

        // Check to see if CreationTimeAfter property is set
        internal bool IsSetCreationTimeAfter()
        {
            return this._creationTimeAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreationTimeBefore. 
        /// <para>
        /// Return only sessions created before this time.
        /// </para>
        /// </summary>
        public DateTime? CreationTimeBefore
        {
            get { return this._creationTimeBefore; }
            set { this._creationTimeBefore = value; }
        }

        // Check to see if CreationTimeBefore property is set
        internal bool IsSetCreationTimeBefore()
        {
            return this._creationTimeBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTimeAfter. 
        /// <para>
        /// Return only sessions that ended after this time.
        /// </para>
        /// </summary>
        public DateTime? EndTimeAfter
        {
            get { return this._endTimeAfter; }
            set { this._endTimeAfter = value; }
        }

        // Check to see if EndTimeAfter property is set
        internal bool IsSetEndTimeAfter()
        {
            return this._endTimeAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTimeBefore. 
        /// <para>
        /// Return only sessions that ended before this time.
        /// </para>
        /// </summary>
        public DateTime? EndTimeBefore
        {
            get { return this._endTimeBefore; }
            set { this._endTimeBefore = value; }
        }

        // Check to see if EndTimeBefore property is set
        internal bool IsSetEndTimeBefore()
        {
            return this._endTimeBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResult. 
        /// <para>
        /// Return only this many results at a time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? MaxResult
        {
            get { return this._maxResult; }
            set { this._maxResult = value; }
        }

        // Check to see if MaxResult property is set
        internal bool IsSetMaxResult()
        {
            return this._maxResult.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Pagination token.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=1024)]
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
        /// Gets and sets the property ProjectArn. 
        /// <para>
        /// ARN of a <a>TestGridProject</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=32, Max=1011)]
        public string ProjectArn
        {
            get { return this._projectArn; }
            set { this._projectArn = value; }
        }

        // Check to see if ProjectArn property is set
        internal bool IsSetProjectArn()
        {
            return this._projectArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Return only sessions in this state.
        /// </para>
        /// </summary>
        public TestGridSessionStatus Status
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