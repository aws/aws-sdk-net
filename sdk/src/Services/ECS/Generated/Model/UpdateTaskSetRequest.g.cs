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
    /// Container for the parameters to the UpdateTaskSet operation. Modifies a task set.
    /// This is used when a service uses the <c>EXTERNAL</c> deployment controller type. For
    /// more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-types.html">Amazon
    /// ECS Deployment Types</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </summary>
    public partial class UpdateTaskSetRequest : AmazonECSRequest
    {
        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the cluster that hosts the service
        /// that the task set is found in.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Cluster { get; set; }

        /// <summary>
        /// Checks to see if the Cluster property is set.
        /// </summary>
        internal bool IsSetCluster() => this.Cluster != null;

        /// <summary>
        /// Gets and sets the property Scale. 
        /// <para>
        /// A floating-point percentage of the desired number of tasks to place and keep running
        /// in the task set.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Scale Scale { get; set; }

        /// <summary>
        /// Checks to see if the Scale property is set.
        /// </summary>
        internal bool IsSetScale() => this.Scale != null;

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the service that the task set
        /// is found in.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Service { get; set; }

        /// <summary>
        /// Checks to see if the Service property is set.
        /// </summary>
        internal bool IsSetService() => this.Service != null;

        /// <summary>
        /// Gets and sets the property TaskSet. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the task set to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TaskSet { get; set; }

        /// <summary>
        /// Checks to see if the TaskSet property is set.
        /// </summary>
        internal bool IsSetTaskSet() => this.TaskSet != null;
    }
}
