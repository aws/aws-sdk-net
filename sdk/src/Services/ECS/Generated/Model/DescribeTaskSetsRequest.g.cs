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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeTaskSets operation. Describes the task
    /// sets in the specified cluster and service. This is used when a service uses the <c>EXTERNAL</c>
    /// deployment controller type. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-types.html">Amazon
    /// ECS Deployment Types</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </summary>
    public partial class DescribeTaskSetsRequest : AmazonECSRequest
    {
        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the cluster that hosts the service
        /// that the task sets exist in.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Cluster { get; set; }

        /// <summary>
        /// Checks to see if the Cluster property is set.
        /// </summary>
        internal bool IsSetCluster() => this.Cluster != null;

        /// <summary>
        /// Gets and sets the property Include. 
        /// <para>
        /// Specifies whether to see the resource tags for the task set. If <c>TAGS</c> is specified,
        /// the tags are included in the response. If this field is omitted, tags aren't included
        /// in the response.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Include { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Include property is set.
        /// </summary>
        internal bool IsSetInclude() => this.Include != null && (this.Include.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the service that the task sets
        /// exist in.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Service { get; set; }

        /// <summary>
        /// Checks to see if the Service property is set.
        /// </summary>
        internal bool IsSetService() => this.Service != null;

        /// <summary>
        /// Gets and sets the property TaskSets. 
        /// <para>
        /// The ID or full Amazon Resource Name (ARN) of task sets to describe.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TaskSets { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TaskSets property is set.
        /// </summary>
        internal bool IsSetTaskSets() => this.TaskSets != null && (this.TaskSets.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
