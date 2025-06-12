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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
    /// The details of the automatically generated business metadata that is rejected.
    /// </summary>
    public partial class RejectChoice
    {
        private List<int> _predictionChoices = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private string _predictionTarget;

        /// <summary>
        /// Gets and sets the property PredictionChoices. 
        /// <para>
        /// Specifies the the automatically generated business metadata that can be rejected.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> PredictionChoices
        {
            get { return this._predictionChoices; }
            set { this._predictionChoices = value; }
        }

        // Check to see if PredictionChoices property is set
        internal bool IsSetPredictionChoices()
        {
            return this._predictionChoices != null && (this._predictionChoices.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PredictionTarget. 
        /// <para>
        /// Specifies the target (for example, a column name) where a prediction can be rejected.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PredictionTarget
        {
            get { return this._predictionTarget; }
            set { this._predictionTarget = value; }
        }

        // Check to see if PredictionTarget property is set
        internal bool IsSetPredictionTarget()
        {
            return this._predictionTarget != null;
        }

    }
}