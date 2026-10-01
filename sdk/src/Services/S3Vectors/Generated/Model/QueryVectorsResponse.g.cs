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

namespace Amazon.S3Vectors.Model
{
    /// <summary>
    /// This is the response object from the QueryVectors operation.
    /// </summary>
    public partial class QueryVectorsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DistanceMetric. 
        /// <para>
        /// The distance metric that was used for the similarity search calculation. This is the
        /// same distance metric that was configured for the vector index when it was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DistanceMetric DistanceMetric { get; set; }

        /// <summary>
        /// Checks to see if the DistanceMetric property is set.
        /// </summary>
        internal bool IsSetDistanceMetric() => this.DistanceMetric != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Pagination token to be used in the subsequent page request. The field is empty if
        /// no further pagination is required.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Vectors. 
        /// <para>
        /// The vectors in the approximate nearest neighbor search.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<QueryOutputVector> Vectors { get; set; } = AWSConfigs.InitializeCollections ? new List<QueryOutputVector>() : null;

        /// <summary>
        /// Checks to see if the Vectors property is set.
        /// </summary>
        internal bool IsSetVectors() => this.Vectors != null && (this.Vectors.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
