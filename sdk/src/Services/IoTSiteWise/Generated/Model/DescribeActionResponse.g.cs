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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the DescribeAction operation.
    /// </summary>
    public partial class DescribeActionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ActionDefinitionId. 
        /// <para>
        /// The ID of the action definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string ActionDefinitionId { get; set; }

        /// <summary>
        /// Checks to see if the ActionDefinitionId property is set.
        /// </summary>
        internal bool IsSetActionDefinitionId() => this.ActionDefinitionId != null;

        /// <summary>
        /// Gets and sets the property ActionId. 
        /// <para>
        /// The ID of the action.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string ActionId { get; set; }

        /// <summary>
        /// Checks to see if the ActionId property is set.
        /// </summary>
        internal bool IsSetActionId() => this.ActionId != null;

        /// <summary>
        /// Gets and sets the property ActionPayload. 
        /// <para>
        /// The JSON payload of the action.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ActionPayload ActionPayload { get; set; }

        /// <summary>
        /// Checks to see if the ActionPayload property is set.
        /// </summary>
        internal bool IsSetActionPayload() => this.ActionPayload != null;

        /// <summary>
        /// Gets and sets the property ExecutionTime. 
        /// <para>
        /// The time the action was executed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? ExecutionTime { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionTime property is set.
        /// </summary>
        internal bool IsSetExecutionTime() => this.ExecutionTime.HasValue;

        /// <summary>
        /// Gets and sets the property ResolveTo. 
        /// <para>
        /// The detailed resource this action resolves to.
        /// </para>
        /// </summary>
        public ResolveTo ResolveTo { get; set; }

        /// <summary>
        /// Checks to see if the ResolveTo property is set.
        /// </summary>
        internal bool IsSetResolveTo() => this.ResolveTo != null;

        /// <summary>
        /// Gets and sets the property TargetResource. 
        /// <para>
        /// The resource the action will be taken on.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TargetResource TargetResource { get; set; }

        /// <summary>
        /// Checks to see if the TargetResource property is set.
        /// </summary>
        internal bool IsSetTargetResource() => this.TargetResource != null;
    }
}
