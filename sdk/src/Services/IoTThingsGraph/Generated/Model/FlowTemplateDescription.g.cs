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

namespace Amazon.IoTThingsGraph.Model
{
    /// <summary>
    /// An object that contains a workflow's definition and summary information.
    /// </summary>
    public partial class FlowTemplateDescription
    {
        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// A workflow's definition document.
        /// </para>
        /// </summary>
        public DefinitionDocument Definition { get; set; }

        /// <summary>
        /// Checks to see if the Definition property is set.
        /// </summary>
        internal bool IsSetDefinition() => this.Definition != null;

        /// <summary>
        /// Gets and sets the property Summary. 
        /// <para>
        /// An object that contains summary information about a workflow.
        /// </para>
        /// </summary>
        public FlowTemplateSummary Summary { get; set; }

        /// <summary>
        /// Checks to see if the Summary property is set.
        /// </summary>
        internal bool IsSetSummary() => this.Summary != null;

        /// <summary>
        /// Gets and sets the property ValidatedNamespaceVersion. 
        /// <para>
        /// The version of the user's namespace against which the workflow was validated. Use
        /// this value in your system instance.
        /// </para>
        /// </summary>
        public long? ValidatedNamespaceVersion { get; set; }

        /// <summary>
        /// Checks to see if the ValidatedNamespaceVersion property is set.
        /// </summary>
        internal bool IsSetValidatedNamespaceVersion() => this.ValidatedNamespaceVersion.HasValue;
    }
}
