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

namespace Amazon.Personalize.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSolutionVersion operation.
    /// Trains or retrains an active solution. A solution is created using the <a>CreateSolution</a>
    /// operation and must be in the ACTIVE state before calling <code>CreateSolutionVersion</code>.
    /// A new version of the solution is created every time you call this operation.
    /// 
    ///  
    /// <para>
    ///  <b>Status</b> 
    /// </para>
    ///  
    /// <para>
    /// A solution version can be in one of the following states:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// CREATE PENDING &gt; CREATE IN_PROGRESS &gt; ACTIVE -or- CREATE FAILED
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To get the status of the version, call <a>DescribeSolutionVersion</a>. Wait until
    /// the status shows as ACTIVE before calling <code>CreateCampaign</code>.
    /// </para>
    ///  
    /// <para>
    /// If the status shows as CREATE FAILED, the response includes a <code>failureReason</code>
    /// key, which describes why the job failed.
    /// </para>
    ///  <p class="title"> <b>Related APIs</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>ListSolutionVersions</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeSolutionVersion</a> 
    /// </para>
    ///  </li> </ul> <ul> <li> 
    /// <para>
    ///  <a>ListSolutions</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>CreateSolution</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeSolution</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteSolution</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateSolutionVersionRequest : AmazonPersonalizeRequest
    {
        private string _solutionArn;
        private TrainingMode _trainingMode;

        /// <summary>
        /// Gets and sets the property SolutionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the solution containing the training configuration
        /// information.
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
        /// Gets and sets the property TrainingMode. 
        /// <para>
        /// The scope of training to be performed when creating the solution version. The <code>FULL</code>
        /// option trains the solution version based on the entirety of the input solution's training
        /// data, while the <code>UPDATE</code> option processes only the data that has changed
        /// in comparison to the input solution. Choose <code>UPDATE</code> when you want to incrementally
        /// update your solution version instead of creating an entirely new one.
        /// </para>
        ///  <important> 
        /// <para>
        /// The <code>UPDATE</code> option can only be used when you already have an active solution
        /// version created from the input solution using the <code>FULL</code> option and the
        /// input solution was trained with the <a>native-recipe-hrnn-coldstart</a> recipe.
        /// </para>
        ///  </important>
        /// </summary>
        public TrainingMode TrainingMode
        {
            get { return this._trainingMode; }
            set { this._trainingMode = value; }
        }

        // Check to see if TrainingMode property is set
        internal bool IsSetTrainingMode()
        {
            return this._trainingMode != null;
        }

    }
}