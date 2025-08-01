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
 * Do not modify this file. This file is generated from the arc-region-switch-2022-07-26.normal.json service model.
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
namespace Amazon.ARCRegionswitch.Model
{
    /// <summary>
    /// This is the response object from the GetPlanEvaluationStatus operation.
    /// </summary>
    public partial class GetPlanEvaluationStatusResponse : AmazonWebServiceResponse
    {
        private EvaluationStatus _evaluationState;
        private string _lastEvaluatedVersion;
        private DateTime? _lastEvaluationTime;
        private string _nextToken;
        private string _planArn;
        private string _region;
        private List<ResourceWarning> _warnings = AWSConfigs.InitializeCollections ? new List<ResourceWarning>() : null;

        /// <summary>
        /// Gets and sets the property EvaluationState. 
        /// <para>
        /// The evaluation state for the plan.
        /// </para>
        /// </summary>
        public EvaluationStatus EvaluationState
        {
            get { return this._evaluationState; }
            set { this._evaluationState = value; }
        }

        // Check to see if EvaluationState property is set
        internal bool IsSetEvaluationState()
        {
            return this._evaluationState != null;
        }

        /// <summary>
        /// Gets and sets the property LastEvaluatedVersion. 
        /// <para>
        /// The version of the last evaluation of the plan.
        /// </para>
        /// </summary>
        public string LastEvaluatedVersion
        {
            get { return this._lastEvaluatedVersion; }
            set { this._lastEvaluatedVersion = value; }
        }

        // Check to see if LastEvaluatedVersion property is set
        internal bool IsSetLastEvaluatedVersion()
        {
            return this._lastEvaluatedVersion != null;
        }

        /// <summary>
        /// Gets and sets the property LastEvaluationTime. 
        /// <para>
        /// The time of the last time that Region switch ran an evaluation of the plan.
        /// </para>
        /// </summary>
        public DateTime? LastEvaluationTime
        {
            get { return this._lastEvaluationTime; }
            set { this._lastEvaluationTime = value; }
        }

        // Check to see if LastEvaluationTime property is set
        internal bool IsSetLastEvaluationTime()
        {
            return this._lastEvaluationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Specifies that you want to receive the next page of results. Valid only if you received
        /// a <c>nextToken</c> response in the previous request. If you did, it indicates that
        /// more output is available. Set this parameter to the value provided by the previous
        /// call's <c>nextToken</c> response to request the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property PlanArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PlanArn
        {
            get { return this._planArn; }
            set { this._planArn = value; }
        }

        // Check to see if PlanArn property is set
        internal bool IsSetPlanArn()
        {
            return this._planArn != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region for the plan.
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property Warnings. 
        /// <para>
        /// The current evaluation warnings for the plan. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResourceWarning> Warnings
        {
            get { return this._warnings; }
            set { this._warnings = value; }
        }

        // Check to see if Warnings property is set
        internal bool IsSetWarnings()
        {
            return this._warnings != null && (this._warnings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}