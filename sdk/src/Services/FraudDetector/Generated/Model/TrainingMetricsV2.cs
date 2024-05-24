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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// The training metrics details.
    /// </summary>
    public partial class TrainingMetricsV2
    {
        private ATITrainingMetricsValue _ati;
        private OFITrainingMetricsValue _ofi;
        private TFITrainingMetricsValue _tfi;

        /// <summary>
        /// Gets and sets the property Ati. 
        /// <para>
        ///  The Account Takeover Insights (ATI) model training metric details. 
        /// </para>
        /// </summary>
        public ATITrainingMetricsValue Ati
        {
            get { return this._ati; }
            set { this._ati = value; }
        }

        // Check to see if Ati property is set
        internal bool IsSetAti()
        {
            return this._ati != null;
        }

        /// <summary>
        /// Gets and sets the property Ofi. 
        /// <para>
        ///  The Online Fraud Insights (OFI) model training metric details. 
        /// </para>
        /// </summary>
        public OFITrainingMetricsValue Ofi
        {
            get { return this._ofi; }
            set { this._ofi = value; }
        }

        // Check to see if Ofi property is set
        internal bool IsSetOfi()
        {
            return this._ofi != null;
        }

        /// <summary>
        /// Gets and sets the property Tfi. 
        /// <para>
        ///  The Transaction Fraud Insights (TFI) model training metric details. 
        /// </para>
        /// </summary>
        public TFITrainingMetricsValue Tfi
        {
            get { return this._tfi; }
            set { this._tfi = value; }
        }

        // Check to see if Tfi property is set
        internal bool IsSetTfi()
        {
            return this._tfi != null;
        }

    }
}