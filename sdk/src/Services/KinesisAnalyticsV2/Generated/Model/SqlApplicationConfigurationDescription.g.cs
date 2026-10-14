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
    /// Describes the inputs, outputs, and reference data sources for a SQL-based Kinesis
    /// Data Analytics application.
    /// </summary>
    public partial class SqlApplicationConfigurationDescription
    {
        /// <summary>
        /// Gets and sets the property InputDescriptions. 
        /// <para>
        /// The array of <a>InputDescription</a> objects describing the input streams used by
        /// the application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InputDescription> InputDescriptions { get; set; } = AWSConfigs.InitializeCollections ? new List<InputDescription>() : null;

        /// <summary>
        /// Checks to see if the InputDescriptions property is set.
        /// </summary>
        internal bool IsSetInputDescriptions() => this.InputDescriptions != null && (this.InputDescriptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OutputDescriptions. 
        /// <para>
        /// The array of <a>OutputDescription</a> objects describing the destination streams used
        /// by the application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OutputDescription> OutputDescriptions { get; set; } = AWSConfigs.InitializeCollections ? new List<OutputDescription>() : null;

        /// <summary>
        /// Checks to see if the OutputDescriptions property is set.
        /// </summary>
        internal bool IsSetOutputDescriptions() => this.OutputDescriptions != null && (this.OutputDescriptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReferenceDataSourceDescriptions. 
        /// <para>
        /// The array of <a>ReferenceDataSourceDescription</a> objects describing the reference
        /// data sources used by the application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ReferenceDataSourceDescription> ReferenceDataSourceDescriptions { get; set; } = AWSConfigs.InitializeCollections ? new List<ReferenceDataSourceDescription>() : null;

        /// <summary>
        /// Checks to see if the ReferenceDataSourceDescriptions property is set.
        /// </summary>
        internal bool IsSetReferenceDataSourceDescriptions() => this.ReferenceDataSourceDescriptions != null && (this.ReferenceDataSourceDescriptions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
