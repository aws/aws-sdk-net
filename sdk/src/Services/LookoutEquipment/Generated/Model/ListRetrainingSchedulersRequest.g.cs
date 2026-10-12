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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the ListRetrainingSchedulers operation. Lists all
    /// retraining schedulers in your account, filtering by model name prefix and status.
    /// </summary>
    public partial class ListRetrainingSchedulersRequest : AmazonLookoutEquipmentRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Specifies the maximum number of retraining schedulers to list. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property ModelNameBeginsWith. 
        /// <para>
        /// Specify this field to only list retraining schedulers whose machine learning models
        /// begin with the value you specify. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string ModelNameBeginsWith { get; set; }

        /// <summary>
        /// Checks to see if the ModelNameBeginsWith property is set.
        /// </summary>
        internal bool IsSetModelNameBeginsWith() => this.ModelNameBeginsWith != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the number of results exceeds the maximum, a pagination token is returned. Use
        /// the token in the request to show the next page of retraining schedulers.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Specify this field to only list retraining schedulers whose status matches the value
        /// you specify. 
        /// </para>
        /// </summary>
        public RetrainingSchedulerStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
