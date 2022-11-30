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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// This is the response object from the GetDataQualityRuleset operation.
    /// </summary>
    public partial class GetDataQualityRulesetResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdOn;
        private string _description;
        private DateTime? _lastModifiedOn;
        private string _name;
        private string _recommendationRunId;
        private string _ruleset;
        private DataQualityTargetTable _targetTable;

        /// <summary>
        /// Gets and sets the property CreatedOn. 
        /// <para>
        /// A timestamp. The time and date that this data quality ruleset was created.
        /// </para>
        /// </summary>
        public DateTime CreatedOn
        {
            get { return this._createdOn.GetValueOrDefault(); }
            set { this._createdOn = value; }
        }

        // Check to see if CreatedOn property is set
        internal bool IsSetCreatedOn()
        {
            return this._createdOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the ruleset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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
        /// Gets and sets the property LastModifiedOn. 
        /// <para>
        /// A timestamp. The last point in time when this data quality ruleset was modified.
        /// </para>
        /// </summary>
        public DateTime LastModifiedOn
        {
            get { return this._lastModifiedOn.GetValueOrDefault(); }
            set { this._lastModifiedOn = value; }
        }

        // Check to see if LastModifiedOn property is set
        internal bool IsSetLastModifiedOn()
        {
            return this._lastModifiedOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the ruleset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property RecommendationRunId. 
        /// <para>
        /// When a ruleset was created from a recommendation run, this run ID is generated to
        /// link the two together.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string RecommendationRunId
        {
            get { return this._recommendationRunId; }
            set { this._recommendationRunId = value; }
        }

        // Check to see if RecommendationRunId property is set
        internal bool IsSetRecommendationRunId()
        {
            return this._recommendationRunId != null;
        }

        /// <summary>
        /// Gets and sets the property Ruleset. 
        /// <para>
        /// A Data Quality Definition Language (DQDL) ruleset. For more information, see the Glue
        /// developer guide.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65536)]
        public string Ruleset
        {
            get { return this._ruleset; }
            set { this._ruleset = value; }
        }

        // Check to see if Ruleset property is set
        internal bool IsSetRuleset()
        {
            return this._ruleset != null;
        }

        /// <summary>
        /// Gets and sets the property TargetTable. 
        /// <para>
        /// The name and database name of the target table.
        /// </para>
        /// </summary>
        public DataQualityTargetTable TargetTable
        {
            get { return this._targetTable; }
            set { this._targetTable = value; }
        }

        // Check to see if TargetTable property is set
        internal bool IsSetTargetTable()
        {
            return this._targetTable != null;
        }

    }
}