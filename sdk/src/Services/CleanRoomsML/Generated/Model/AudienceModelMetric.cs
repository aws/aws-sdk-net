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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// The audience model metrics.
    /// </summary>
    public partial class AudienceModelMetric
    {
        private int? _forTopKItemPredictions;
        private AudienceModelMetricType _type;
        private double? _value;

        /// <summary>
        /// Gets and sets the property ForTopKItemPredictions. 
        /// <para>
        /// The number of users that were used to generate these model metrics.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? ForTopKItemPredictions
        {
            get { return this._forTopKItemPredictions; }
            set { this._forTopKItemPredictions = value; }
        }

        // Check to see if ForTopKItemPredictions property is set
        internal bool IsSetForTopKItemPredictions()
        {
            return this._forTopKItemPredictions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The audience model metric.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AudienceModelMetricType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the audience model metric
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double? Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

    }
}