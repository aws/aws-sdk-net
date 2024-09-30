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
    /// An object that provides information about a solution. A solution includes the custom
    /// recipe, customized parameters, and trained models (Solution Versions) that Amazon
    /// Personalize uses to generate recommendations. 
    /// </para>
    ///  
    /// <para>
    /// After you create a solution, you can’t change its configuration. If you need to make
    /// changes, you can <a href="https://docs.aws.amazon.com/personalize/latest/dg/cloning-solution.html">clone
    /// the solution</a> with the Amazon Personalize console or create a new one.
    /// </para>
    /// </summary>
    public partial class Solution
    {
        private AutoMLResult _automlResult;
        private DateTime? _creationDateTime;
        private string _datasetGroupArn;
        private string _eventType;
        private DateTime? _lastUpdatedDateTime;
        private SolutionUpdateSummary _latestSolutionUpdate;
        private SolutionVersionSummary _latestSolutionVersion;
        private string _name;
        private bool? _performAutoML;
        private bool? _performAutoTraining;
        private bool? _performhpo;
        private string _recipeArn;
        private string _solutionArn;
        private SolutionConfig _solutionConfig;
        private string _status;

        /// <summary>
        /// Gets and sets the property AutoMLResult. 
        /// <para>
        /// When <c>performAutoML</c> is true, specifies the best recipe found.
        /// </para>
        /// </summary>
        public AutoMLResult AutoMLResult
        {
            get { return this._automlResult; }
            set { this._automlResult = value; }
        }

        // Check to see if AutoMLResult property is set
        internal bool IsSetAutoMLResult()
        {
            return this._automlResult != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The creation date and time (in Unix time) of the solution.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime
        {
            get { return this._creationDateTime; }
            set { this._creationDateTime = value; }
        }

        // Check to see if CreationDateTime property is set
        internal bool IsSetCreationDateTime()
        {
            return this._creationDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DatasetGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the dataset group that provides the training data.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
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
        /// The event type (for example, 'click' or 'like') that is used for training the model.
        /// If no <c>eventType</c> is provided, Amazon Personalize uses all interactions for training
        /// with equal weight regardless of type.
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
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The date and time (in Unix time) that the solution was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime
        {
            get { return this._lastUpdatedDateTime; }
            set { this._lastUpdatedDateTime = value; }
        }

        // Check to see if LastUpdatedDateTime property is set
        internal bool IsSetLastUpdatedDateTime()
        {
            return this._lastUpdatedDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatestSolutionUpdate. 
        /// <para>
        /// Provides a summary of the latest updates to the solution.
        /// </para>
        /// </summary>
        public SolutionUpdateSummary LatestSolutionUpdate
        {
            get { return this._latestSolutionUpdate; }
            set { this._latestSolutionUpdate = value; }
        }

        // Check to see if LatestSolutionUpdate property is set
        internal bool IsSetLatestSolutionUpdate()
        {
            return this._latestSolutionUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property LatestSolutionVersion. 
        /// <para>
        /// Describes the latest version of the solution, including the status and the ARN.
        /// </para>
        /// </summary>
        public SolutionVersionSummary LatestSolutionVersion
        {
            get { return this._latestSolutionVersion; }
            set { this._latestSolutionVersion = value; }
        }

        // Check to see if LatestSolutionVersion property is set
        internal bool IsSetLatestSolutionVersion()
        {
            return this._latestSolutionVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the solution.
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
        /// Gets and sets the property PerformAutoML. <important> 
        /// <para>
        /// We don't recommend enabling automated machine learning. Instead, match your use case
        /// to the available Amazon Personalize recipes. For more information, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/determining-use-case.html">Determining
        /// your use case.</a> 
        /// </para>
        ///  </important> 
        /// <para>
        /// When true, Amazon Personalize performs a search for the best USER_PERSONALIZATION
        /// recipe from the list specified in the solution configuration (<c>recipeArn</c> must
        /// not be specified). When false (the default), Amazon Personalize uses <c>recipeArn</c>
        /// for training.
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
        /// Specifies whether the solution automatically creates solution versions. The default
        /// is <c>True</c> and the solution automatically creates new solution versions every
        /// 7 days.
        /// </para>
        ///  
        /// <para>
        /// For more information about auto training, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/customizing-solution-config.html">Creating
        /// and configuring a solution</a>.
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
        /// Whether to perform hyperparameter optimization (HPO) on the chosen recipe. The default
        /// is <c>false</c>.
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
        /// The ARN of the recipe used to create the solution. This is required when <c>performAutoML</c>
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
        /// Gets and sets the property SolutionArn. 
        /// <para>
        /// The ARN of the solution.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
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
        /// Gets and sets the property SolutionConfig. 
        /// <para>
        /// Describes the configuration properties for the solution.
        /// </para>
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the solution.
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
        /// </summary>
        [AWSProperty(Max=256)]
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}