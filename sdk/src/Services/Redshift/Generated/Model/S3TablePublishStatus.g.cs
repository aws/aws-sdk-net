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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Describes the status of system table publishing to S3 Tables for a cluster.
    /// </summary>
    public partial class S3TablePublishStatus
    {
        /// <summary>
        /// Gets and sets the property EnabledAll. 
        /// <para>
        ///  <c>true</c> if the cluster is enrolled in all current and future system tables rather
        /// than an explicit subset.
        /// </para>
        /// </summary>
        public bool? EnabledAll { get; set; }

        /// <summary>
        /// Checks to see if the EnabledAll property is set.
        /// </summary>
        internal bool IsSetEnabledAll() => this.EnabledAll.HasValue;

        /// <summary>
        /// Gets and sets the property LastIngestionTimes. 
        /// <para>
        /// A map whose keys are the names of the published system tables and whose values are
        /// the time each table last received data. Use this to judge data freshness.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> LastIngestionTimes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the LastIngestionTimes property is set.
        /// </summary>
        internal bool IsSetLastIngestionTimes() => this.LastIngestionTimes != null && (this.LastIngestionTimes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property S3TableGranularity. 
        /// <para>
        /// The scope of system table publishing in effect. Possible values are <c>cluster</c>
        /// and <c>account</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string S3TableGranularity { get; set; }

        /// <summary>
        /// Checks to see if the S3TableGranularity property is set.
        /// </summary>
        internal bool IsSetS3TableGranularity() => this.S3TableGranularity != null;

        /// <summary>
        /// Gets and sets the property S3TableNamespace. 
        /// <para>
        /// The namespace in the S3 table bucket that holds the published tables.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string S3TableNamespace { get; set; }

        /// <summary>
        /// Checks to see if the S3TableNamespace property is set.
        /// </summary>
        internal bool IsSetS3TableNamespace() => this.S3TableNamespace != null;

        /// <summary>
        /// Gets and sets the property S3Tables. 
        /// <para>
        /// The system tables currently being published.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> S3Tables { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the S3Tables property is set.
        /// </summary>
        internal bool IsSetS3Tables() => this.S3Tables != null && (this.S3Tables.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
