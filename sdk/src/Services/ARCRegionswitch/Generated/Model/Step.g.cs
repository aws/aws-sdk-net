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

namespace Amazon.ARCRegionswitch.Model
{
    /// <summary>
    /// Represents a step in a Region switch plan workflow. Each step performs a specific
    /// action during the Region switch process.
    /// </summary>
    public partial class Step
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of a step in a workflow.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ExecutionBlockConfiguration. 
        /// <para>
        /// The configuration for an execution block in a workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExecutionBlockConfiguration ExecutionBlockConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionBlockConfiguration property is set.
        /// </summary>
        internal bool IsSetExecutionBlockConfiguration() => this.ExecutionBlockConfiguration != null;

        /// <summary>
        /// Gets and sets the property ExecutionBlockType. 
        /// <para>
        /// The type of an execution block in a workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExecutionBlockType ExecutionBlockType { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionBlockType property is set.
        /// </summary>
        internal bool IsSetExecutionBlockType() => this.ExecutionBlockType != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of a step in a workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
