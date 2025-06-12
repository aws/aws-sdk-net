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
 * Do not modify this file. This file is generated from the neptunedata-2023-08-01.normal.json service model.
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
        private string _dbEngineVersion;
        private string _dfeQueryEngine;
        private Dictionary<string, Amazon.Runtime.Documents.Document> _features = AWSConfigs.InitializeCollections ? new Dictionary<string, Amazon.Runtime.Documents.Document>() : null;
        private QueryLanguageVersion _gremlin;
        private Dictionary<string, string> _labMode = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private QueryLanguageVersion _opencypher;
        private string _role;
        private int? _rollingBackTrxCount;
        private string _rollingBackTrxEarliestStartTime;
        private Dictionary<string, string> _settings = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private QueryLanguageVersion _sparql;
        private string _startTime;
        private string _status;

        /// <summary>
        /// Gets and sets the property DbEngineVersion. 
        /// <para>
        /// Set to the Neptune engine version running on your DB cluster. If this engine version
        /// has been manually patched since it was released, the version number is prefixed by
        /// <c>Patch-</c>.
        /// </para>
        /// </summary>
        public string DbEngineVersion
        {
            get { return this._dbEngineVersion; }
            set { this._dbEngineVersion = value; }
        }

        // Check to see if DbEngineVersion property is set
        internal bool IsSetDbEngineVersion()
        {
            return this._dbEngineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property DfeQueryEngine. 
        /// <para>
        /// Set to <c>enabled</c> if the DFE engine is fully enabled, or to <c>viaQueryHint</c>
        /// (the default) if the DFE engine is only used with queries that have the <c>useDFE</c>
        /// query hint set to <c>true</c>.
        /// </para>
        /// </summary>
        public string DfeQueryEngine
        {
            get { return this._dfeQueryEngine; }
            set { this._dfeQueryEngine = value; }
        }

        // Check to see if DfeQueryEngine property is set
        internal bool IsSetDfeQueryEngine()
        {
            return this._dfeQueryEngine != null;
        }

        /// <summary>
        /// Gets and sets the property Features. 
        /// <para>
        /// Contains status information about the features enabled on your DB cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Amazon.Runtime.Documents.Document> Features
        {
            get { return this._features; }
            set { this._features = value; }
        }

        // Check to see if Features property is set
        internal bool IsSetFeatures()
        {
            return this._features != null && (this._features.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Gremlin. 
        /// <para>
        /// Contains information about the Gremlin query language available on your cluster. Specifically,
        /// it contains a version field that specifies the current TinkerPop version being used
        /// by the engine.
        /// </para>
        /// </summary>
        public QueryLanguageVersion Gremlin
        {
            get { return this._gremlin; }
            set { this._gremlin = value; }
        }

        // Check to see if Gremlin property is set
        internal bool IsSetGremlin()
        {
            return this._gremlin != null;
        }

        /// <summary>
        /// Gets and sets the property LabMode. 
        /// <para>
        /// Contains Lab Mode settings being used by the engine.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> LabMode
        {
            get { return this._labMode; }
            set { this._labMode = value; }
        }

        // Check to see if LabMode property is set
        internal bool IsSetLabMode()
        {
            return this._labMode != null && (this._labMode.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Opencypher. 
        /// <para>
        /// Contains information about the openCypher query language available on your cluster.
        /// Specifically, it contains a version field that specifies the current operCypher version
        /// being used by the engine.
        /// </para>
        /// </summary>
        public QueryLanguageVersion Opencypher
        {
            get { return this._opencypher; }
            set { this._opencypher = value; }
        }

        // Check to see if Opencypher property is set
        internal bool IsSetOpencypher()
        {
            return this._opencypher != null;
        }

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// Set to <c>reader</c> if the instance is a read-replica, or to <c>writer</c> if the
        /// instance is the primary instance.
        /// </para>
        /// </summary>
        public string Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

        /// <summary>
        /// Gets and sets the property RollingBackTrxCount. 
        /// <para>
        /// If there are transactions being rolled back, this field is set to the number of such
        /// transactions. If there are none, the field doesn't appear at all.
        /// </para>
        /// </summary>
        public int? RollingBackTrxCount
        {
            get { return this._rollingBackTrxCount; }
            set { this._rollingBackTrxCount = value; }
        }

        // Check to see if RollingBackTrxCount property is set
        internal bool IsSetRollingBackTrxCount()
        {
            return this._rollingBackTrxCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RollingBackTrxEarliestStartTime. 
        /// <para>
        /// Set to the start time of the earliest transaction being rolled back. If no transactions
        /// are being rolled back, the field doesn't appear at all.
        /// </para>
        /// </summary>
        public string RollingBackTrxEarliestStartTime
        {
            get { return this._rollingBackTrxEarliestStartTime; }
            set { this._rollingBackTrxEarliestStartTime = value; }
        }

        // Check to see if RollingBackTrxEarliestStartTime property is set
        internal bool IsSetRollingBackTrxEarliestStartTime()
        {
            return this._rollingBackTrxEarliestStartTime != null;
        }

        /// <summary>
        /// Gets and sets the property Settings. 
        /// <para>
        /// Contains information about the current settings on your DB cluster. For example, contains
        /// the current cluster query timeout setting (<c>clusterQueryTimeoutInMs</c>).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Settings
        {
            get { return this._settings; }
            set { this._settings = value; }
        }

        // Check to see if Settings property is set
        internal bool IsSetSettings()
        {
            return this._settings != null && (this._settings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Sparql. 
        /// <para>
        /// Contains information about the SPARQL query language available on your cluster. Specifically,
        /// it contains a version field that specifies the current SPARQL version being used by
        /// the engine.
        /// </para>
        /// </summary>
        public QueryLanguageVersion Sparql
        {
            get { return this._sparql; }
            set { this._sparql = value; }
        }

        // Check to see if Sparql property is set
        internal bool IsSetSparql()
        {
            return this._sparql != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// Set to the UTC time at which the current server process started.
        /// </para>
        /// </summary>
        public string StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Set to <c>healthy</c> if the instance is not experiencing problems. If the instance
        /// is recovering from a crash or from being rebooted and there are active transactions
        /// running from the latest server shutdown, status is set to <c>recovery</c>.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}