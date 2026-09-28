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

namespace Amazon.OSIS.Model
{
    /// <summary>
    /// Container for information about an OpenSearch Ingestion blueprint.
    /// </summary>
    public partial class PipelineBlueprint
    {
        /// <summary>
        /// Gets and sets the property BlueprintName. 
        /// <para>
        /// The name of the blueprint.
        /// </para>
        /// </summary>
        public string BlueprintName { get; set; }

        /// <summary>
        /// Checks to see if the BlueprintName property is set.
        /// </summary>
        internal bool IsSetBlueprintName() => this.BlueprintName != null;

        /// <summary>
        /// Gets and sets the property DisplayDescription. 
        /// <para>
        /// A description of the blueprint.
        /// </para>
        /// </summary>
        public string DisplayDescription { get; set; }

        /// <summary>
        /// Checks to see if the DisplayDescription property is set.
        /// </summary>
        internal bool IsSetDisplayDescription() => this.DisplayDescription != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the blueprint.
        /// </para>
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property PipelineConfigurationBody. 
        /// <para>
        /// The YAML configuration of the blueprint.
        /// </para>
        /// </summary>
        public string PipelineConfigurationBody { get; set; }

        /// <summary>
        /// Checks to see if the PipelineConfigurationBody property is set.
        /// </summary>
        internal bool IsSetPipelineConfigurationBody() => this.PipelineConfigurationBody != null;

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// The name of the service that the blueprint is associated with.
        /// </para>
        /// </summary>
        public string Service { get; set; }

        /// <summary>
        /// Checks to see if the Service property is set.
        /// </summary>
        internal bool IsSetService() => this.Service != null;

        /// <summary>
        /// Gets and sets the property UseCase. 
        /// <para>
        /// The use case that the blueprint relates to.
        /// </para>
        /// </summary>
        public string UseCase { get; set; }

        /// <summary>
        /// Checks to see if the UseCase property is set.
        /// </summary>
        internal bool IsSetUseCase() => this.UseCase != null;
    }
}
