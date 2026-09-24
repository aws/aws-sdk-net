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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Specifies the prediction (aka, the automatically generated piece of metadata) and
    /// the target (for example, a column name) that can be accepted.
    /// </summary>
    public partial class AcceptChoice
    {
        /// <summary>
        /// Gets and sets the property EditedValue. 
        /// <para>
        /// The edit of the prediction.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 5000)]
        public string EditedValue { get; set; }

        /// <summary>
        /// Checks to see if the EditedValue property is set.
        /// </summary>
        internal bool IsSetEditedValue() => this.EditedValue != null;

        /// <summary>
        /// Gets and sets the property PredictionChoice. 
        /// <para>
        /// Specifies the prediction (aka, the automatically generated piece of metadata) that
        /// can be accepted.
        /// </para>
        /// </summary>
        public int? PredictionChoice { get; set; }

        /// <summary>
        /// Checks to see if the PredictionChoice property is set.
        /// </summary>
        internal bool IsSetPredictionChoice() => this.PredictionChoice.HasValue;

        /// <summary>
        /// Gets and sets the property PredictionTarget. 
        /// <para>
        /// Specifies the target (for example, a column name) where a prediction can be accepted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PredictionTarget { get; set; }

        /// <summary>
        /// Checks to see if the PredictionTarget property is set.
        /// </summary>
        internal bool IsSetPredictionTarget() => this.PredictionTarget != null;
    }
}
