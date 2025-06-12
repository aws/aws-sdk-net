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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
    /// Container for the parameters to the StartDataQualityRulesetEvaluationRun operation.
    /// Once you have a ruleset definition (either recommended or your own), you call this
    /// operation to evaluate the ruleset against a data source (Glue table). The evaluation
    /// computes results which you can retrieve with the <c>GetDataQualityResult</c> API.
    /// </summary>
    public partial class StartDataQualityRulesetEvaluationRunRequest : AmazonGlueRequest
    {
        private Dictionary<string, DataSource> _additionalDataSources = AWSConfigs.InitializeCollections ? new Dictionary<string, DataSource>() : null;
        private DataQualityEvaluationRunAdditionalRunOptions _additionalRunOptions;
        private string _clientToken;
        private DataSource _dataSource;
        private int? _numberOfWorkers;
        private string _role;
        private List<string> _rulesetNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _timeout;

        /// <summary>
        /// Gets and sets the property AdditionalDataSources. 
        /// <para>
        /// A map of reference strings to additional data sources you can specify for an evaluation
        /// run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, DataSource> AdditionalDataSources
        {
            get { return this._additionalDataSources; }
            set { this._additionalDataSources = value; }
        }

        // Check to see if AdditionalDataSources property is set
        internal bool IsSetAdditionalDataSources()
        {
            return this._additionalDataSources != null && (this._additionalDataSources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AdditionalRunOptions. 
        /// <para>
        /// Additional run options you can specify for an evaluation run.
        /// </para>
        /// </summary>
        public DataQualityEvaluationRunAdditionalRunOptions AdditionalRunOptions
        {
            get { return this._additionalRunOptions; }
            set { this._additionalRunOptions = value; }
        }

        // Check to see if AdditionalRunOptions property is set
        internal bool IsSetAdditionalRunOptions()
        {
            return this._additionalRunOptions != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Used for idempotency and is recommended to be set to a random ID (such as a UUID)
        /// to avoid creating or starting multiple instances of the same resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        /// The data source (Glue table) associated with this run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataSource DataSource
        {
            get { return this._dataSource; }
            set { this._dataSource = value; }
        }

        // Check to see if DataSource property is set
        internal bool IsSetDataSource()
        {
            return this._dataSource != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfWorkers. 
        /// <para>
        /// The number of <c>G.1X</c> workers to be used in the run. The default is 5.
        /// </para>
        /// </summary>
        public int? NumberOfWorkers
        {
            get { return this._numberOfWorkers; }
            set { this._numberOfWorkers = value; }
        }

        // Check to see if NumberOfWorkers property is set
        internal bool IsSetNumberOfWorkers()
        {
            return this._numberOfWorkers.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// An IAM role supplied to encrypt the results of the run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property RulesetNames. 
        /// <para>
        /// A list of ruleset names.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<string> RulesetNames
        {
            get { return this._rulesetNames; }
            set { this._rulesetNames = value; }
        }

        // Check to see if RulesetNames property is set
        internal bool IsSetRulesetNames()
        {
            return this._rulesetNames != null && (this._rulesetNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        /// The timeout for a run in minutes. This is the maximum time that a run can consume
        /// resources before it is terminated and enters <c>TIMEOUT</c> status. The default is
        /// 2,880 minutes (48 hours).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? Timeout
        {
            get { return this._timeout; }
            set { this._timeout = value; }
        }

        // Check to see if Timeout property is set
        internal bool IsSetTimeout()
        {
            return this._timeout.HasValue; 
        }

    }
}