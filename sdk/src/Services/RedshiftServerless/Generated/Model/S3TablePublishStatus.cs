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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
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
namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// Describes the state of Amazon S3 Tables system-table log publishing for a namespace.
    /// </summary>
    public partial class S3TablePublishStatus
    {
        private bool? _enabledAll;
        private Dictionary<string, string> _lastIngestionTimes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private S3TableGranularity _s3TableGranularity;
        private string _s3TableNamespace;
        private List<string> _s3Tables = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property EnabledAll. 
        /// <para>
        ///  <c>true</c> when the namespace is enrolled in every current and future system table
        /// rather than an explicit list of tables.
        /// </para>
        /// </summary>
        public bool? EnabledAll
        {
            get { return this._enabledAll; }
            set { this._enabledAll = value; }
        }

        // Check to see if EnabledAll property is set
        internal bool IsSetEnabledAll()
        {
            return this._enabledAll.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastIngestionTimes. 
        /// <para>
        /// A map of system table name to the time that table last received data, as an ISO-8601
        /// timestamp. A table that has not yet been ingested is absent from the map. Use it to
        /// judge data freshness.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> LastIngestionTimes
        {
            get { return this._lastIngestionTimes; }
            set { this._lastIngestionTimes = value; }
        }

        // Check to see if LastIngestionTimes property is set
        internal bool IsSetLastIngestionTimes()
        {
            return this._lastIngestionTimes != null && (this._lastIngestionTimes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property S3TableGranularity. 
        /// <para>
        /// The scope currently in effect. Values are <c>namespace</c> or <c>account</c>.
        /// </para>
        /// </summary>
        public S3TableGranularity S3TableGranularity
        {
            get { return this._s3TableGranularity; }
            set { this._s3TableGranularity = value; }
        }

        // Check to see if S3TableGranularity property is set
        internal bool IsSetS3TableGranularity()
        {
            return this._s3TableGranularity != null;
        }

        /// <summary>
        /// Gets and sets the property S3TableNamespace. 
        /// <para>
        /// The identifier of the namespace in the S3 table bucket that holds the published tables.
        /// </para>
        /// </summary>
        public string S3TableNamespace
        {
            get { return this._s3TableNamespace; }
            set { this._s3TableNamespace = value; }
        }

        // Check to see if S3TableNamespace property is set
        internal bool IsSetS3TableNamespace()
        {
            return this._s3TableNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property S3Tables. 
        /// <para>
        /// The system tables currently being published.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public List<string> S3Tables
        {
            get { return this._s3Tables; }
            set { this._s3Tables = value; }
        }

        // Check to see if S3Tables property is set
        internal bool IsSetS3Tables()
        {
            return this._s3Tables != null && (this._s3Tables.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}