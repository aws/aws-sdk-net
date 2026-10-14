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
    /// Container for the parameters to the StartDataQualityRuleRecommendationRun operation.
    /// Starts a recommendation run that is used to generate rules when you don't know what
    /// rules to write. Glue Data Quality analyzes the data and comes up with recommendations
    /// for a potential ruleset. You can then triage the ruleset and modify the generated
    /// ruleset to your liking. <para> Recommendation runs are automatically deleted after
    /// 90 days. </para>
    /// </summary>
    public partial class StartDataQualityRuleRecommendationRunRequest : AmazonGlueRequest
    {
        /// <summary>
        /// Gets and sets the property AdditionalRunOptions. 
        /// <para>
        /// Additional run options you can specify for a recommendation run.
        /// </para>
        /// </summary>
        public DataQualityRuleRecommendationRunAdditionalRunOptions AdditionalRunOptions { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalRunOptions property is set.
        /// </summary>
        internal bool IsSetAdditionalRunOptions() => this.AdditionalRunOptions != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Used for idempotency and is recommended to be set to a random ID (such as a UUID)
        /// to avoid creating or starting multiple instances of the same resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property CreatedRulesetName. 
        /// <para>
        /// A name for the ruleset.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string CreatedRulesetName { get; set; }

        /// <summary>
        /// Checks to see if the CreatedRulesetName property is set.
        /// </summary>
        internal bool IsSetCreatedRulesetName() => this.CreatedRulesetName != null;

        /// <summary>
        /// Gets and sets the property DataQualitySecurityConfiguration. 
        /// <para>
        /// The name of the security configuration created with the data quality encryption option.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DataQualitySecurityConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DataQualitySecurityConfiguration property is set.
        /// </summary>
        internal bool IsSetDataQualitySecurityConfiguration() => this.DataQualitySecurityConfiguration != null;

        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        /// The data source (Glue table) associated with this run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataSource DataSource { get; set; }

        /// <summary>
        /// Checks to see if the DataSource property is set.
        /// </summary>
        internal bool IsSetDataSource() => this.DataSource != null;

        /// <summary>
        /// Gets and sets the property NumberOfWorkers. 
        /// <para>
        /// The number of <c>G.1X</c> workers to be used in the run. The default is 5.
        /// </para>
        /// </summary>
        public int? NumberOfWorkers { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfWorkers property is set.
        /// </summary>
        internal bool IsSetNumberOfWorkers() => this.NumberOfWorkers.HasValue;

        /// <summary>
        /// Gets and sets the property RecommendationMode. 
        /// <para>
        /// The mode that Glue Data Quality uses to recommend rules.
        /// </para>
        ///  
        /// <para>
        /// The default is <c>BASIC</c>.
        /// </para>
        /// </summary>
        public RecommendationMode RecommendationMode { get; set; }

        /// <summary>
        /// Checks to see if the RecommendationMode property is set.
        /// </summary>
        internal bool IsSetRecommendationMode() => this.RecommendationMode != null;

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The IAM role that Glue assumes to access resources for the run.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/glue/latest/dg/data-quality-authorization.html">Configure
        /// IAM permissions for Glue Data Quality</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Role { get; set; }

        /// <summary>
        /// Checks to see if the Role property is set.
        /// </summary>
        internal bool IsSetRole() => this.Role != null;

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        /// The timeout for a run in minutes. This is the maximum time that a run can consume
        /// resources before it is terminated and enters <c>TIMEOUT</c> status. The default is
        /// 2,880 minutes (48 hours).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? Timeout { get; set; }

        /// <summary>
        /// Checks to see if the Timeout property is set.
        /// </summary>
        internal bool IsSetTimeout() => this.Timeout.HasValue;
    }
}
