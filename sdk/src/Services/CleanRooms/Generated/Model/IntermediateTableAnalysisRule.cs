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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Contains the details of an analysis rule for an intermediate table.
    /// </summary>
    public partial class IntermediateTableAnalysisRule
    {
        private IntermediateTableAnalysisRulePolicy _analysisRulePolicy;
        private IntermediateTableAnalysisRuleType _analysisRuleType;
        private DateTime? _createTime;
        private string _intermediateTableArn;
        private string _intermediateTableIdentifier;
        private DateTime? _updateTime;

        /// <summary>
        /// Gets and sets the property AnalysisRulePolicy. 
        /// <para>
        /// The policy of the analysis rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IntermediateTableAnalysisRulePolicy AnalysisRulePolicy
        {
            get { return this._analysisRulePolicy; }
            set { this._analysisRulePolicy = value; }
        }

        // Check to see if AnalysisRulePolicy property is set
        internal bool IsSetAnalysisRulePolicy()
        {
            return this._analysisRulePolicy != null;
        }

        /// <summary>
        /// Gets and sets the property AnalysisRuleType. 
        /// <para>
        /// The type of the analysis rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IntermediateTableAnalysisRuleType AnalysisRuleType
        {
            get { return this._analysisRuleType; }
            set { this._analysisRuleType = value; }
        }

        // Check to see if AnalysisRuleType property is set
        internal bool IsSetAnalysisRuleType()
        {
            return this._analysisRuleType != null;
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time the analysis rule was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IntermediateTableArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the intermediate table associated with this analysis
        /// rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string IntermediateTableArn
        {
            get { return this._intermediateTableArn; }
            set { this._intermediateTableArn = value; }
        }

        // Check to see if IntermediateTableArn property is set
        internal bool IsSetIntermediateTableArn()
        {
            return this._intermediateTableArn != null;
        }

        /// <summary>
        /// Gets and sets the property IntermediateTableIdentifier. 
        /// <para>
        /// The unique identifier of the intermediate table associated with this analysis rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string IntermediateTableIdentifier
        {
            get { return this._intermediateTableIdentifier; }
            set { this._intermediateTableIdentifier = value; }
        }

        // Check to see if IntermediateTableIdentifier property is set
        internal bool IsSetIntermediateTableIdentifier()
        {
            return this._intermediateTableIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The time the analysis rule was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdateTime
        {
            get { return this._updateTime; }
            set { this._updateTime = value; }
        }

        // Check to see if UpdateTime property is set
        internal bool IsSetUpdateTime()
        {
            return this._updateTime.HasValue; 
        }

    }
}