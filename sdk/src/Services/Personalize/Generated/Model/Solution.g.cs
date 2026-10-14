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
        /// <summary>
        /// Gets and sets the property AutoMLResult. 
        /// <para>
        /// When <c>performAutoML</c> is true, specifies the best recipe found.
        /// </para>
        /// </summary>
        public AutoMLResult AutoMLResult { get; set; }

        /// <summary>
        /// Checks to see if the AutoMLResult property is set.
        /// </summary>
        internal bool IsSetAutoMLResult() => this.AutoMLResult != null;

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The creation date and time (in Unix time) of the solution.
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
        /// The Amazon Resource Name (ARN) of the dataset group that provides the training data.
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
        /// If no <c>eventType</c> is provided, Amazon Personalize uses all interactions for training
        /// with equal weight regardless of type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string EventType { get; set; }

        /// <summary>
        /// Checks to see if the EventType property is set.
        /// </summary>
        internal bool IsSetEventType() => this.EventType != null;

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
        /// Gets and sets the property LatestSolutionUpdate. 
        /// <para>
        /// Provides a summary of the latest updates to the solution.
        /// </para>
        /// </summary>
        public SolutionUpdateSummary LatestSolutionUpdate { get; set; }

        /// <summary>
        /// Checks to see if the LatestSolutionUpdate property is set.
        /// </summary>
        internal bool IsSetLatestSolutionUpdate() => this.LatestSolutionUpdate != null;

        /// <summary>
        /// Gets and sets the property LatestSolutionVersion. 
        /// <para>
        /// Describes the latest version of the solution, including the status and the ARN.
        /// </para>
        /// </summary>
        public SolutionVersionSummary LatestSolutionVersion { get; set; }

        /// <summary>
        /// Checks to see if the LatestSolutionVersion property is set.
        /// </summary>
        internal bool IsSetLatestSolutionVersion() => this.LatestSolutionVersion != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the solution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

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
        public bool? PerformAutoML { get; set; }

        /// <summary>
        /// Checks to see if the PerformAutoML property is set.
        /// </summary>
        internal bool IsSetPerformAutoML() => this.PerformAutoML.HasValue;

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
        public bool? PerformAutoTraining { get; set; }

        /// <summary>
        /// Checks to see if the PerformAutoTraining property is set.
        /// </summary>
        internal bool IsSetPerformAutoTraining() => this.PerformAutoTraining.HasValue;

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
        /// A Boolean value that indicates whether incremental training updates are performed
        /// on the model. When enabled, this allows the model to learn from new data more frequently
        /// without requiring full retraining, which enables near real-time personalization. This
        /// parameter is supported only for solutions that use the semantic-similarity recipe
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
        /// The ARN of the recipe used to create the solution. This is required when <c>performAutoML</c>
        /// is false.
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
        /// CREATE PENDING > CREATE IN_PROGRESS > ACTIVE -or- CREATE FAILED
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETE PENDING > DELETE IN_PROGRESS
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
