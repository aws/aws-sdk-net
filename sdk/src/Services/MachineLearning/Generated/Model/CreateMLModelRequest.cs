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
 * Do not modify this file. This file is generated from the machinelearning-2014-12-12.normal.json service model.
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
namespace Amazon.MachineLearning.Model
{
    /// <summary>
    /// Container for the parameters to the CreateMLModel operation.
    /// Creates a new <c>MLModel</c> using the <c>DataSource</c> and the recipe as information
    /// sources. 
    /// 
    ///  
    /// <para>
    /// An <c>MLModel</c> is nearly immutable. Users can update only the <c>MLModelName</c>
    /// and the <c>ScoreThreshold</c> in an <c>MLModel</c> without creating a new <c>MLModel</c>.
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <c>CreateMLModel</c> is an asynchronous operation. In response to <c>CreateMLModel</c>,
    /// Amazon Machine Learning (Amazon ML) immediately returns and sets the <c>MLModel</c>
    /// status to <c>PENDING</c>. After the <c>MLModel</c> has been created and ready is for
    /// use, Amazon ML sets the status to <c>COMPLETED</c>. 
    /// </para>
    ///  
    /// <para>
    /// You can use the <c>GetMLModel</c> operation to check the progress of the <c>MLModel</c>
    /// during the creation operation.
    /// </para>
    ///  
    /// <para>
    ///  <c>CreateMLModel</c> requires a <c>DataSource</c> with computed statistics, which
    /// can be created by setting <c>ComputeStatistics</c> to <c>true</c> in <c>CreateDataSourceFromRDS</c>,
    /// <c>CreateDataSourceFromS3</c>, or <c>CreateDataSourceFromRedshift</c> operations.
    /// 
    /// </para>
    /// </summary>
    public partial class CreateMLModelRequest : AmazonMachineLearningRequest
    {
        private string _mlModelId;
        private string _mlModelName;
        private MLModelType _mlModelType;
        private Dictionary<string, string> _parameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _recipe;
        private string _recipeUri;
        private string _trainingDataSourceId;

        /// <summary>
        /// Gets and sets the property MLModelId. 
        /// <para>
        /// A user-supplied ID that uniquely identifies the <c>MLModel</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string MLModelId
        {
            get { return this._mlModelId; }
            set { this._mlModelId = value; }
        }

        // Check to see if MLModelId property is set
        internal bool IsSetMLModelId()
        {
            return this._mlModelId != null;
        }

        /// <summary>
        /// Gets and sets the property MLModelName. 
        /// <para>
        /// A user-supplied name or description of the <c>MLModel</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string MLModelName
        {
            get { return this._mlModelName; }
            set { this._mlModelName = value; }
        }

        // Check to see if MLModelName property is set
        internal bool IsSetMLModelName()
        {
            return this._mlModelName != null;
        }

        /// <summary>
        /// Gets and sets the property MLModelType. 
        /// <para>
        /// The category of supervised learning that this <c>MLModel</c> will address. Choose
        /// from the following types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Choose <c>REGRESSION</c> if the <c>MLModel</c> will be used to predict a numeric value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Choose <c>BINARY</c> if the <c>MLModel</c> result has two possible values.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Choose <c>MULTICLASS</c> if the <c>MLModel</c> result has a limited number of values.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  For more information, see the <a href="https://docs.aws.amazon.com/machine-learning/latest/dg">Amazon
        /// Machine Learning Developer Guide</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MLModelType MLModelType
        {
            get { return this._mlModelType; }
            set { this._mlModelType = value; }
        }

        // Check to see if MLModelType property is set
        internal bool IsSetMLModelType()
        {
            return this._mlModelType != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A list of the training parameters in the <c>MLModel</c>. The list is implemented as
        /// a map of key-value pairs.
        /// </para>
        ///  
        /// <para>
        /// The following is the current set of training parameters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>sgd.maxMLModelSizeInBytes</c> - The maximum allowed size of the model. Depending
        /// on the input data, the size of the model might affect its performance.
        /// </para>
        ///  
        /// <para>
        ///  The value is an integer that ranges from <c>100000</c> to <c>2147483648</c>. The
        /// default value is <c>33554432</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sgd.maxPasses</c> - The number of times that the training process traverses the
        /// observations to build the <c>MLModel</c>. The value is an integer that ranges from
        /// <c>1</c> to <c>10000</c>. The default value is <c>10</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sgd.shuffleType</c> - Whether Amazon ML shuffles the training data. Shuffling
        /// the data improves a model's ability to find the optimal solution for a variety of
        /// data types. The valid values are <c>auto</c> and <c>none</c>. The default value is
        /// <c>none</c>. We strongly recommend that you shuffle your data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sgd.l1RegularizationAmount</c> - The coefficient regularization L1 norm. It controls
        /// overfitting the data by penalizing large coefficients. This tends to drive coefficients
        /// to zero, resulting in a sparse feature set. If you use this parameter, start by specifying
        /// a small value, such as <c>1.0E-08</c>.
        /// </para>
        ///  
        /// <para>
        /// The value is a double that ranges from <c>0</c> to <c>MAX_DOUBLE</c>. The default
        /// is to not use L1 normalization. This parameter can't be used when <c>L2</c> is specified.
        /// Use this parameter sparingly.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sgd.l2RegularizationAmount</c> - The coefficient regularization L2 norm. It controls
        /// overfitting the data by penalizing large coefficients. This tends to drive coefficients
        /// to small, nonzero values. If you use this parameter, start by specifying a small value,
        /// such as <c>1.0E-08</c>.
        /// </para>
        ///  
        /// <para>
        /// The value is a double that ranges from <c>0</c> to <c>MAX_DOUBLE</c>. The default
        /// is to not use L2 normalization. This parameter can't be used when <c>L1</c> is specified.
        /// Use this parameter sparingly.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Recipe. 
        /// <para>
        /// The data recipe for creating the <c>MLModel</c>. You must specify either the recipe
        /// or its URI. If you don't specify a recipe or its URI, Amazon ML creates a default.
        /// </para>
        /// </summary>
        [AWSProperty(Max=131071)]
        public string Recipe
        {
            get { return this._recipe; }
            set { this._recipe = value; }
        }

        // Check to see if Recipe property is set
        internal bool IsSetRecipe()
        {
            return this._recipe != null;
        }

        /// <summary>
        /// Gets and sets the property RecipeUri. 
        /// <para>
        /// The Amazon Simple Storage Service (Amazon S3) location and file name that contains
        /// the <c>MLModel</c> recipe. You must specify either the recipe or its URI. If you don't
        /// specify a recipe or its URI, Amazon ML creates a default.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string RecipeUri
        {
            get { return this._recipeUri; }
            set { this._recipeUri = value; }
        }

        // Check to see if RecipeUri property is set
        internal bool IsSetRecipeUri()
        {
            return this._recipeUri != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingDataSourceId. 
        /// <para>
        /// The <c>DataSource</c> that points to the training data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string TrainingDataSourceId
        {
            get { return this._trainingDataSourceId; }
            set { this._trainingDataSourceId = value; }
        }

        // Check to see if TrainingDataSourceId property is set
        internal bool IsSetTrainingDataSourceId()
        {
            return this._trainingDataSourceId != null;
        }

    }
}