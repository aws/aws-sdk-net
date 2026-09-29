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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The word cloud options for a word cloud visual.
    /// </summary>
    public partial class WordCloudOptions
    {
        /// <summary>
        /// Gets and sets the property CloudLayout. 
        /// <para>
        /// The cloud layout options (fluid, normal) of a word cloud.
        /// </para>
        /// </summary>
        public WordCloudCloudLayout CloudLayout { get; set; }

        /// <summary>
        /// Checks to see if the CloudLayout property is set.
        /// </summary>
        internal bool IsSetCloudLayout() => this.CloudLayout != null;

        /// <summary>
        /// Gets and sets the property MaximumStringLength. 
        /// <para>
        /// The length limit of each word from 1-100.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaximumStringLength { get; set; }

        /// <summary>
        /// Checks to see if the MaximumStringLength property is set.
        /// </summary>
        internal bool IsSetMaximumStringLength() => this.MaximumStringLength.HasValue;

        /// <summary>
        /// Gets and sets the property WordCasing. 
        /// <para>
        /// The word casing options (lower_case, existing_case) for the words in a word cloud.
        /// </para>
        /// </summary>
        public WordCloudWordCasing WordCasing { get; set; }

        /// <summary>
        /// Checks to see if the WordCasing property is set.
        /// </summary>
        internal bool IsSetWordCasing() => this.WordCasing != null;

        /// <summary>
        /// Gets and sets the property WordOrientation. 
        /// <para>
        /// The word orientation options (horizontal, horizontal_and_vertical) for the words in
        /// a word cloud.
        /// </para>
        /// </summary>
        public WordCloudWordOrientation WordOrientation { get; set; }

        /// <summary>
        /// Checks to see if the WordOrientation property is set.
        /// </summary>
        internal bool IsSetWordOrientation() => this.WordOrientation != null;

        /// <summary>
        /// Gets and sets the property WordPadding. 
        /// <para>
        /// The word padding options (none, small, medium, large) for the words in a word cloud.
        /// </para>
        /// </summary>
        public WordCloudWordPadding WordPadding { get; set; }

        /// <summary>
        /// Checks to see if the WordPadding property is set.
        /// </summary>
        internal bool IsSetWordPadding() => this.WordPadding != null;

        /// <summary>
        /// Gets and sets the property WordScaling. 
        /// <para>
        /// The word scaling options (emphasize, normal) for the words in a word cloud.
        /// </para>
        /// </summary>
        public WordCloudWordScaling WordScaling { get; set; }

        /// <summary>
        /// Checks to see if the WordScaling property is set.
        /// </summary>
        internal bool IsSetWordScaling() => this.WordScaling != null;
    }
}
