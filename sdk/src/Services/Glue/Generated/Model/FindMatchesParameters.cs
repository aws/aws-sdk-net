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
    /// The parameters to configure the find matches transform.
    /// </summary>
    public partial class FindMatchesParameters
    {
        private double? _accuracyCostTradeoff;
        private bool? _enforceProvidedLabels;
        private double? _precisionRecallTradeoff;
        private string _primaryKeyColumnName;

        /// <summary>
        /// Gets and sets the property AccuracyCostTradeoff. 
        /// <para>
        /// The value that is selected when tuning your transform for a balance between accuracy
        /// and cost. A value of 0.5 means that the system balances accuracy and cost concerns.
        /// A value of 1.0 means a bias purely for accuracy, which typically results in a higher
        /// cost, sometimes substantially higher. A value of 0.0 means a bias purely for cost,
        /// which results in a less accurate <c>FindMatches</c> transform, sometimes with unacceptable
        /// accuracy.
        /// </para>
        ///  
        /// <para>
        /// Accuracy measures how well the transform finds true positives and true negatives.
        /// Increasing accuracy requires more machine resources and cost. But it also results
        /// in increased recall. 
        /// </para>
        ///  
        /// <para>
        /// Cost measures how many compute resources, and thus money, are consumed to run the
        /// transform.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public double? AccuracyCostTradeoff
        {
            get { return this._accuracyCostTradeoff; }
            set { this._accuracyCostTradeoff = value; }
        }

        // Check to see if AccuracyCostTradeoff property is set
        internal bool IsSetAccuracyCostTradeoff()
        {
            return this._accuracyCostTradeoff.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnforceProvidedLabels. 
        /// <para>
        /// The value to switch on or off to force the output to match the provided labels from
        /// users. If the value is <c>True</c>, the <c>find matches</c> transform forces the output
        /// to match the provided labels. The results override the normal conflation results.
        /// If the value is <c>False</c>, the <c>find matches</c> transform does not ensure all
        /// the labels provided are respected, and the results rely on the trained model.
        /// </para>
        ///  
        /// <para>
        /// Note that setting this value to true may increase the conflation execution time.
        /// </para>
        /// </summary>
        public bool? EnforceProvidedLabels
        {
            get { return this._enforceProvidedLabels; }
            set { this._enforceProvidedLabels = value; }
        }

        // Check to see if EnforceProvidedLabels property is set
        internal bool IsSetEnforceProvidedLabels()
        {
            return this._enforceProvidedLabels.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PrecisionRecallTradeoff. 
        /// <para>
        /// The value selected when tuning your transform for a balance between precision and
        /// recall. A value of 0.5 means no preference; a value of 1.0 means a bias purely for
        /// precision, and a value of 0.0 means a bias for recall. Because this is a tradeoff,
        /// choosing values close to 1.0 means very low recall, and choosing values close to 0.0
        /// results in very low precision.
        /// </para>
        ///  
        /// <para>
        /// The precision metric indicates how often your model is correct when it predicts a
        /// match. 
        /// </para>
        ///  
        /// <para>
        /// The recall metric indicates that for an actual match, how often your model predicts
        /// the match.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public double? PrecisionRecallTradeoff
        {
            get { return this._precisionRecallTradeoff; }
            set { this._precisionRecallTradeoff = value; }
        }

        // Check to see if PrecisionRecallTradeoff property is set
        internal bool IsSetPrecisionRecallTradeoff()
        {
            return this._precisionRecallTradeoff.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PrimaryKeyColumnName. 
        /// <para>
        /// The name of a column that uniquely identifies rows in the source table. Used to help
        /// identify matching records.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string PrimaryKeyColumnName
        {
            get { return this._primaryKeyColumnName; }
            set { this._primaryKeyColumnName = value; }
        }

        // Check to see if PrimaryKeyColumnName property is set
        internal bool IsSetPrimaryKeyColumnName()
        {
            return this._primaryKeyColumnName != null;
        }

    }
}