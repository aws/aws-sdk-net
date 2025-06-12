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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
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
namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Toxicity analysis result for one string. For more information about toxicity detection,
    /// see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/toxicity-detection.html">Toxicity
    /// detection</a> in the <i>Amazon Comprehend Developer Guide</i>.
    /// </summary>
    public partial class ToxicLabels
    {
        private List<ToxicContent> _labels = AWSConfigs.InitializeCollections ? new List<ToxicContent>() : null;
        private float? _toxicity;

        /// <summary>
        /// Gets and sets the property Labels. 
        /// <para>
        /// Array of toxic content types identified in the string.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ToxicContent> Labels
        {
            get { return this._labels; }
            set { this._labels = value; }
        }

        // Check to see if Labels property is set
        internal bool IsSetLabels()
        {
            return this._labels != null && (this._labels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Toxicity. 
        /// <para>
        /// Overall toxicity score for the string. Value range is zero to one, where one is the
        /// highest confidence.
        /// </para>
        /// </summary>
        public float? Toxicity
        {
            get { return this._toxicity; }
            set { this._toxicity = value; }
        }

        // Check to see if Toxicity property is set
        internal bool IsSetToxicity()
        {
            return this._toxicity.HasValue; 
        }

    }
}