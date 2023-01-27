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
 * Do not modify this file. This file is generated from the kendra-ranking-2022-10-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KendraRanking.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRescoreExecutionPlan operation.
    /// Creates a rescore execution plan. A rescore execution plan is an Amazon Kendra Intelligent
    /// Ranking resource used for provisioning the <code>Rescore</code> API. You set the number
    /// of capacity units that you require for Amazon Kendra Intelligent Ranking to rescore
    /// or re-rank a search service's results.
    /// 
    ///  
    /// <para>
    /// For an example of using the <code>CreateRescoreExecutionPlan</code> API, including
    /// using the Python and Java SDKs, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/search-service-rerank.html">Semantically
    /// ranking a search service's results</a>.
    /// </para>
    /// </summary>
    public partial class CreateRescoreExecutionPlanRequest : AmazonKendraRankingRequest
    {
        private CapacityUnitsConfiguration _capacityUnits;
        private string _clientToken;
        private string _description;
        private string _name;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property CapacityUnits. 
        /// <para>
        /// You can set additional capacity units to meet the needs of your rescore execution
        /// plan. You are given a single capacity unit by default. If you want to use the default
        /// capacity, you don't set additional capacity units. For more information on the default
        /// capacity and additional capacity units, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/adjusting-capacity.html">Adjusting
        /// capacity</a>.
        /// </para>
        /// </summary>
        public CapacityUnitsConfiguration CapacityUnits
        {
            get { return this._capacityUnits; }
            set { this._capacityUnits = value; }
        }

        // Check to see if CapacityUnits property is set
        internal bool IsSetCapacityUnits()
        {
            return this._capacityUnits != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A token that you provide to identify the request to create a rescore execution plan.
        /// Multiple calls to the <code>CreateRescoreExecutionPlanRequest</code> API with the
        /// same client token will create only one rescore execution plan.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the rescore execution plan.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the rescore execution plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs that identify or categorize your rescore execution plan.
        /// You can also use tags to help control access to the rescore execution plan. Tag keys
        /// and values can consist of Unicode letters, digits, white space, and any of the following
        /// symbols: _ . : / = + - @.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}