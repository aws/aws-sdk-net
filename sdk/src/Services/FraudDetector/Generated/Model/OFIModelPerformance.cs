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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// The Online Fraud Insights (OFI) model performance score.
    /// </summary>
    public partial class OFIModelPerformance
    {
        private float? _auc;
        private UncertaintyRange _uncertaintyRange;

        /// <summary>
        /// Gets and sets the property Auc. 
        /// <para>
        ///  The area under the curve (auc). This summarizes the total positive rate (tpr) and
        /// false positive rate (FPR) across all possible model score thresholds. 
        /// </para>
        /// </summary>
        public float Auc
        {
            get { return this._auc.GetValueOrDefault(); }
            set { this._auc = value; }
        }

        // Check to see if Auc property is set
        internal bool IsSetAuc()
        {
            return this._auc.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UncertaintyRange. 
        /// <para>
        ///  Indicates the range of area under curve (auc) expected from the OFI model. A range
        /// greater than 0.1 indicates higher model uncertainity. 
        /// </para>
        /// </summary>
        public UncertaintyRange UncertaintyRange
        {
            get { return this._uncertaintyRange; }
            set { this._uncertaintyRange = value; }
        }

        // Check to see if UncertaintyRange property is set
        internal bool IsSetUncertaintyRange()
        {
            return this._uncertaintyRange != null;
        }

    }
}