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

namespace Amazon.Neptunedata.Model
{
    /// <summary>
    /// This is the response object from the GetEngineStatus operation.
    /// </summary>
    public partial class GetEngineStatusResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DbEngineVersion. 
        /// <para>
        /// Set to the Neptune engine version running on your DB cluster. If this engine version
        /// has been manually patched since it was released, the version number is prefixed by
        /// <c>Patch-</c>.
        /// </para>
        /// </summary>
        public string DbEngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the DbEngineVersion property is set.
        /// </summary>
        internal bool IsSetDbEngineVersion() => this.DbEngineVersion != null;

        /// <summary>
        /// Gets and sets the property DfeQueryEngine. 
        /// <para>
        /// Set to <c>enabled</c> if the DFE engine is fully enabled, or to <c>viaQueryHint</c>
        /// (the default) if the DFE engine is only used with queries that have the <c>useDFE</c>
        /// query hint set to <c>true</c>.
        /// </para>
        /// </summary>
        public string DfeQueryEngine { get; set; }

        /// <summary>
        /// Checks to see if the DfeQueryEngine property is set.
        /// </summary>
        internal bool IsSetDfeQueryEngine() => this.DfeQueryEngine != null;

        /// <summary>
        /// Gets and sets the property Features. 
        /// <para>
        /// Contains status information about the features enabled on your DB cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Amazon.Runtime.Documents.Document> Features { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, Amazon.Runtime.Documents.Document>() : null;

        /// <summary>
        /// Checks to see if the Features property is set.
        /// </summary>
        internal bool IsSetFeatures() => this.Features != null && (this.Features.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Gremlin. 
        /// <para>
        /// Contains information about the Gremlin query language available on your cluster. Specifically,
        /// it contains a version field that specifies the current TinkerPop version being used
        /// by the engine.
        /// </para>
        /// </summary>
        public QueryLanguageVersion Gremlin { get; set; }

        /// <summary>
        /// Checks to see if the Gremlin property is set.
        /// </summary>
        internal bool IsSetGremlin() => this.Gremlin != null;

        /// <summary>
        /// Gets and sets the property LabMode. 
        /// <para>
        /// Contains Lab Mode settings being used by the engine.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> LabMode { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the LabMode property is set.
        /// </summary>
        internal bool IsSetLabMode() => this.LabMode != null && (this.LabMode.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Opencypher. 
        /// <para>
        /// Contains information about the openCypher query language available on your cluster.
        /// Specifically, it contains a version field that specifies the current operCypher version
        /// being used by the engine.
        /// </para>
        /// </summary>
        public QueryLanguageVersion Opencypher { get; set; }

        /// <summary>
        /// Checks to see if the Opencypher property is set.
        /// </summary>
        internal bool IsSetOpencypher() => this.Opencypher != null;

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// Set to <c>reader</c> if the instance is a read-replica, or to <c>writer</c> if the
        /// instance is the primary instance.
        /// </para>
        /// </summary>
        public string Role { get; set; }

        /// <summary>
        /// Checks to see if the Role property is set.
        /// </summary>
        internal bool IsSetRole() => this.Role != null;

        /// <summary>
        /// Gets and sets the property RollingBackTrxCount. 
        /// <para>
        /// If there are transactions being rolled back, this field is set to the number of such
        /// transactions. If there are none, the field doesn't appear at all.
        /// </para>
        /// </summary>
        public int? RollingBackTrxCount { get; set; }

        /// <summary>
        /// Checks to see if the RollingBackTrxCount property is set.
        /// </summary>
        internal bool IsSetRollingBackTrxCount() => this.RollingBackTrxCount.HasValue;

        /// <summary>
        /// Gets and sets the property RollingBackTrxEarliestStartTime. 
        /// <para>
        /// Set to the start time of the earliest transaction being rolled back. If no transactions
        /// are being rolled back, the field doesn't appear at all.
        /// </para>
        /// </summary>
        public string RollingBackTrxEarliestStartTime { get; set; }

        /// <summary>
        /// Checks to see if the RollingBackTrxEarliestStartTime property is set.
        /// </summary>
        internal bool IsSetRollingBackTrxEarliestStartTime() => this.RollingBackTrxEarliestStartTime != null;

        /// <summary>
        /// Gets and sets the property Settings. 
        /// <para>
        /// Contains information about the current settings on your DB cluster. For example, contains
        /// the current cluster query timeout setting (<c>clusterQueryTimeoutInMs</c>).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Settings { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Settings property is set.
        /// </summary>
        internal bool IsSetSettings() => this.Settings != null && (this.Settings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Sparql. 
        /// <para>
        /// Contains information about the SPARQL query language available on your cluster. Specifically,
        /// it contains a version field that specifies the current SPARQL version being used by
        /// the engine.
        /// </para>
        /// </summary>
        public QueryLanguageVersion Sparql { get; set; }

        /// <summary>
        /// Checks to see if the Sparql property is set.
        /// </summary>
        internal bool IsSetSparql() => this.Sparql != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// Set to the UTC time at which the current server process started.
        /// </para>
        /// </summary>
        public string StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Set to <c>healthy</c> if the instance is not experiencing problems. If the instance
        /// is recovering from a crash or from being rebooted and there are active transactions
        /// running from the latest server shutdown, status is set to <c>recovery</c>.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
