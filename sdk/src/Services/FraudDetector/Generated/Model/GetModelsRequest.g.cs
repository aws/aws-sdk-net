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

namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// Container for the parameters to the GetModels operation. Gets one or more models.
    /// Gets all models for the Amazon Web Services account if no model type and no model
    /// id provided. Gets all models for the Amazon Web Services account and model type, if
    /// the model type is specified but model id is not provided. Gets a specific model if
    /// (model type, model id) tuple is specified. <para> This is a paginated API. If you
    /// provide a null <c>maxResults</c>, this action retrieves a maximum of 10 records per
    /// page. If you provide a <c>maxResults</c>, the value must be between 1 and 10. To get
    /// the next page results, provide the pagination token from the response as part of your
    /// request. A null pagination token fetches the records from the beginning. </para>
    /// </summary>
    public partial class GetModelsRequest : AmazonFraudDetectorRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of objects to return for the request. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property ModelId. 
        /// <para>
        /// The model ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ModelId { get; set; }

        /// <summary>
        /// Checks to see if the ModelId property is set.
        /// </summary>
        internal bool IsSetModelId() => this.ModelId != null;

        /// <summary>
        /// Gets and sets the property ModelType. 
        /// <para>
        /// The model type.
        /// </para>
        /// </summary>
        public ModelTypeEnum ModelType { get; set; }

        /// <summary>
        /// Checks to see if the ModelType property is set.
        /// </summary>
        internal bool IsSetModelType() => this.ModelType != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The next token for the subsequent request.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
