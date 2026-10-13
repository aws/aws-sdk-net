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
    /// Properties associated with the integration.
    /// </summary>
    public partial class IntegrationConfig
    {
        /// <summary>
        /// Gets and sets the property ContinuousSync. 
        /// <para>
        /// Enables continuous synchronization for on-demand data extractions from SaaS applications
        /// to Amazon Web Services data services like Amazon Redshift and Amazon S3.
        /// </para>
        /// </summary>
        public bool? ContinuousSync { get; set; }

        /// <summary>
        /// Checks to see if the ContinuousSync property is set.
        /// </summary>
        internal bool IsSetContinuousSync() => this.ContinuousSync.HasValue;

        /// <summary>
        /// Gets and sets the property RefreshInterval. 
        /// <para>
        /// Specifies the frequency at which CDC (Change Data Capture) pulls or incremental loads
        /// should occur. This parameter provides flexibility to align the refresh rate with your
        /// specific data update patterns, system load considerations, and performance optimization
        /// goals. Time increment can be set from 15 minutes to 8640 minutes (six days).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string RefreshInterval { get; set; }

        /// <summary>
        /// Checks to see if the RefreshInterval property is set.
        /// </summary>
        internal bool IsSetRefreshInterval() => this.RefreshInterval != null;

        /// <summary>
        /// Gets and sets the property SourceProperties. 
        /// <para>
        ///  A collection of key-value pairs that specify additional properties for the integration
        /// source. These properties provide configuration options that can be used to customize
        /// the behavior of the ODB source during data integration operations. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> SourceProperties { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the SourceProperties property is set.
        /// </summary>
        internal bool IsSetSourceProperties() => this.SourceProperties != null && (this.SourceProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetNamespace. 
        /// <para>
        /// An optional custom namespace for the integration's target. Supply this parameter only
        /// when the target is an Amazon S3 Tables table bucket; it is not accepted for other
        /// target types. The integration replicates data into the namespace you specify, reusing
        /// it if it already exists. If you omit this parameter, the target namespace defaults
        /// to <c>zetl_</c> followed by the integration ID, with hyphens converted to underscores.
        /// </para>
        ///  
        /// <para>
        /// The value is immutable after the integration is created; <c>ModifyIntegration</c>
        /// rejects changes to it. It must be a valid Amazon S3 Tables namespace name: 1 to 255
        /// characters using lowercase letters, numbers, and underscores, with no leading or trailing
        /// underscore and no reserved <c>aws</c> prefix.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string TargetNamespace { get; set; }

        /// <summary>
        /// Checks to see if the TargetNamespace property is set.
        /// </summary>
        internal bool IsSetTargetNamespace() => this.TargetNamespace != null;
    }
}
