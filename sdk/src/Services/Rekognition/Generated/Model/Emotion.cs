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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
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
namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// The API returns a prediction of an emotion based on a person's facial expressions,
    /// along with the confidence level for the predicted emotion. It is not a determination
    /// of the person’s internal emotional state and should not be used in such a way. For
    /// example, a person pretending to have a sad face might not be sad emotionally. The
    /// API is not intended to be used, and you may not use it, in a manner that violates
    /// the EU Artificial Intelligence Act or any other applicable law.
    /// </summary>
    public partial class Emotion
    {
        private float? _confidence;
        private EmotionName _type;

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// Level of confidence in the determination.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public float? Confidence
        {
            get { return this._confidence; }
            set { this._confidence = value; }
        }

        // Check to see if Confidence property is set
        internal bool IsSetConfidence()
        {
            return this._confidence.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Type of emotion detected.
        /// </para>
        /// </summary>
        public EmotionName Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}