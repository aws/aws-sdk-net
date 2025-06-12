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
    /// Container for the parameters to the CreateSolutionVersion operation.
    /// Trains or retrains an active solution in a Custom dataset group. A solution is created
    /// using the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateSolution.html">CreateSolution</a>
    /// operation and must be in the ACTIVE state before calling <c>CreateSolutionVersion</c>.
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
    /// CREATE PENDING
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// CREATE IN_PROGRESS
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// ACTIVE
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// CREATE FAILED
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// CREATE STOPPING
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// CREATE STOPPED
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To get the status of the version, call <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeSolutionVersion.html">DescribeSolutionVersion</a>.
    /// Wait until the status shows as ACTIVE before calling <c>CreateCampaign</c>.
    /// </para>
    ///  
    /// <para>
    /// If the status shows as CREATE FAILED, the response includes a <c>failureReason</c>
    /// key, which describes why the job failed.
    /// </para>
    ///  
    /// <para>
    ///  <b>Related APIs</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_ListSolutionVersions.html">ListSolutionVersions</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeSolutionVersion.html">DescribeSolutionVersion</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_ListSolutions.html">ListSolutions</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateSolution.html">CreateSolution</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeSolution.html">DescribeSolution</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DeleteSolution.html">DeleteSolution</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateSolutionVersionRequest : AmazonPersonalizeRequest
    {
        private string _name;
        private string _solutionArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private TrainingMode _trainingMode;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the solution version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of <a href="https://docs.aws.amazon.com/personalize/latest/dg/tagging-resources.html">tags</a>
        /// to apply to the solution version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TrainingMode. 
        /// <para>
        /// The scope of training to be performed when creating the solution version. The default
        /// is <c>FULL</c>. This creates a completely new model based on the entirety of the training
        /// data from the datasets in your dataset group. 
        /// </para>
        ///  
        /// <para>
        /// If you use <a href="https://docs.aws.amazon.com/personalize/latest/dg/native-recipe-new-item-USER_PERSONALIZATION.html">User-Personalization</a>,
        /// you can specify a training mode of <c>UPDATE</c>. This updates the model to consider
        /// new items for recommendations. It is not a full retraining. You should still complete
        /// a full retraining weekly. If you specify <c>UPDATE</c>, Amazon Personalize will stop
        /// automatic updates for the solution version. To resume updates, create a new solution
        /// with training mode set to <c>FULL</c> and deploy it in a campaign. For more information
        /// about automatic updates, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/use-case-recipe-features.html#maintaining-with-automatic-updates">Automatic
        /// updates</a>. 
        /// </para>
        ///  
        /// <para>
        /// The <c>UPDATE</c> option can only be used when you already have an active solution
        /// version created from the input solution using the <c>FULL</c> option and the input
        /// solution was trained with the <a href="https://docs.aws.amazon.com/personalize/latest/dg/native-recipe-new-item-USER_PERSONALIZATION.html">User-Personalization</a>
        /// recipe or the legacy <a href="https://docs.aws.amazon.com/personalize/latest/dg/native-recipe-hrnn-coldstart.html">HRNN-Coldstart</a>
        /// recipe.
        /// </para>
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