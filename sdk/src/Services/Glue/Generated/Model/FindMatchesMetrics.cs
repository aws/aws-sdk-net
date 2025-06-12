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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// The evaluation metrics for the find matches algorithm. The quality of your machine
    /// learning transform is measured by getting your transform to predict some matches and
    /// comparing the results to known matches from the same dataset. The quality metrics
    /// are based on a subset of your data, so they are not precise.
    /// </summary>
    public partial class FindMatchesMetrics
    {
        private double? _areaUnderPRCurve;
        private List<ColumnImportance> _columnImportances = AWSConfigs.InitializeCollections ? new List<ColumnImportance>() : null;
        private ConfusionMatrix _confusionMatrix;
        private double? _f1;
        private double? _precision;
        private double? _recall;

        /// <summary>
        /// Gets and sets the property AreaUnderPRCurve. 
        /// <para>
        /// The area under the precision/recall curve (AUPRC) is a single number measuring the
        /// overall quality of the transform, that is independent of the choice made for precision
        /// vs. recall. Higher values indicate that you have a more attractive precision vs. recall
        /// tradeoff.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://en.wikipedia.org/wiki/Precision_and_recall">Precision
        /// and recall</a> in Wikipedia.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public double? AreaUnderPRCurve
        {
            get { return this._areaUnderPRCurve; }
            set { this._areaUnderPRCurve = value; }
        }

        // Check to see if AreaUnderPRCurve property is set
        internal bool IsSetAreaUnderPRCurve()
        {
            return this._areaUnderPRCurve.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ColumnImportances. 
        /// <para>
        /// A list of <c>ColumnImportance</c> structures containing column importance metrics,
        /// sorted in order of descending importance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<ColumnImportance> ColumnImportances
        {
            get { return this._columnImportances; }
            set { this._columnImportances = value; }
        }

        // Check to see if ColumnImportances property is set
        internal bool IsSetColumnImportances()
        {
            return this._columnImportances != null && (this._columnImportances.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConfusionMatrix. 
        /// <para>
        /// The confusion matrix shows you what your transform is predicting accurately and what
        /// types of errors it is making.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://en.wikipedia.org/wiki/Confusion_matrix">Confusion
        /// matrix</a> in Wikipedia.
        /// </para>
        /// </summary>
        public ConfusionMatrix ConfusionMatrix
        {
            get { return this._confusionMatrix; }
            set { this._confusionMatrix = value; }
        }

        // Check to see if ConfusionMatrix property is set
        internal bool IsSetConfusionMatrix()
        {
            return this._confusionMatrix != null;
        }

        /// <summary>
        /// Gets and sets the property F1. 
        /// <para>
        /// The maximum F1 metric indicates the transform's accuracy between 0 and 1, where 1
        /// is the best accuracy.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://en.wikipedia.org/wiki/F1_score">F1 score</a>
        /// in Wikipedia.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public double? F1
        {
            get { return this._f1; }
            set { this._f1 = value; }
        }

        // Check to see if F1 property is set
        internal bool IsSetF1()
        {
            return this._f1.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Precision. 
        /// <para>
        /// The precision metric indicates when often your transform is correct when it predicts
        /// a match. Specifically, it measures how well the transform finds true positives from
        /// the total true positives possible.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://en.wikipedia.org/wiki/Precision_and_recall">Precision
        /// and recall</a> in Wikipedia.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public double? Precision
        {
            get { return this._precision; }
            set { this._precision = value; }
        }

        // Check to see if Precision property is set
        internal bool IsSetPrecision()
        {
            return this._precision.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Recall. 
        /// <para>
        /// The recall metric indicates that for an actual match, how often your transform predicts
        /// the match. Specifically, it measures how well the transform finds true positives from
        /// the total records in the source data.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://en.wikipedia.org/wiki/Precision_and_recall">Precision
        /// and recall</a> in Wikipedia.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public double? Recall
        {
            get { return this._recall; }
            set { this._recall = value; }
        }

        // Check to see if Recall property is set
        internal bool IsSetRecall()
        {
            return this._recall.HasValue; 
        }

    }
}