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
    /// Details about worker setting of a connector
    /// </summary>
    public partial class WorkerSetting
    {
        /// <summary>
        /// Gets and sets the property Capacity. 
        /// <para>
        /// Specifies the compute capacity settings of the connector.
        /// </para>
        /// </summary>
        public CapacityDescription Capacity { get; set; }

        /// <summary>
        /// Checks to see if the Capacity property is set.
        /// </summary>
        internal bool IsSetCapacity() => this.Capacity != null;

        /// <summary>
        /// Gets and sets the property Plugins. 
        /// <para>
        /// Specifies which plugins the connector uses.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PluginDescription> Plugins { get; set; } = AWSConfigs.InitializeCollections ? new List<PluginDescription>() : null;

        /// <summary>
        /// Checks to see if the Plugins property is set.
        /// </summary>
        internal bool IsSetPlugins() => this.Plugins != null && (this.Plugins.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UseDefaultWorkerConfiguration. 
        /// <para>
        /// Specifies whether the connector uses the default worker configuration instead of a
        /// custom worker configuration.
        /// </para>
        /// </summary>
        public bool? UseDefaultWorkerConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the UseDefaultWorkerConfiguration property is set.
        /// </summary>
        internal bool IsSetUseDefaultWorkerConfiguration() => this.UseDefaultWorkerConfiguration.HasValue;

        /// <summary>
        /// Gets and sets the property WorkerConfiguration. 
        /// <para>
        /// Specifies which worker configuration the connector uses.
        /// </para>
        /// </summary>
        public WorkerConfigurationDescription WorkerConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the WorkerConfiguration property is set.
        /// </summary>
        internal bool IsSetWorkerConfiguration() => this.WorkerConfiguration != null;
    }
}
