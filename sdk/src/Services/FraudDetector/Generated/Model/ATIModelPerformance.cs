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
    /// The Account Takeover Insights (ATI) model performance score.
    /// </summary>
    public partial class ATIModelPerformance
    {
        private float? _asi;

        /// <summary>
        /// Gets and sets the property Asi. 
        /// <para>
        ///  The anomaly separation index (ASI) score. This metric summarizes the overall ability
        /// of the model to separate anomalous activities from the normal behavior. Depending
        /// on the business, a large fraction of these anomalous activities can be malicious and
        /// correspond to the account takeover attacks. A model with no separability power will
        /// have the lowest possible ASI score of 0.5, whereas the a model with a high separability
        /// power will have the highest possible ASI score of 1.0 
        /// </para>
        /// </summary>
        public float? Asi
        {
            get { return this._asi; }
            set { this._asi = value; }
        }

        // Check to see if Asi property is set
        internal bool IsSetAsi()
        {
            return this._asi.HasValue; 
        }

    }
}