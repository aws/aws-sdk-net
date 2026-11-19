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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Counts of the sessions, scenarios and examples a dataset generation has processed.
    /// </summary>
    public partial class GenerationResults
    {
        /// <summary>
        /// Gets and sets the property ExamplesWithGroundTruth. 
        /// <para>
        /// The number of added examples that have reference fields.
        /// </para>
        /// </summary>
        public int? ExamplesWithGroundTruth { get; set; }

        /// <summary>
        /// Checks to see if the ExamplesWithGroundTruth property is set.
        /// </summary>
        internal bool IsSetExamplesWithGroundTruth() => this.ExamplesWithGroundTruth.HasValue;

        /// <summary>
        /// Gets and sets the property ExamplesWritten. 
        /// <para>
        /// The number of examples added to the dataset's draft.
        /// </para>
        /// </summary>
        public int? ExamplesWritten { get; set; }

        /// <summary>
        /// Checks to see if the ExamplesWritten property is set.
        /// </summary>
        internal bool IsSetExamplesWritten() => this.ExamplesWritten.HasValue;

        /// <summary>
        /// Gets and sets the property ScenariosDeduplicated. 
        /// <para>
        /// The number of scenarios left out as duplicates, of each other or of examples already
        /// in the draft.
        /// </para>
        /// </summary>
        public int? ScenariosDeduplicated { get; set; }

        /// <summary>
        /// Checks to see if the ScenariosDeduplicated property is set.
        /// </summary>
        internal bool IsSetScenariosDeduplicated() => this.ScenariosDeduplicated.HasValue;

        /// <summary>
        /// Gets and sets the property ScenariosGenerated. 
        /// <para>
        /// The number of scenarios generated.
        /// </para>
        /// </summary>
        public int? ScenariosGenerated { get; set; }

        /// <summary>
        /// Checks to see if the ScenariosGenerated property is set.
        /// </summary>
        internal bool IsSetScenariosGenerated() => this.ScenariosGenerated.HasValue;

        /// <summary>
        /// Gets and sets the property SessionsFailed. 
        /// <para>
        /// The number of sessions dropped because of an error. See <c>errorDetails</c> for the
        /// errors.
        /// </para>
        /// </summary>
        public int? SessionsFailed { get; set; }

        /// <summary>
        /// Checks to see if the SessionsFailed property is set.
        /// </summary>
        internal bool IsSetSessionsFailed() => this.SessionsFailed.HasValue;

        /// <summary>
        /// Gets and sets the property SessionsMatched. 
        /// <para>
        /// The number of sessions that matched the filters or were named in the request, before
        /// sampling. This includes sessions that later failed.
        /// </para>
        /// </summary>
        public int? SessionsMatched { get; set; }

        /// <summary>
        /// Checks to see if the SessionsMatched property is set.
        /// </summary>
        internal bool IsSetSessionsMatched() => this.SessionsMatched.HasValue;

        /// <summary>
        /// Gets and sets the property SessionsSelected. 
        /// <para>
        /// The number of sessions left after sampling.
        /// </para>
        /// </summary>
        public int? SessionsSelected { get; set; }

        /// <summary>
        /// Checks to see if the SessionsSelected property is set.
        /// </summary>
        internal bool IsSetSessionsSelected() => this.SessionsSelected.HasValue;

        /// <summary>
        /// Gets and sets the property SessionsUnscored. 
        /// <para>
        /// The number of sessions left out because an evaluator filter had no result to compare,
        /// either because the session wasn't evaluated yet or because the evaluation failed.
        /// </para>
        /// </summary>
        public int? SessionsUnscored { get; set; }

        /// <summary>
        /// Checks to see if the SessionsUnscored property is set.
        /// </summary>
        internal bool IsSetSessionsUnscored() => this.SessionsUnscored.HasValue;
    }
}
