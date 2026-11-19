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

namespace Amazon.RTBFabric.Model
{
    /// <summary>
    /// A version attached to a flow, with its settings.
    /// </summary>
    public partial class FlowModule
    {
        /// <summary>
        /// Gets and sets the property ActivationPercentage. 
        /// <para>
        /// The percentage of the flow's requests that the module runs on. The flow skips the
        /// module on the rest of the requests. The default is 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public float? ActivationPercentage { get; set; }

        /// <summary>
        /// Checks to see if the ActivationPercentage property is set.
        /// </summary>
        internal bool IsSetActivationPercentage() => this.ActivationPercentage.HasValue;

        /// <summary>
        /// Gets and sets the property ConfigurationValues. 
        /// <para>
        /// RTB Fabric validates the value against the version's <c>configurationSchema</c> and
        /// rejects a value that fails with ValidationException. Omit it when the schema is empty
        /// or fully defaulted.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10240)]
        public string ConfigurationValues { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationValues property is set.
        /// </summary>
        internal bool IsSetConfigurationValues() => this.ConfigurationValues != null;

        /// <summary>
        /// Gets and sets the property FailureMode. 
        /// <para>
        /// Specifies what happens when the module fails – when its call fails or times out, or
        /// when an express module's dataset is stale. The default is OPEN.
        /// </para>
        /// </summary>
        public FailureMode FailureMode { get; set; }

        /// <summary>
        /// Checks to see if the FailureMode property is set.
        /// </summary>
        internal bool IsSetFailureMode() => this.FailureMode != null;

        /// <summary>
        /// Gets and sets the property ModuleVersionArn. 
        /// <para>
        /// The version to attach. It must be ACTIVE and available to you (see ListAvailableModuleVersions).
        /// You can keep a version that's already in the link's flows after it's deprecated, but
        /// you can't give it a higher share of traffic.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 1011)]
        public string ModuleVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the ModuleVersionArn property is set.
        /// </summary>
        internal bool IsSetModuleVersionArn() => this.ModuleVersionArn != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The module's name, unique within the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SelectedActions. 
        /// <para>
        /// The capabilities to turn on, chosen from the version's <c>configurableActions</c>.
        /// If the version exposes one, it's the default. If the version exposes more than one,
        /// this field is required. If it exposes none, omit this field.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 16)]
        public List<string> SelectedActions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SelectedActions property is set.
        /// </summary>
        internal bool IsSetSelectedActions() => this.SelectedActions != null && (this.SelectedActions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
