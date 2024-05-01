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
    /// Container for the parameters to the ListInferenceExecutions operation.
    /// Lists all inference executions that have been performed by the specified inference
    /// scheduler.
    /// </summary>
    public partial class ListInferenceExecutionsRequest : AmazonLookoutEquipmentRequest
    {
        private DateTime? _dataEndTimeBefore;
        private DateTime? _dataStartTimeAfter;
        private string _inferenceSchedulerName;
        private int? _maxResults;
        private string _nextToken;
        private InferenceExecutionStatus _status;

        /// <summary>
        /// Gets and sets the property DataEndTimeBefore. 
        /// <para>
        /// The time reference in the inferenced dataset before which Amazon Lookout for Equipment
        /// stopped the inference execution. 
        /// </para>
        /// </summary>
        public DateTime? DataEndTimeBefore
        {
            get { return this._dataEndTimeBefore; }
            set { this._dataEndTimeBefore = value; }
        }

        // Check to see if DataEndTimeBefore property is set
        internal bool IsSetDataEndTimeBefore()
        {
            return this._dataEndTimeBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataStartTimeAfter. 
        /// <para>
        /// The time reference in the inferenced dataset after which Amazon Lookout for Equipment
        /// started the inference execution. 
        /// </para>
        /// </summary>
        public DateTime? DataStartTimeAfter
        {
            get { return this._dataStartTimeAfter; }
            set { this._dataStartTimeAfter = value; }
        }

        // Check to see if DataStartTimeAfter property is set
        internal bool IsSetDataStartTimeAfter()
        {
            return this._dataStartTimeAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InferenceSchedulerName. 
        /// <para>
        /// The name of the inference scheduler for the inference execution listed. 
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Specifies the maximum number of inference executions to list. 
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
        /// An opaque pagination token indicating where to continue the listing of inference executions.
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the inference execution. 
        /// </para>
        /// </summary>
        public InferenceExecutionStatus Status
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