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
    /// Container for the parameters to the ListRetrainingSchedulers operation.
    /// Lists all retraining schedulers in your account, filtering by model name prefix and
    /// status.
    /// </summary>
    public partial class ListRetrainingSchedulersRequest : AmazonLookoutEquipmentRequest
    {
        private int? _maxResults;
        private string _modelNameBeginsWith;
        private string _nextToken;
        private RetrainingSchedulerStatus _status;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Specifies the maximum number of retraining schedulers to list. 
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
        /// Gets and sets the property ModelNameBeginsWith. 
        /// <para>
        /// Specify this field to only list retraining schedulers whose machine learning models
        /// begin with the value you specify. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string ModelNameBeginsWith
        {
            get { return this._modelNameBeginsWith; }
            set { this._modelNameBeginsWith = value; }
        }

        // Check to see if ModelNameBeginsWith property is set
        internal bool IsSetModelNameBeginsWith()
        {
            return this._modelNameBeginsWith != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the number of results exceeds the maximum, a pagination token is returned. Use
        /// the token in the request to show the next page of retraining schedulers.
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
        /// Specify this field to only list retraining schedulers whose status matches the value
        /// you specify. 
        /// </para>
        /// </summary>
        public RetrainingSchedulerStatus Status
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