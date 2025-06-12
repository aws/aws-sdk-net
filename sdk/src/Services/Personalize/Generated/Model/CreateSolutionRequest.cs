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
    /// Container for the parameters to the CreateSolution operation.
    /// <important> 
    /// <para>
    /// By default, all new solutions use automatic training. With automatic training, you
    /// incur training costs while your solution is active. To avoid unnecessary costs, when
    /// you are finished you can <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_UpdateSolution.html">update
    /// the solution</a> to turn off automatic training. For information about training costs,
    /// see <a href="https://aws.amazon.com/personalize/pricing/">Amazon Personalize pricing</a>.
    /// </para>
    ///  </important> 
    /// <para>
    /// Creates the configuration for training a model (creating a solution version). This
    /// configuration includes the recipe to use for model training and optional training
    /// configuration, such as columns to use in training and feature transformation parameters.
    /// For more information about configuring a solution, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/customizing-solution-config.html">Creating
    /// and configuring a solution</a>. 
    /// </para>
    ///  
    /// <para>
    ///  By default, new solutions use automatic training to create solution versions every
    /// 7 days. You can change the training frequency. Automatic solution version creation
    /// starts within one hour after the solution is ACTIVE. If you manually create a solution
    /// version within the hour, the solution skips the first automatic training. For more
    /// information, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/solution-config-auto-training.html">Configuring
    /// automatic training</a>.
    /// </para>
    ///  
    /// <para>
    ///  To turn off automatic training, set <c>performAutoTraining</c> to false. If you turn
    /// off automatic training, you must manually create a solution version by calling the
    /// <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateSolutionVersion.html">CreateSolutionVersion</a>
    /// operation.
    /// </para>
    ///  
    /// <para>
    /// After training starts, you can get the solution version's Amazon Resource Name (ARN)
    /// with the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_ListSolutionVersions.html">ListSolutionVersions</a>
    /// API operation. To get its status, use the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeSolutionVersion.html">DescribeSolutionVersion</a>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// After training completes you can evaluate model accuracy by calling <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_GetSolutionMetrics.html">GetSolutionMetrics</a>.
    /// When you are satisfied with the solution version, you deploy it using <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateCampaign.html">CreateCampaign</a>.
    /// The campaign provides recommendations to a client through the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_RS_GetRecommendations.html">GetRecommendations</a>
    /// API.
    /// </para>
    ///  <note> 
    /// <para>
    /// Amazon Personalize doesn't support configuring the <c>hpoObjective</c> for solution
    /// hyperparameter optimization at this time.
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>Status</b> 
    /// </para>
    ///  
    /// <para>
    /// A solution can be in one of the following states:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// CREATE PENDING &gt; CREATE IN_PROGRESS &gt; ACTIVE -or- CREATE FAILED
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// DELETE PENDING &gt; DELETE IN_PROGRESS
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To get the status of the solution, call <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeSolution.html">DescribeSolution</a>.
    /// If you use manual training, the status must be ACTIVE before you call <c>CreateSolutionVersion</c>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Related APIs</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_UpdateSolution.html">UpdateSolution</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_ListSolutions.html">ListSolutions</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateSolutionVersion.html">CreateSolutionVersion</a>
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
    ///  </li> </ul> <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_ListSolutionVersions.html">ListSolutionVersions</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeSolutionVersion.html">DescribeSolutionVersion</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateSolutionRequest : AmazonPersonalizeRequest
    {
        private string _datasetGroupArn;
        private string _eventType;
        private string _name;
        private bool? _performAutoML;
        private bool? _performAutoTraining;
        private bool? _performhpo;
        private string _recipeArn;
        private SolutionConfig _solutionConfig;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property DatasetGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the dataset group that provides the training data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string DatasetGroupArn
        {
            get { return this._datasetGroupArn; }
            set { this._datasetGroupArn = value; }
        }

        // Check to see if DatasetGroupArn property is set
        internal bool IsSetDatasetGroupArn()
        {
            return this._datasetGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// When your have multiple event types (using an <c>EVENT_TYPE</c> schema field), this
        /// parameter specifies which event type (for example, 'click' or 'like') is used for
        /// training the model.
        /// </para>
        ///  
        /// <para>
        /// If you do not provide an <c>eventType</c>, Amazon Personalize will use all interactions
        /// for training with equal weight regardless of type.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string EventType
        {
            get { return this._eventType; }
            set { this._eventType = value; }
        }

        // Check to see if EventType property is set
        internal bool IsSetEventType()
        {
            return this._eventType != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the solution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
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
        /// Gets and sets the property PerformAutoML. <important> 
        /// <para>
        /// We don't recommend enabling automated machine learning. Instead, match your use case
        /// to the available Amazon Personalize recipes. For more information, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/working-with-predefined-recipes.html">Choosing
        /// a recipe</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// Whether to perform automated machine learning (AutoML). The default is <c>false</c>.
        /// For this case, you must specify <c>recipeArn</c>.
        /// </para>
        ///  
        /// <para>
        /// When set to <c>true</c>, Amazon Personalize analyzes your training data and selects
        /// the optimal USER_PERSONALIZATION recipe and hyperparameters. In this case, you must
        /// omit <c>recipeArn</c>. Amazon Personalize determines the optimal recipe by running
        /// tests with different values for the hyperparameters. AutoML lengthens the training
        /// process as compared to selecting a specific recipe.
        /// </para>
        /// </summary>
        public bool? PerformAutoML
        {
            get { return this._performAutoML; }
            set { this._performAutoML = value; }
        }

        // Check to see if PerformAutoML property is set
        internal bool IsSetPerformAutoML()
        {
            return this._performAutoML.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PerformAutoTraining. 
        /// <para>
        /// Whether the solution uses automatic training to create new solution versions (trained
        /// models). The default is <c>True</c> and the solution automatically creates new solution
        /// versions every 7 days. You can change the training frequency by specifying a <c>schedulingExpression</c>
        /// in the <c>AutoTrainingConfig</c> as part of solution configuration. For more information
        /// about automatic training, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/solution-config-auto-training.html">Configuring
        /// automatic training</a>.
        /// </para>
        ///  
        /// <para>
        ///  Automatic solution version creation starts within one hour after the solution is
        /// ACTIVE. If you manually create a solution version within the hour, the solution skips
        /// the first automatic training. 
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
        /// Gets and sets the property PerformHPO. 
        /// <para>
        /// Whether to perform hyperparameter optimization (HPO) on the specified or selected
        /// recipe. The default is <c>false</c>.
        /// </para>
        ///  
        /// <para>
        /// When performing AutoML, this parameter is always <c>true</c> and you should not set
        /// it to <c>false</c>.
        /// </para>
        /// </summary>
        public bool? PerformHPO
        {
            get { return this._performhpo; }
            set { this._performhpo = value; }
        }

        // Check to see if PerformHPO property is set
        internal bool IsSetPerformHPO()
        {
            return this._performhpo.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecipeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the recipe to use for model training. This is required
        /// when <c>performAutoML</c> is false. For information about different Amazon Personalize
        /// recipes and their ARNs, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/working-with-predefined-recipes.html">Choosing
        /// a recipe</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string RecipeArn
        {
            get { return this._recipeArn; }
            set { this._recipeArn = value; }
        }

        // Check to see if RecipeArn property is set
        internal bool IsSetRecipeArn()
        {
            return this._recipeArn != null;
        }

        /// <summary>
        /// Gets and sets the property SolutionConfig. 
        /// <para>
        /// The configuration properties for the solution. When <c>performAutoML</c> is set to
        /// true, Amazon Personalize only evaluates the <c>autoMLConfig</c> section of the solution
        /// configuration.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Personalize doesn't support configuring the <c>hpoObjective</c> at this time.
        /// </para>
        ///  </note>
        /// </summary>
        public SolutionConfig SolutionConfig
        {
            get { return this._solutionConfig; }
            set { this._solutionConfig = value; }
        }

        // Check to see if SolutionConfig property is set
        internal bool IsSetSolutionConfig()
        {
            return this._solutionConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of <a href="https://docs.aws.amazon.com/personalize/latest/dg/tagging-resources.html">tags</a>
        /// to apply to the solution.
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

    }
}