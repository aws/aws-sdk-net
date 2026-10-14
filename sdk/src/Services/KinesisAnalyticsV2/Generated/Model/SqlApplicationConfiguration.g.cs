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
    public partial class SqlApplicationConfiguration
    {
        /// <summary>
        /// Gets and sets the property Inputs. 
        /// <para>
        /// The array of <a>Input</a> objects describing the input streams used by the application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Input> Inputs { get; set; } = AWSConfigs.InitializeCollections ? new List<Input>() : null;

        /// <summary>
        /// Checks to see if the Inputs property is set.
        /// </summary>
        internal bool IsSetInputs() => this.Inputs != null && (this.Inputs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Outputs. 
        /// <para>
        /// The array of <a>Output</a> objects describing the destination streams used by the
        /// application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Output> Outputs { get; set; } = AWSConfigs.InitializeCollections ? new List<Output>() : null;

        /// <summary>
        /// Checks to see if the Outputs property is set.
        /// </summary>
        internal bool IsSetOutputs() => this.Outputs != null && (this.Outputs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReferenceDataSources. 
        /// <para>
        /// The array of <a>ReferenceDataSource</a> objects describing the reference data sources
        /// used by the application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ReferenceDataSource> ReferenceDataSources { get; set; } = AWSConfigs.InitializeCollections ? new List<ReferenceDataSource>() : null;

        /// <summary>
        /// Checks to see if the ReferenceDataSources property is set.
        /// </summary>
        internal bool IsSetReferenceDataSources() => this.ReferenceDataSources != null && (this.ReferenceDataSources.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
