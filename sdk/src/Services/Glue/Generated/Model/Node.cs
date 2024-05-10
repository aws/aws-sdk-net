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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
        private CrawlerNodeDetails _crawlerDetails;
        private JobNodeDetails _jobDetails;
        private string _name;
        private TriggerNodeDetails _triggerDetails;
        private NodeType _type;
        private string _uniqueId;

        /// <summary>
        /// Gets and sets the property CrawlerDetails. 
        /// <para>
        /// Details of the crawler when the node represents a crawler.
        /// </para>
        /// </summary>
        public CrawlerNodeDetails CrawlerDetails
        {
            get { return this._crawlerDetails; }
            set { this._crawlerDetails = value; }
        }

        // Check to see if CrawlerDetails property is set
        internal bool IsSetCrawlerDetails()
        {
            return this._crawlerDetails != null;
        }

        /// <summary>
        /// Gets and sets the property JobDetails. 
        /// <para>
        /// Details of the Job when the node represents a Job.
        /// </para>
        /// </summary>
        public JobNodeDetails JobDetails
        {
            get { return this._jobDetails; }
            set { this._jobDetails = value; }
        }

        // Check to see if JobDetails property is set
        internal bool IsSetJobDetails()
        {
            return this._jobDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Glue component represented by the node.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property TriggerDetails. 
        /// <para>
        /// Details of the Trigger when the node represents a Trigger.
        /// </para>
        /// </summary>
        public TriggerNodeDetails TriggerDetails
        {
            get { return this._triggerDetails; }
            set { this._triggerDetails = value; }
        }

        // Check to see if TriggerDetails property is set
        internal bool IsSetTriggerDetails()
        {
            return this._triggerDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of Glue component represented by the node.
        /// </para>
        /// </summary>
        public NodeType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UniqueId. 
        /// <para>
        /// The unique Id assigned to the node within the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string UniqueId
        {
            get { return this._uniqueId; }
            set { this._uniqueId = value; }
        }

        // Check to see if UniqueId property is set
        internal bool IsSetUniqueId()
        {
            return this._uniqueId != null;
        }

    }
}