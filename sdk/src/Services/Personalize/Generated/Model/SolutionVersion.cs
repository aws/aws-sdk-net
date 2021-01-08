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
    /// An object that provides information about a specific version of a <a>Solution</a>.
    /// </summary>
    public partial class SolutionVersion
    {
        private DateTime? _creationDateTime;
        private string _datasetGroupArn;
        private string _eventType;
        private string _failureReason;
        private DateTime? _lastUpdatedDateTime;
        private bool? _performAutoML;
        private bool? _performhpo;
        private string _recipeArn;
        private string _solutionArn;
        private SolutionConfig _solutionConfig;
        private string _solutionVersionArn;
        private string _status;
        private double? _trainingHours;
        private TrainingMode _trainingMode;
        private TunedHPOParams _tunedhpoParams;

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The date and time (in Unix time) that this version of the solution was created.
        /// </para>
        /// </summary>
        public DateTime CreationDateTime
        {
            get { return this._creationDateTime.GetValueOrDefault(); }
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
        /// The Amazon Resource Name (ARN) of the dataset group providing the training data.
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
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If training a solution version fails, the reason for the failure.
        /// </para>
        /// </summary>
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The date and time (in Unix time) that the solution was last updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedDateTime
        {
            get { return this._lastUpdatedDateTime.GetValueOrDefault(); }
            set { this._lastUpdatedDateTime = value; }
        }

        // Check to see if LastUpdatedDateTime property is set
        internal bool IsSetLastUpdatedDateTime()
        {
            return this._lastUpdatedDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PerformAutoML. 
        /// <para>
        /// When true, Amazon Personalize searches for the most optimal recipe according to the
        /// solution configuration. When false (the default), Amazon Personalize uses <code>recipeArn</code>.
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
        /// Whether to perform hyperparameter optimization (HPO) on the chosen recipe. The default
        /// is <code>false</code>.
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
        /// The ARN of the recipe used in the solution.
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
        /// Gets and sets the property SolutionVersionArn. 
        /// <para>
        /// The ARN of the solution version.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string SolutionVersionArn
        {
            get { return this._solutionVersionArn; }
            set { this._solutionVersionArn = value; }
        }

        // Check to see if SolutionVersionArn property is set
        internal bool IsSetSolutionVersionArn()
        {
            return this._solutionVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the solution version.
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

        /// <summary>
        /// Gets and sets the property TrainingHours. 
        /// <para>
        /// The time used to train the model. You are billed for the time it takes to train a
        /// model. This field is visible only after Amazon Personalize successfully trains a model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public double TrainingHours
        {
            get { return this._trainingHours.GetValueOrDefault(); }
            set { this._trainingHours = value; }
        }

        // Check to see if TrainingHours property is set
        internal bool IsSetTrainingHours()
        {
            return this._trainingHours.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrainingMode. 
        /// <para>
        /// The scope of training used to create the solution version. The <code>FULL</code> option
        /// trains the solution version based on the entirety of the input solution's training
        /// data, while the <code>UPDATE</code> option processes only the training data that has
        /// changed since the creation of the last solution version. Choose <code>UPDATE</code>
        /// when you want to start recommending items added to the dataset without retraining
        /// the model.
        /// </para>
        ///  <important> 
        /// <para>
        /// The <code>UPDATE</code> option can only be used after you've created a solution version
        /// with the <code>FULL</code> option and the training solution uses the <a>native-recipe-hrnn-coldstart</a>.
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

        /// <summary>
        /// Gets and sets the property TunedHPOParams. 
        /// <para>
        /// If hyperparameter optimization was performed, contains the hyperparameter values of
        /// the best performing model.
        /// </para>
        /// </summary>
        public TunedHPOParams TunedHPOParams
        {
            get { return this._tunedhpoParams; }
            set { this._tunedhpoParams = value; }
        }

        // Check to see if TunedHPOParams property is set
        internal bool IsSetTunedHPOParams()
        {
            return this._tunedhpoParams != null;
        }

    }
}