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

namespace Amazon.Personalize.Model
{
    /// <summary>
    /// An object that provides information about a specific version of a <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_Solution.html">Solution</a>
    /// in a Custom dataset group.
    /// </summary>
    public partial class SolutionVersion
    {
        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The date and time (in Unix time) that this version of the solution was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationDateTime property is set.
        /// </summary>
        internal bool IsSetCreationDateTime() => this.CreationDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property DatasetGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the dataset group providing the training data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string DatasetGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the DatasetGroupArn property is set.
        /// </summary>
        internal bool IsSetDatasetGroupArn() => this.DatasetGroupArn != null;

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The event type (for example, 'click' or 'like') that is used for training the model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string EventType { get; set; }

        /// <summary>
        /// Checks to see if the EventType property is set.
        /// </summary>
        internal bool IsSetEventType() => this.EventType != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If training a solution version fails, the reason for the failure.
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The date and time (in Unix time) that the solution was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDateTime() => this.LastUpdatedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the solution version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PerformAutoML. 
        /// <para>
        /// When true, Amazon Personalize searches for the most optimal recipe according to the
        /// solution configuration. When false (the default), Amazon Personalize uses <c>recipeArn</c>.
        /// </para>
        /// </summary>
        public bool? PerformAutoML { get; set; }

        /// <summary>
        /// Checks to see if the PerformAutoML property is set.
        /// </summary>
        internal bool IsSetPerformAutoML() => this.PerformAutoML.HasValue;

        /// <summary>
        /// Gets and sets the property PerformHPO. 
        /// <para>
        /// Whether to perform hyperparameter optimization (HPO) on the chosen recipe. The default
        /// is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? PerformHPO { get; set; }

        /// <summary>
        /// Checks to see if the PerformHPO property is set.
        /// </summary>
        internal bool IsSetPerformHPO() => this.PerformHPO.HasValue;

        /// <summary>
        /// Gets and sets the property PerformIncrementalUpdate. 
        /// <para>
        /// Whether the solution version should perform an incremental update. When set to true,
        /// the training will process only the data that has changed since the latest training,
        /// similar to when trainingMode is set to UPDATE. This can only be used with solution
        /// versions that use the User-Personalization recipe.
        /// </para>
        /// </summary>
        public bool? PerformIncrementalUpdate { get; set; }

        /// <summary>
        /// Checks to see if the PerformIncrementalUpdate property is set.
        /// </summary>
        internal bool IsSetPerformIncrementalUpdate() => this.PerformIncrementalUpdate.HasValue;

        /// <summary>
        /// Gets and sets the property RecipeArn. 
        /// <para>
        /// The ARN of the recipe used in the solution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string RecipeArn { get; set; }

        /// <summary>
        /// Checks to see if the RecipeArn property is set.
        /// </summary>
        internal bool IsSetRecipeArn() => this.RecipeArn != null;

        /// <summary>
        /// Gets and sets the property SolutionArn. 
        /// <para>
        /// The ARN of the solution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string SolutionArn { get; set; }

        /// <summary>
        /// Checks to see if the SolutionArn property is set.
        /// </summary>
        internal bool IsSetSolutionArn() => this.SolutionArn != null;

        /// <summary>
        /// Gets and sets the property SolutionConfig. 
        /// <para>
        /// Describes the configuration properties for the solution.
        /// </para>
        /// </summary>
        public SolutionConfig SolutionConfig { get; set; }

        /// <summary>
        /// Checks to see if the SolutionConfig property is set.
        /// </summary>
        internal bool IsSetSolutionConfig() => this.SolutionConfig != null;

        /// <summary>
        /// Gets and sets the property SolutionVersionArn. 
        /// <para>
        /// The ARN of the solution version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string SolutionVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the SolutionVersionArn property is set.
        /// </summary>
        internal bool IsSetSolutionVersionArn() => this.SolutionVersionArn != null;

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
        ///  </li> <li> 
        /// <para>
        /// CREATE STOPPING
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE STOPPED
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TrainingHours. 
        /// <para>
        /// The time used to train the model. You are billed for the time it takes to train a
        /// model. This field is visible only after Amazon Personalize successfully trains a model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public double? TrainingHours { get; set; }

        /// <summary>
        /// Checks to see if the TrainingHours property is set.
        /// </summary>
        internal bool IsSetTrainingHours() => this.TrainingHours.HasValue;

        /// <summary>
        /// Gets and sets the property TrainingMode. 
        /// <para>
        /// The scope of training to be performed when creating the solution version. A <c>FULL</c>
        /// training considers all of the data in your dataset group. An <c>UPDATE</c> processes
        /// only the data that has changed since the latest training. Only solution versions created
        /// with the User-Personalization recipe can use <c>UPDATE</c>. 
        /// </para>
        /// </summary>
        public TrainingMode TrainingMode { get; set; }

        /// <summary>
        /// Checks to see if the TrainingMode property is set.
        /// </summary>
        internal bool IsSetTrainingMode() => this.TrainingMode != null;

        /// <summary>
        /// Gets and sets the property TrainingType. 
        /// <para>
        /// Whether the solution version was created automatically or manually.
        /// </para>
        /// </summary>
        public TrainingType TrainingType { get; set; }

        /// <summary>
        /// Checks to see if the TrainingType property is set.
        /// </summary>
        internal bool IsSetTrainingType() => this.TrainingType != null;

        /// <summary>
        /// Gets and sets the property TunedHPOParams. 
        /// <para>
        /// If hyperparameter optimization was performed, contains the hyperparameter values of
        /// the best performing model.
        /// </para>
        /// </summary>
        public TunedHPOParams TunedHPOParams { get; set; }

        /// <summary>
        /// Checks to see if the TunedHPOParams property is set.
        /// </summary>
        internal bool IsSetTunedHPOParams() => this.TunedHPOParams != null;
    }
}
