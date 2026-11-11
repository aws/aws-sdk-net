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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the ListSteps operation. Provides a list of steps
    /// for the cluster in reverse order unless you specify <c>stepIds</c> with the request
    /// or filter by <c>StepStates</c>. You can specify a maximum of 10 <c>stepIDs</c>. The
    /// CLI automatically paginates results to return a list greater than 50 steps. To return
    /// more than 50 steps using the CLI, specify a <c>Marker</c>, which is a pagination token
    /// that indicates the next set of steps to retrieve.
    /// </summary>
    public partial class ListStepsRequest : AmazonElasticMapReduceRequest
    {
        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// The identifier of the cluster for which to list the steps.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string ClusterId { get; set; }

        /// <summary>
        /// Checks to see if the ClusterId property is set.
        /// </summary>
        internal bool IsSetClusterId() => this.ClusterId != null;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The maximum number of steps that a single <c>ListSteps</c> action returns is 50. To
        /// return a longer list of steps, use multiple <c>ListSteps</c> actions along with the
        /// <c>Marker</c> parameter, which is a pagination token that indicates the next set of
        /// results to retrieve.
        /// </para>
        /// </summary>
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property StepIds. 
        /// <para>
        /// The filter to limit the step list based on the identifier of the steps. You can specify
        /// a maximum of ten Step IDs. The character constraint applies to the overall length
        /// of the array.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> StepIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StepIds property is set.
        /// </summary>
        internal bool IsSetStepIds() => this.StepIds != null && (this.StepIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StepStates. 
        /// <para>
        /// The filter to limit the step list based on certain states.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> StepStates { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StepStates property is set.
        /// </summary>
        internal bool IsSetStepStates() => this.StepStates != null && (this.StepStates.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
