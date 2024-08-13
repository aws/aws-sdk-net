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
    /// The predicted gender of a detected face. 
    /// 
    ///  
    /// <para>
    /// Amazon Rekognition makes gender binary (male/female) predictions based on the physical
    /// appearance of a face in a particular image. This kind of prediction is not designed
    /// to categorize a person’s gender identity, and you shouldn't use Amazon Rekognition
    /// to make such a determination. For example, a male actor wearing a long-haired wig
    /// and earrings for a role might be predicted as female.
    /// </para>
    ///  
    /// <para>
    /// Using Amazon Rekognition to make gender binary predictions is best suited for use
    /// cases where aggregate gender distribution statistics need to be analyzed without identifying
    /// specific users. For example, the percentage of female users compared to male users
    /// on a social media platform. 
    /// </para>
    ///  
    /// <para>
    /// We don't recommend using gender binary predictions to make decisions that impact an
    /// individual's rights, privacy, or access to services.
    /// </para>
    /// </summary>
    public partial class Gender
    {
        private float? _confidence;
        private GenderType _value;

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// Level of confidence in the prediction.
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
        /// Gets and sets the property Value. 
        /// <para>
        /// The predicted gender of the face.
        /// </para>
        /// </summary>
        public GenderType Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}