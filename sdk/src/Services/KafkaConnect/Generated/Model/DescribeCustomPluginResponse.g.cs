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

namespace Amazon.KafkaConnect.Model
{
    /// <summary>
    /// This is the response object from the DescribeCustomPlugin operation.
    /// </summary>
    public partial class DescribeCustomPluginResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the custom plugin was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property CustomPluginArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the custom plugin.
        /// </para>
        /// </summary>
        public string CustomPluginArn { get; set; }

        /// <summary>
        /// Checks to see if the CustomPluginArn property is set.
        /// </summary>
        internal bool IsSetCustomPluginArn() => this.CustomPluginArn != null;

        /// <summary>
        /// Gets and sets the property CustomPluginState. 
        /// <para>
        /// The state of the custom plugin.
        /// </para>
        /// </summary>
        public CustomPluginState CustomPluginState { get; set; }

        /// <summary>
        /// Checks to see if the CustomPluginState property is set.
        /// </summary>
        internal bool IsSetCustomPluginState() => this.CustomPluginState != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the custom plugin.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LatestRevision. 
        /// <para>
        /// The latest successfully created revision of the custom plugin. If there are no successfully
        /// created revisions, this field will be absent.
        /// </para>
        /// </summary>
        public CustomPluginRevisionSummary LatestRevision { get; set; }

        /// <summary>
        /// Checks to see if the LatestRevision property is set.
        /// </summary>
        internal bool IsSetLatestRevision() => this.LatestRevision != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the custom plugin.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property StateDescription. 
        /// <para>
        /// Details about the state of a custom plugin.
        /// </para>
        /// </summary>
        public StateDescription StateDescription { get; set; }

        /// <summary>
        /// Checks to see if the StateDescription property is set.
        /// </summary>
        internal bool IsSetStateDescription() => this.StateDescription != null;
    }
}
