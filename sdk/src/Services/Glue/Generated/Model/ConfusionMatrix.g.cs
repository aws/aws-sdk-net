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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// The confusion matrix shows you what your transform is predicting accurately and what
    /// types of errors it is making.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://en.wikipedia.org/wiki/Confusion_matrix">Confusion
    /// matrix</a> in Wikipedia.
    /// </para>
    /// </summary>
    public partial class ConfusionMatrix
    {
        /// <summary>
        /// Gets and sets the property NumFalseNegatives. 
        /// <para>
        /// The number of matches in the data that the transform didn't find, in the confusion
        /// matrix for your transform.
        /// </para>
        /// </summary>
        public long? NumFalseNegatives { get; set; }

        /// <summary>
        /// Checks to see if the NumFalseNegatives property is set.
        /// </summary>
        internal bool IsSetNumFalseNegatives() => this.NumFalseNegatives.HasValue;

        /// <summary>
        /// Gets and sets the property NumFalsePositives. 
        /// <para>
        /// The number of nonmatches in the data that the transform incorrectly classified as
        /// a match, in the confusion matrix for your transform.
        /// </para>
        /// </summary>
        public long? NumFalsePositives { get; set; }

        /// <summary>
        /// Checks to see if the NumFalsePositives property is set.
        /// </summary>
        internal bool IsSetNumFalsePositives() => this.NumFalsePositives.HasValue;

        /// <summary>
        /// Gets and sets the property NumTrueNegatives. 
        /// <para>
        /// The number of nonmatches in the data that the transform correctly rejected, in the
        /// confusion matrix for your transform.
        /// </para>
        /// </summary>
        public long? NumTrueNegatives { get; set; }

        /// <summary>
        /// Checks to see if the NumTrueNegatives property is set.
        /// </summary>
        internal bool IsSetNumTrueNegatives() => this.NumTrueNegatives.HasValue;

        /// <summary>
        /// Gets and sets the property NumTruePositives. 
        /// <para>
        /// The number of matches in the data that the transform correctly found, in the confusion
        /// matrix for your transform.
        /// </para>
        /// </summary>
        public long? NumTruePositives { get; set; }

        /// <summary>
        /// Checks to see if the NumTruePositives property is set.
        /// </summary>
        internal bool IsSetNumTruePositives() => this.NumTruePositives.HasValue;
    }
}
