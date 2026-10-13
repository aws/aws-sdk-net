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
    /// Specifies a Delta data store to crawl one or more Delta tables.
    /// </summary>
    public partial class DeltaTarget
    {
        /// <summary>
        /// Gets and sets the property ConnectionName. 
        /// <para>
        /// The name of the connection to use to connect to the Delta table target.
        /// </para>
        /// </summary>
        public string ConnectionName { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionName property is set.
        /// </summary>
        internal bool IsSetConnectionName() => this.ConnectionName != null;

        /// <summary>
        /// Gets and sets the property CreateNativeDeltaTable. 
        /// <para>
        /// Specifies whether the crawler will create native tables, to allow integration with
        /// query engines that support querying of the Delta transaction log directly.
        /// </para>
        /// </summary>
        public bool? CreateNativeDeltaTable { get; set; }

        /// <summary>
        /// Checks to see if the CreateNativeDeltaTable property is set.
        /// </summary>
        internal bool IsSetCreateNativeDeltaTable() => this.CreateNativeDeltaTable.HasValue;

        /// <summary>
        /// Gets and sets the property DeltaTables. 
        /// <para>
        /// A list of the Amazon S3 paths to the Delta tables.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DeltaTables { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DeltaTables property is set.
        /// </summary>
        internal bool IsSetDeltaTables() => this.DeltaTables != null && (this.DeltaTables.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WriteManifest. 
        /// <para>
        /// Specifies whether to write the manifest files to the Delta table path.
        /// </para>
        /// </summary>
        public bool? WriteManifest { get; set; }

        /// <summary>
        /// Checks to see if the WriteManifest property is set.
        /// </summary>
        internal bool IsSetWriteManifest() => this.WriteManifest.HasValue;
    }
}
