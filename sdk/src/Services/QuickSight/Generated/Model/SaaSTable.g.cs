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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A table from a Software-as-a-Service (SaaS) data source, including connection details
    /// and column definitions.
    /// </summary>
    public partial class SaaSTable
    {
        /// <summary>
        /// Gets and sets the property DataSourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the SaaS data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DataSourceArn { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceArn property is set.
        /// </summary>
        internal bool IsSetDataSourceArn() => this.DataSourceArn != null;

        /// <summary>
        /// Gets and sets the property InputColumns. 
        /// <para>
        /// The list of input columns available from the SaaS table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2048)]
        public List<InputColumn> InputColumns { get; set; } = AWSConfigs.InitializeCollections ? new List<InputColumn>() : null;

        /// <summary>
        /// Checks to see if the InputColumns property is set.
        /// </summary>
        internal bool IsSetInputColumns() => this.InputColumns != null && (this.InputColumns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TablePath. 
        /// <para>
        /// The hierarchical path to the table within the SaaS data source.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public List<TablePathElement> TablePath { get; set; } = AWSConfigs.InitializeCollections ? new List<TablePathElement>() : null;

        /// <summary>
        /// Checks to see if the TablePath property is set.
        /// </summary>
        internal bool IsSetTablePath() => this.TablePath != null && (this.TablePath.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
