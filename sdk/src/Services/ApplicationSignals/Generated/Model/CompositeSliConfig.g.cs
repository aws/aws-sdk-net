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

namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// This structure contains the configuration for a composite service level indicator
    /// (SLI) that aggregates metrics across multiple operations of a service for service-level
    /// SLOs.
    /// </summary>
    public partial class CompositeSliConfig
    {
        /// <summary>
        /// Gets and sets the property Components. 
        /// <para>
        /// The list of operations included in this composite SLI. You must specify between 2
        /// and 20 components. Each component is a <c>CompositeSliComponent</c> that identifies
        /// a single operation by its <c>OperationName</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 2, Max = 20)]
        public List<CompositeSliComponent> Components { get; set; } = AWSConfigs.InitializeCollections ? new List<CompositeSliComponent>() : null;

        /// <summary>
        /// Checks to see if the Components property is set.
        /// </summary>
        internal bool IsSetComponents() => this.Components != null && (this.Components.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SelectionConfig. 
        /// <para>
        /// Specifies how operations are selected for this service-level SLO. Operations can be
        /// selected explicitly by listing them, by specifying a prefix to match operation names,
        /// or by providing a regular expression pattern.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SelectionConfig SelectionConfig { get; set; }

        /// <summary>
        /// Checks to see if the SelectionConfig property is set.
        /// </summary>
        internal bool IsSetSelectionConfig() => this.SelectionConfig != null;
    }
}
