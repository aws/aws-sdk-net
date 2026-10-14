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

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// <c>FaceOccluded</c> should return "true" with a high confidence score if a detected
    /// face’s eyes, nose, and mouth are partially captured or if they are covered by masks,
    /// dark sunglasses, cell phones, hands, or other objects. <c>FaceOccluded</c> should
    /// return "false" with a high confidence score if common occurrences that do not impact
    /// face verification are detected, such as eye glasses, lightly tinted sunglasses, strands
    /// of hair, and others. 
    /// 
    ///  
    /// <para>
    /// You can use <c>FaceOccluded</c> to determine if an obstruction on a face negatively
    /// impacts using the image for face matching.
    /// </para>
    /// </summary>
    public partial class FaceOccluded
    {
        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// The confidence that the service has detected the presence of a face occlusion.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public float? Confidence { get; set; }

        /// <summary>
        /// Checks to see if the Confidence property is set.
        /// </summary>
        internal bool IsSetConfidence() => this.Confidence.HasValue;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// True if a detected face’s eyes, nose, and mouth are partially captured or if they
        /// are covered by masks, dark sunglasses, cell phones, hands, or other objects. False
        /// if common occurrences that do not impact face verification are detected, such as eye
        /// glasses, lightly tinted sunglasses, strands of hair, and others.
        /// </para>
        /// </summary>
        public bool? Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value.HasValue;
    }
}
