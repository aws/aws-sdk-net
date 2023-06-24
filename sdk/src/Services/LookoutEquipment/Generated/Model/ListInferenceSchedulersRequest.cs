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

namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// Container for the parameters to the ListInferenceSchedulers operation.
    /// Retrieves a list of all inference schedulers currently available for your account.
    /// </summary>
    public partial class ListInferenceSchedulersRequest : AmazonLookoutEquipmentRequest
    {
        private string _inferenceSchedulerNameBeginsWith;
        private int? _maxResults;
        private string _modelName;
        private string _nextToken;
        private InferenceSchedulerStatus _status;

        /// <summary>
        /// Gets and sets the property InferenceSchedulerNameBeginsWith. 
        /// <para>
        /// The beginning of the name of the inference schedulers to be listed. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string InferenceSchedulerNameBeginsWith
        {
            get { return this._inferenceSchedulerNameBeginsWith; }
            set { this._inferenceSchedulerNameBeginsWith = value; }
        }

        // Check to see if InferenceSchedulerNameBeginsWith property is set
        internal bool IsSetInferenceSchedulerNameBeginsWith()
        {
            return this._inferenceSchedulerNameBeginsWith != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  Specifies the maximum number of inference schedulers to list. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the ML model used by the inference scheduler to be listed. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string ModelName
        {
            get { return this._modelName; }
            set { this._modelName = value; }
        }

        // Check to see if ModelName property is set
        internal bool IsSetModelName()
        {
            return this._modelName != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  An opaque pagination token indicating where to continue the listing of inference
        /// schedulers. 
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
        /// Specifies the current status of the inference schedulers to list.
        /// </para>
        /// </summary>
        public InferenceSchedulerStatus Status
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