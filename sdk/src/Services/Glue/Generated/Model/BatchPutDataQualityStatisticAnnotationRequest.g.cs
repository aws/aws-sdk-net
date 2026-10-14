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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the BatchPutDataQualityStatisticAnnotation operation.
    /// Annotate datapoints over time for a specific data quality statistic. The API requires
    /// both profileID and statisticID as part of the InclusionAnnotation input. The API only
    /// works for a single statisticId across multiple profiles.
    /// </summary>
    public partial class BatchPutDataQualityStatisticAnnotationRequest : AmazonGlueRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Client Token.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property InclusionAnnotations. 
        /// <para>
        /// A list of <c>DatapointInclusionAnnotation</c>'s. The InclusionAnnotations must contain
        /// a profileId and statisticId. If there are multiple InclusionAnnotations, the list
        /// must refer to a single statisticId across multiple profileIds.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<DatapointInclusionAnnotation> InclusionAnnotations { get; set; } = AWSConfigs.InitializeCollections ? new List<DatapointInclusionAnnotation>() : null;

        /// <summary>
        /// Checks to see if the InclusionAnnotations property is set.
        /// </summary>
        internal bool IsSetInclusionAnnotations() => this.InclusionAnnotations != null && (this.InclusionAnnotations.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
