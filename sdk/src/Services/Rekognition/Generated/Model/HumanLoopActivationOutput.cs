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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
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
namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Shows the results of the human in the loop evaluation. If there is no HumanLoopArn,
    /// the input did not trigger human review.
    /// </summary>
    public partial class HumanLoopActivationOutput
    {
        private string _humanLoopActivationConditionsEvaluationResults;
        private List<string> _humanLoopActivationReasons = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _humanLoopArn;

        /// <summary>
        /// Gets and sets the property HumanLoopActivationConditionsEvaluationResults. 
        /// <para>
        /// Shows the result of condition evaluations, including those conditions which activated
        /// a human review.
        /// </para>
        /// </summary>
        [AWSProperty(Max=10240)]
        public string HumanLoopActivationConditionsEvaluationResults
        {
            get { return this._humanLoopActivationConditionsEvaluationResults; }
            set { this._humanLoopActivationConditionsEvaluationResults = value; }
        }

        // Check to see if HumanLoopActivationConditionsEvaluationResults property is set
        internal bool IsSetHumanLoopActivationConditionsEvaluationResults()
        {
            return this._humanLoopActivationConditionsEvaluationResults != null;
        }

        /// <summary>
        /// Gets and sets the property HumanLoopActivationReasons. 
        /// <para>
        /// Shows if and why human review was needed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> HumanLoopActivationReasons
        {
            get { return this._humanLoopActivationReasons; }
            set { this._humanLoopActivationReasons = value; }
        }

        // Check to see if HumanLoopActivationReasons property is set
        internal bool IsSetHumanLoopActivationReasons()
        {
            return this._humanLoopActivationReasons != null && (this._humanLoopActivationReasons.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property HumanLoopArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the HumanLoop created.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string HumanLoopArn
        {
            get { return this._humanLoopArn; }
            set { this._humanLoopArn = value; }
        }

        // Check to see if HumanLoopArn property is set
        internal bool IsSetHumanLoopArn()
        {
            return this._humanLoopArn != null;
        }

    }
}