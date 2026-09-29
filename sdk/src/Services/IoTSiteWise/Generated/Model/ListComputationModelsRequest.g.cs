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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Container for the parameters to the ListComputationModels operation. Retrieves a paginated
    /// list of summaries of all computation models.
    /// </summary>
    public partial class ListComputationModelsRequest : AmazonIoTSiteWiseRequest
    {
        /// <summary>
        /// Gets and sets the property ComputationModelType. 
        /// <para>
        /// The type of computation model. If a <c>computationModelType</c> is not provided, all
        /// types of computation models are returned.
        /// </para>
        /// </summary>
        public ComputationModelType ComputationModelType { get; set; }

        /// <summary>
        /// Checks to see if the ComputationModelType property is set.
        /// </summary>
        internal bool IsSetComputationModelType() => this.ComputationModelType != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return for each paginated request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 250)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to be used for the next set of paginated results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
