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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
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
namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// Container for the parameters to the ListInferenceEvents operation.
    /// Lists all inference events that have been found for the specified inference scheduler.
    /// </summary>
    public partial class ListInferenceEventsRequest : AmazonLookoutEquipmentRequest
    {
        private string _inferenceSchedulerName;
        private DateTime? _intervalEndTime;
        private DateTime? _intervalStartTime;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property InferenceSchedulerName. 
        /// <para>
        /// The name of the inference scheduler for the inference events listed. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string InferenceSchedulerName
        {
            get { return this._inferenceSchedulerName; }
            set { this._inferenceSchedulerName = value; }
        }

        // Check to see if InferenceSchedulerName property is set
        internal bool IsSetInferenceSchedulerName()
        {
            return this._inferenceSchedulerName != null;
        }

        /// <summary>
        /// Gets and sets the property IntervalEndTime. 
        /// <para>
        /// Returns all the inference events with an end start time equal to or greater than less
        /// than the end time given.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? IntervalEndTime
        {
            get { return this._intervalEndTime; }
            set { this._intervalEndTime = value; }
        }

        // Check to see if IntervalEndTime property is set
        internal bool IsSetIntervalEndTime()
        {
            return this._intervalEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IntervalStartTime. 
        /// <para>
        ///  Lookout for Equipment will return all the inference events with an end time equal
        /// to or greater than the start time given.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? IntervalStartTime
        {
            get { return this._intervalStartTime; }
            set { this._intervalStartTime = value; }
        }

        // Check to see if IntervalStartTime property is set
        internal bool IsSetIntervalStartTime()
        {
            return this._intervalStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Specifies the maximum number of inference events to list. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An opaque pagination token indicating where to continue the listing of inference events.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8192)]
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

    }
}