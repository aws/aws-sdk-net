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
    /// Structure containing the estimated age range, in years, for a face.
    /// 
    ///  
    /// <para>
    /// Amazon Rekognition estimates an age range for faces detected in the input image. Estimated
    /// age ranges can overlap. A face of a 5-year-old might have an estimated range of 4-6,
    /// while the face of a 6-year-old might have an estimated range of 4-8.
    /// </para>
    /// </summary>
    public partial class AgeRange
    {
        private int? _high;
        private int? _low;

        /// <summary>
        /// Gets and sets the property High. 
        /// <para>
        /// The highest estimated age.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? High
        {
            get { return this._high; }
            set { this._high = value; }
        }

        // Check to see if High property is set
        internal bool IsSetHigh()
        {
            return this._high.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Low. 
        /// <para>
        /// The lowest estimated age.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? Low
        {
            get { return this._low; }
            set { this._low = value; }
        }

        // Check to see if Low property is set
        internal bool IsSetLow()
        {
            return this._low.HasValue; 
        }

    }
}