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

namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeObjects operation. Gets the object definitions
    /// for a set of objects associated with the pipeline. Object definitions are composed
    /// of a set of fields that define the properties of the object.
    /// </summary>
    public partial class DescribeObjectsRequest : AmazonDataPipelineRequest
    {
        /// <summary>
        /// Gets and sets the property EvaluateExpressions. 
        /// <para>
        /// Indicates whether any expressions in the object should be evaluated when the object
        /// descriptions are returned.
        /// </para>
        /// </summary>
        public bool? EvaluateExpressions { get; set; }

        /// <summary>
        /// Checks to see if the EvaluateExpressions property is set.
        /// </summary>
        internal bool IsSetEvaluateExpressions() => this.EvaluateExpressions.HasValue;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The starting point for the results to be returned. For the first call, this value
        /// should be empty. As long as there are more results, continue to call <c>DescribeObjects</c>
        /// with the marker value from the previous call to retrieve the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property ObjectIds. 
        /// <para>
        /// The IDs of the pipeline objects that contain the definitions to be described. You
        /// can pass as many as 25 identifiers in a single call to <c>DescribeObjects</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> ObjectIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ObjectIds property is set.
        /// </summary>
        internal bool IsSetObjectIds() => this.ObjectIds != null && (this.ObjectIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PipelineId. 
        /// <para>
        /// The ID of the pipeline that contains the object definitions.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string PipelineId { get; set; }

        /// <summary>
        /// Checks to see if the PipelineId property is set.
        /// </summary>
        internal bool IsSetPipelineId() => this.PipelineId != null;
    }
}
