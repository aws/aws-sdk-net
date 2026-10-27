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

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Describes updates to the input streams, destination streams, and reference data sources
    /// for a SQL-based Kinesis Data Analytics application.
    /// </summary>
    public partial class SqlApplicationConfigurationUpdate
    {
        /// <summary>
        /// Gets and sets the property InputUpdates. 
        /// <para>
        /// The array of <a>InputUpdate</a> objects describing the new input streams used by the
        /// application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InputUpdate> InputUpdates { get; set; } = AWSConfigs.InitializeCollections ? new List<InputUpdate>() : null;

        /// <summary>
        /// Checks to see if the InputUpdates property is set.
        /// </summary>
        internal bool IsSetInputUpdates() => this.InputUpdates != null && (this.InputUpdates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OutputUpdates. 
        /// <para>
        /// The array of <a>OutputUpdate</a> objects describing the new destination streams used
        /// by the application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OutputUpdate> OutputUpdates { get; set; } = AWSConfigs.InitializeCollections ? new List<OutputUpdate>() : null;

        /// <summary>
        /// Checks to see if the OutputUpdates property is set.
        /// </summary>
        internal bool IsSetOutputUpdates() => this.OutputUpdates != null && (this.OutputUpdates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReferenceDataSourceUpdates. 
        /// <para>
        /// The array of <a>ReferenceDataSourceUpdate</a> objects describing the new reference
        /// data sources used by the application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ReferenceDataSourceUpdate> ReferenceDataSourceUpdates { get; set; } = AWSConfigs.InitializeCollections ? new List<ReferenceDataSourceUpdate>() : null;

        /// <summary>
        /// Checks to see if the ReferenceDataSourceUpdates property is set.
        /// </summary>
        internal bool IsSetReferenceDataSourceUpdates() => this.ReferenceDataSourceUpdates != null && (this.ReferenceDataSourceUpdates.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
