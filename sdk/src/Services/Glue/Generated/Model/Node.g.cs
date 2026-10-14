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
    /// A node represents an Glue component (trigger, crawler, or job) on a workflow graph.
    /// </summary>
    public partial class Node
    {
        /// <summary>
        /// Gets and sets the property CrawlerDetails. 
        /// <para>
        /// Details of the crawler when the node represents a crawler.
        /// </para>
        /// </summary>
        public CrawlerNodeDetails CrawlerDetails { get; set; }

        /// <summary>
        /// Checks to see if the CrawlerDetails property is set.
        /// </summary>
        internal bool IsSetCrawlerDetails() => this.CrawlerDetails != null;

        /// <summary>
        /// Gets and sets the property JobDetails. 
        /// <para>
        /// Details of the Job when the node represents a Job.
        /// </para>
        /// </summary>
        public JobNodeDetails JobDetails { get; set; }

        /// <summary>
        /// Checks to see if the JobDetails property is set.
        /// </summary>
        internal bool IsSetJobDetails() => this.JobDetails != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Glue component represented by the node.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property TriggerDetails. 
        /// <para>
        /// Details of the Trigger when the node represents a Trigger.
        /// </para>
        /// </summary>
        public TriggerNodeDetails TriggerDetails { get; set; }

        /// <summary>
        /// Checks to see if the TriggerDetails property is set.
        /// </summary>
        internal bool IsSetTriggerDetails() => this.TriggerDetails != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of Glue component represented by the node.
        /// </para>
        /// </summary>
        public NodeType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property UniqueId. 
        /// <para>
        /// The unique Id assigned to the node within the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string UniqueId { get; set; }

        /// <summary>
        /// Checks to see if the UniqueId property is set.
        /// </summary>
        internal bool IsSetUniqueId() => this.UniqueId != null;
    }
}
