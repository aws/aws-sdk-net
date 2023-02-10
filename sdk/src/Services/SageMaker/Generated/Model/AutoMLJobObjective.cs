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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Specifies a metric to minimize or maximize as the objective of a job.
    /// </summary>
    public partial class AutoMLJobObjective
    {
        private AutoMLMetricEnum _metricName;

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the objective metric used to measure the predictive quality of a machine
        /// learning system. This metric is optimized during training to provide the best estimate
        /// for model parameter values from data.
        /// </para>
        ///  
        /// <para>
        /// Here are the options:
        /// </para>
        ///  <dl> <dt>Accuracy</dt> <dd> 
        /// <para>
        /// The ratio of the number of correctly classified items to the total number of (correctly
        /// and incorrectly) classified items. It is used for both binary and multiclass classification.
        /// Accuracy measures how close the predicted class values are to the actual values. Values
        /// for accuracy metrics vary between zero (0) and one (1). A value of 1 indicates perfect
        /// accuracy, and 0 indicates perfect inaccuracy.
        /// </para>
        ///  </dd> <dt>AUC</dt> <dd> 
        /// <para>
        /// The area under the curve (AUC) metric is used to compare and evaluate binary classification
        /// by algorithms that return probabilities, such as logistic regression. To map the probabilities
        /// into classifications, these are compared against a threshold value. 
        /// </para>
        ///  
        /// <para>
        /// The relevant curve is the receiver operating characteristic curve (ROC curve). The
        /// ROC curve plots the true positive rate (TPR) of predictions (or recall) against the
        /// false positive rate (FPR) as a function of the threshold value, above which a prediction
        /// is considered positive. Increasing the threshold results in fewer false positives,
        /// but more false negatives. 
        /// </para>
        ///  
        /// <para>
        /// AUC is the area under this ROC curve. Therefore, AUC provides an aggregated measure
        /// of the model performance across all possible classification thresholds. AUC scores
        /// vary between 0 and 1. A score of 1 indicates perfect accuracy, and a score of one
        /// half (0.5) indicates that the prediction is not better than a random classifier. 
        /// </para>
        ///  </dd> <dt>BalancedAccuracy</dt> <dd> 
        /// <para>
        ///  <code>BalancedAccuracy</code> is a metric that measures the ratio of accurate predictions
        /// to all predictions. This ratio is calculated after normalizing true positives (TP)
        /// and true negatives (TN) by the total number of positive (P) and negative (N) values.
        /// It is used in both binary and multiclass classification and is defined as follows:
        /// 0.5*((TP/P)+(TN/N)), with values ranging from 0 to 1. <code>BalancedAccuracy</code>
        /// gives a better measure of accuracy when the number of positives or negatives differ
        /// greatly from each other in an imbalanced dataset. For example, when only 1% of email
        /// is spam. 
        /// </para>
        ///  </dd> <dt>F1</dt> <dd> 
        /// <para>
        /// The <code>F1</code> score is the harmonic mean of the precision and recall, defined
        /// as follows: F1 = 2 * (precision * recall) / (precision + recall). It is used for binary
        /// classification into classes traditionally referred to as positive and negative. Predictions
        /// are said to be true when they match their actual (correct) class, and false when they
        /// do not. 
        /// </para>
        ///  
        /// <para>
        /// Precision is the ratio of the true positive predictions to all positive predictions,
        /// and it includes the false positives in a dataset. Precision measures the quality of
        /// the prediction when it predicts the positive class. 
        /// </para>
        ///  
        /// <para>
        /// Recall (or sensitivity) is the ratio of the true positive predictions to all actual
        /// positive instances. Recall measures how completely a model predicts the actual class
        /// members in a dataset. 
        /// </para>
        ///  
        /// <para>
        /// F1 scores vary between 0 and 1. A score of 1 indicates the best possible performance,
        /// and 0 indicates the worst.
        /// </para>
        ///  </dd> <dt>F1macro</dt> <dd> 
        /// <para>
        /// The <code>F1macro</code> score applies F1 scoring to multiclass classification problems.
        /// It does this by calculating the precision and recall, and then taking their harmonic
        /// mean to calculate the F1 score for each class. Lastly, the F1macro averages the individual
        /// scores to obtain the <code>F1macro</code> score. <code>F1macro</code> scores vary
        /// between 0 and 1. A score of 1 indicates the best possible performance, and 0 indicates
        /// the worst.
        /// </para>
        ///  </dd> <dt>MAE</dt> <dd> 
        /// <para>
        /// The mean absolute error (MAE) is a measure of how different the predicted and actual
        /// values are, when they're averaged over all values. MAE is commonly used in regression
        /// analysis to understand model prediction error. If there is linear regression, MAE
        /// represents the average distance from a predicted line to the actual value. MAE is
        /// defined as the sum of absolute errors divided by the number of observations. Values
        /// range from 0 to infinity, with smaller numbers indicating a better model fit to the
        /// data.
        /// </para>
        ///  </dd> <dt>MSE</dt> <dd> 
        /// <para>
        /// The mean squared error (MSE) is the average of the squared differences between the
        /// predicted and actual values. It is used for regression. MSE values are always positive.
        /// The better a model is at predicting the actual values, the smaller the MSE value is
        /// </para>
        ///  </dd> <dt>Precision</dt> <dd> 
        /// <para>
        /// Precision measures how well an algorithm predicts the true positives (TP) out of all
        /// of the positives that it identifies. It is defined as follows: Precision = TP/(TP+FP),
        /// with values ranging from zero (0) to one (1), and is used in binary classification.
        /// Precision is an important metric when the cost of a false positive is high. For example,
        /// the cost of a false positive is very high if an airplane safety system is falsely
        /// deemed safe to fly. A false positive (FP) reflects a positive prediction that is actually
        /// negative in the data.
        /// </para>
        ///  </dd> <dt>PrecisionMacro</dt> <dd> 
        /// <para>
        /// The precision macro computes precision for multiclass classification problems. It
        /// does this by calculating precision for each class and averaging scores to obtain precision
        /// for several classes. <code>PrecisionMacro</code> scores range from zero (0) to one
        /// (1). Higher scores reflect the model's ability to predict true positives (TP) out
        /// of all of the positives that it identifies, averaged across multiple classes.
        /// </para>
        ///  </dd> <dt>R2</dt> <dd> 
        /// <para>
        /// R2, also known as the coefficient of determination, is used in regression to quantify
        /// how much a model can explain the variance of a dependent variable. Values range from
        /// one (1) to negative one (-1). Higher numbers indicate a higher fraction of explained
        /// variability. <code>R2</code> values close to zero (0) indicate that very little of
        /// the dependent variable can be explained by the model. Negative values indicate a poor
        /// fit and that the model is outperformed by a constant function. For linear regression,
        /// this is a horizontal line.
        /// </para>
        ///  </dd> <dt>Recall</dt> <dd> 
        /// <para>
        /// Recall measures how well an algorithm correctly predicts all of the true positives
        /// (TP) in a dataset. A true positive is a positive prediction that is also an actual
        /// positive value in the data. Recall is defined as follows: Recall = TP/(TP+FN), with
        /// values ranging from 0 to 1. Higher scores reflect a better ability of the model to
        /// predict true positives (TP) in the data, and is used in binary classification. 
        /// </para>
        ///  
        /// <para>
        /// Recall is important when testing for cancer because it's used to find all of the true
        /// positives. A false positive (FP) reflects a positive prediction that is actually negative
        /// in the data. It is often insufficient to measure only recall, because predicting every
        /// output as a true positive yield a perfect recall score.
        /// </para>
        ///  </dd> <dt>RecallMacro</dt> <dd> 
        /// <para>
        /// The RecallMacro computes recall for multiclass classification problems by calculating
        /// recall for each class and averaging scores to obtain recall for several classes. RecallMacro
        /// scores range from 0 to 1. Higher scores reflect the model's ability to predict true
        /// positives (TP) in a dataset. Whereas, a true positive reflects a positive prediction
        /// that is also an actual positive value in the data. It is often insufficient to measure
        /// only recall, because predicting every output as a true positive yields a perfect recall
        /// score.
        /// </para>
        ///  </dd> <dt>RMSE</dt> <dd> 
        /// <para>
        /// Root mean squared error (RMSE) measures the square root of the squared difference
        /// between predicted and actual values, and it's averaged over all values. It is used
        /// in regression analysis to understand model prediction error. It's an important metric
        /// to indicate the presence of large model errors and outliers. Values range from zero
        /// (0) to infinity, with smaller numbers indicating a better model fit to the data. RMSE
        /// is dependent on scale, and should not be used to compare datasets of different sizes.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// If you do not specify a metric explicitly, the default behavior is to automatically
        /// use:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>MSE</code>: for regression.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>F1</code>: for binary classification
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Accuracy</code>: for multiclass classification.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutoMLMetricEnum MetricName
        {
            get { return this._metricName; }
            set { this._metricName = value; }
        }

        // Check to see if MetricName property is set
        internal bool IsSetMetricName()
        {
            return this._metricName != null;
        }

    }
}