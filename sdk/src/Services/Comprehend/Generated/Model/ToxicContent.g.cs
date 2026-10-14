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

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Toxic content analysis result for one string. For more information about toxicity
    /// detection, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/toxicity-detection.html">Toxicity
    /// detection</a> in the <i>Amazon Comprehend Developer Guide</i>
    /// </summary>
    public partial class ToxicContent
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the toxic content type.
        /// </para>
        /// </summary>
        public ToxicContentType Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Score. 
        /// <para>
        ///  Model confidence in the detected content type. Value range is zero to one, where
        /// one is highest confidence.
        /// </para>
        /// </summary>
        public float? Score { get; set; }

        /// <summary>
        /// Checks to see if the Score property is set.
        /// </summary>
        internal bool IsSetScore() => this.Score.HasValue;
    }
}
