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

namespace Amazon.EMRContainers.Model
{
    /// <summary>
    /// Container for the parameters to the ListJobRuns operation. Lists job runs based on
    /// a set of parameters. A job run is a unit of work, such as a Spark jar, PySpark script,
    /// or SparkSQL query, that you submit to Amazon EMR on EKS.
    /// </summary>
    public partial class ListJobRunsRequest : AmazonEMRContainersRequest
    {
        /// <summary>
        /// Gets and sets the property CreatedAfter. 
        /// <para>
        /// The date and time after which the job runs were submitted.
        /// </para>
        /// </summary>
        public DateTime? CreatedAfter { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAfter property is set.
        /// </summary>
        internal bool IsSetCreatedAfter() => this.CreatedAfter.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBefore. 
        /// <para>
        /// The date and time before which the job runs were submitted.
        /// </para>
        /// </summary>
        public DateTime? CreatedBefore { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBefore property is set.
        /// </summary>
        internal bool IsSetCreatedBefore() => this.CreatedBefore.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of job runs that can be listed.
        /// </para>
        /// </summary>
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the job run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of job runs to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property States. 
        /// <para>
        /// The states of the job run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<string> States { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the States property is set.
        /// </summary>
        internal bool IsSetStates() => this.States != null && (this.States.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VirtualClusterId. 
        /// <para>
        /// The ID of the virtual cluster for which to list the job run. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string VirtualClusterId { get; set; }

        /// <summary>
        /// Checks to see if the VirtualClusterId property is set.
        /// </summary>
        internal bool IsSetVirtualClusterId() => this.VirtualClusterId != null;
    }
}
