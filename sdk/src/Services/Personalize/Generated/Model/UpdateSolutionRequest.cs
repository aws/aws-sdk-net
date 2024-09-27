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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
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
namespace Amazon.Personalize.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSolution operation.
    /// Updates an Amazon Personalize solution to use a different automatic training configuration.
    /// When you update a solution, you can change whether the solution uses automatic training,
    /// and you can change the training frequency. For more information about updating a solution,
    /// see <a href="https://docs.aws.amazon.com/personalize/latest/dg/updating-solution.html">Updating
    /// a solution</a>.
    /// 
    ///  
    /// <para>
    /// A solution update can be in one of the following states:
    /// </para>
    ///  
    /// <para>
    /// CREATE PENDING &gt; CREATE IN_PROGRESS &gt; ACTIVE -or- CREATE FAILED
    /// </para>
    ///  
    /// <para>
    /// To get the status of a solution update, call the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeSolution.html">DescribeSolution</a>
    /// API operation and find the status in the <c>latestSolutionUpdate</c>. 
    /// </para>
    /// </summary>
    public partial class UpdateSolutionRequest : AmazonPersonalizeRequest
    {
        private bool? _performAutoTraining;
        private string _solutionArn;
        private SolutionUpdateConfig _solutionUpdateConfig;

        /// <summary>
        /// Gets and sets the property PerformAutoTraining. 
        /// <para>
        /// Whether the solution uses automatic training to create new solution versions (trained
        /// models). You can change the training frequency by specifying a <c>schedulingExpression</c>
        /// in the <c>AutoTrainingConfig</c> as part of solution configuration. 
        /// </para>
        ///  
        /// <para>
        ///  If you turn on automatic training, the first automatic training starts within one
        /// hour after the solution update completes. If you manually create a solution version
        /// within the hour, the solution skips the first automatic training. For more information
        /// about automatic training, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/solution-config-auto-training.html">Configuring
        /// automatic training</a>. 
        /// </para>
        ///  
        /// <para>
        ///  After training starts, you can get the solution version's Amazon Resource Name (ARN)
        /// with the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_ListSolutionVersions.html">ListSolutionVersions</a>
        /// API operation. To get its status, use the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeSolutionVersion.html">DescribeSolutionVersion</a>.
        /// 
        /// </para>
        /// </summary>
        public bool? PerformAutoTraining
        {
            get { return this._performAutoTraining; }
            set { this._performAutoTraining = value; }
        }

        // Check to see if PerformAutoTraining property is set
        internal bool IsSetPerformAutoTraining()
        {
            return this._performAutoTraining.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SolutionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the solution to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string SolutionArn
        {
            get { return this._solutionArn; }
            set { this._solutionArn = value; }
        }

        // Check to see if SolutionArn property is set
        internal bool IsSetSolutionArn()
        {
            return this._solutionArn != null;
        }

        /// <summary>
        /// Gets and sets the property SolutionUpdateConfig. 
        /// <para>
        /// The new configuration details of the solution.
        /// </para>
        /// </summary>
        public SolutionUpdateConfig SolutionUpdateConfig
        {
            get { return this._solutionUpdateConfig; }
            set { this._solutionUpdateConfig = value; }
        }

        // Check to see if SolutionUpdateConfig property is set
        internal bool IsSetSolutionUpdateConfig()
        {
            return this._solutionUpdateConfig != null;
        }

    }
}