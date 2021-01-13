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
    /// Container for the parameters to the CreateSolution operation.
    /// Creates the configuration for training a model. A trained model is known as a solution.
    /// After the configuration is created, you train the model (create a solution) by calling
    /// the <a>CreateSolutionVersion</a> operation. Every time you call <code>CreateSolutionVersion</code>,
    /// a new version of the solution is created.
    /// 
    ///  
    /// <para>
    /// After creating a solution version, you check its accuracy by calling <a>GetSolutionMetrics</a>.
    /// When you are satisfied with the version, you deploy it using <a>CreateCampaign</a>.
    /// The campaign provides recommendations to a client through the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_RS_GetRecommendations.html">GetRecommendations</a>
    /// API.
    /// </para>
    ///  
    /// <para>
    /// To train a model, Amazon Personalize requires training data and a recipe. The training
    /// data comes from the dataset group that you provide in the request. A recipe specifies
    /// the training algorithm and a feature transformation. You can specify one of the predefined
    /// recipes provided by Amazon Personalize. Alternatively, you can specify <code>performAutoML</code>
    /// and Amazon Personalize will analyze your data and select the optimum USER_PERSONALIZATION
    /// recipe for you.
    /// </para>
    ///  <note> 
    /// <para>
    /// Amazon Personalize doesn't support configuring the <code>hpoObjective</code> for solution
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
    /// To get the status of the solution, call <a>DescribeSolution</a>. Wait until the status
    /// shows as ACTIVE before calling <code>CreateSolutionVersion</code>.
    /// </para>
    ///  <p class="title"> <b>Related APIs</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>ListSolutions</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>CreateSolutionVersion</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeSolution</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteSolution</a> 
    /// </para>
    ///  </li> </ul> <ul> <li> 
    /// <para>
    ///  <a>ListSolutionVersions</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeSolutionVersion</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateSolutionRequest : AmazonPersonalizeRequest
    {
        private string _datasetGroupArn;
        private string _eventType;
        private string _name;
        private bool? _performAutoML;
        private bool? _performhpo;
        private string _recipeArn;
        private SolutionConfig _solutionConfig;

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
        /// When your have multiple event types (using an <code>EVENT_TYPE</code> schema field),
        /// this parameter specifies which event type (for example, 'click' or 'like') is used
        /// for training the model.
        /// </para>
        ///  
        /// <para>
        /// If you do not provide an <code>eventType</code>, Amazon Personalize will use all interactions
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
        /// Gets and sets the property PerformAutoML. 
        /// <para>
        /// Whether to perform automated machine learning (AutoML). The default is <code>false</code>.
        /// For this case, you must specify <code>recipeArn</code>.
        /// </para>
        ///  
        /// <para>
        /// When set to <code>true</code>, Amazon Personalize analyzes your training data and
        /// selects the optimal USER_PERSONALIZATION recipe and hyperparameters. In this case,
        /// you must omit <code>recipeArn</code>. Amazon Personalize determines the optimal recipe
        /// by running tests with different values for the hyperparameters. AutoML lengthens the
        /// training process as compared to selecting a specific recipe.
        /// </para>
        /// </summary>
        public bool PerformAutoML
        {
            get { return this._performAutoML.GetValueOrDefault(); }
            set { this._performAutoML = value; }
        }

        // Check to see if PerformAutoML property is set
        internal bool IsSetPerformAutoML()
        {
            return this._performAutoML.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PerformHPO. 
        /// <para>
        /// Whether to perform hyperparameter optimization (HPO) on the specified or selected
        /// recipe. The default is <code>false</code>.
        /// </para>
        ///  
        /// <para>
        /// When performing AutoML, this parameter is always <code>true</code> and you should
        /// not set it to <code>false</code>.
        /// </para>
        /// </summary>
        public bool PerformHPO
        {
            get { return this._performhpo.GetValueOrDefault(); }
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
        /// The ARN of the recipe to use for model training. Only specified when <code>performAutoML</code>
        /// is false.
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
        /// The configuration to use with the solution. When <code>performAutoML</code> is set
        /// to true, Amazon Personalize only evaluates the <code>autoMLConfig</code> section of
        /// the solution configuration.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Personalize doesn't support configuring the <code>hpoObjective</code> at this
        /// time.
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

    }
}