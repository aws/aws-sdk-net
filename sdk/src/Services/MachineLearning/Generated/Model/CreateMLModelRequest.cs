/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MachineLearning.Model
{
    /// <summary>
    /// Container for the parameters to the CreateMLModel operation.
    /// Creates a new <code>MLModel</code> using the data files and the recipe as information
    /// sources. 
    /// 
    ///  
    /// <para>
    /// An <code>MLModel</code> is nearly immutable. Users can only update the <code>MLModelName</code>
    /// and the <code>ScoreThreshold</code> in an <code>MLModel</code> without creating a
    /// new <code>MLModel</code>. 
    /// </para>
    ///  
    /// <para>
    /// <code>CreateMLModel</code> is an asynchronous operation. In response to <code>CreateMLModel</code>,
    /// Amazon Machine Learning (Amazon ML) immediately returns and sets the <code>MLModel</code>
    /// status to <code>PENDING</code>. After the <code>MLModel</code> is created and ready
    /// for use, Amazon ML sets the status to <code>COMPLETED</code>. 
    /// </para>
    ///  
    /// <para>
    /// You can use the <a>GetMLModel</a> operation to check progress of the <code>MLModel</code>
    /// during the creation operation.
    /// </para>
    ///  
    /// <para>
    ///  <a>CreateMLModel</a> requires a <code>DataSource</code> with computed statistics,
    /// which can be created by setting <code>ComputeStatistics</code> to <code>true</code>
    /// in <a>CreateDataSourceFromRDS</a>, <a>CreateDataSourceFromS3</a>, or <a>CreateDataSourceFromRedshift</a>
    /// operations. 
    /// </para>
    /// </summary>
    public partial class CreateMLModelRequest : AmazonMachineLearningRequest
    {
        private string _mlModelId;
        private string _mlModelName;
        private MLModelType _mlModelType;
        private Dictionary<string, string> _parameters = new Dictionary<string, string>();
        private string _recipe;
        private string _recipeUri;
        private string _trainingDataSourceId;

        /// <summary>
        /// Gets and sets the property MLModelId. 
        /// <para>
        /// A user-supplied ID that uniquely identifies the <code>MLModel</code>.
        /// </para>
        /// </summary>
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
        /// A user-supplied name or description of the <code>MLModel</code>.
        /// </para>
        /// </summary>
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
        /// The category of supervised learning that this <code>MLModel</code> will address. Choose
        /// from the following types:
        /// </para>
        ///  <ul> <li>Choose <code>REGRESSION</code> if the <code>MLModel</code> will be used
        /// to predict a numeric value.</li> <li>Choose <code>BINARY</code> if the <code>MLModel</code>
        /// result has two possible values.</li> <li>Choose <code>MULTICLASS</code> if the <code>MLModel</code>
        /// result has a limited number of values. </li> </ul> 
        /// <para>
        ///  For more information, see the <a href="http://docs.aws.amazon.com/machinelearning/latest/dg">Amazon
        /// Machine Learning Developer Guide</a>.
        /// </para>
        /// </summary>
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
        /// A list of the training parameters in the <code>MLModel</code>. The list is implemented
        /// as a map of key/value pairs.
        /// </para>
        ///  
        /// <para>
        /// The following is the current set of training parameters: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// <code>sgd.l1RegularizationAmount</code> - Coefficient regularization L1 norm. It controls
        /// overfitting the data by penalizing large coefficients. This tends to drive coefficients
        /// to zero, resulting in sparse feature set. If you use this parameter, start by specifying
        /// a small value such as 1.0E-08.
        /// </para>
        ///  
        /// <para>
        /// The value is a double that ranges from 0 to MAX_DOUBLE. The default is not to use
        /// L1 normalization. The parameter cannot be used when <code>L2</code> is specified.
        /// Use this parameter sparingly.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>sgd.l2RegularizationAmount</code> - Coefficient regularization L2 norm. It controls
        /// overfitting the data by penalizing large coefficients. This tends to drive coefficients
        /// to small, nonzero values. If you use this parameter, start by specifying a small value
        /// such as 1.0E-08.
        /// </para>
        ///  
        /// <para>
        /// The valuseis a double that ranges from 0 to MAX_DOUBLE. The default is not to use
        /// L2 normalization. This cannot be used when <code>L1</code> is specified. Use this
        /// parameter sparingly.
        /// </para>
        ///  </li> <li>
        /// <para>
        /// <code>sgd.maxPasses</code> - Number of times that the training process traverses the
        /// observations to build the <code>MLModel</code>. The value is an integer that ranges
        /// from 1 to 10000. The default value is 10. 
        /// </para>
        /// </li> <li> 
        /// <para>
        /// <code>sgd.maxMLModelSizeInBytes</code> - Maximum allowed size of the model. Depending
        /// on the input data, the size of the model might affect its performance.
        /// </para>
        ///  
        /// <para>
        ///  The value is an integer that ranges from 100000 to 2147483648. The default value
        /// is 33554432. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Recipe. 
        /// <para>
        /// The data recipe for creating <code>MLModel</code>. You must specify either the recipe
        /// or its URI. If you don’t specify a recipe or its URI, Amazon ML creates a default.
        /// </para>
        /// </summary>
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
        /// the <code>MLModel</code> recipe. You must specify either the recipe or its URI. If
        /// you don’t specify a recipe or its URI, Amazon ML creates a default.
        /// </para>
        /// </summary>
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
        /// The <code>DataSource</code> that points to the training data.
        /// </para>
        /// </summary>
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