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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The word cloud options for a word cloud visual.
    /// </summary>
    public partial class WordCloudOptions
    {
        private WordCloudCloudLayout _cloudLayout;
        private int? _maximumStringLength;
        private WordCloudWordCasing _wordCasing;
        private WordCloudWordOrientation _wordOrientation;
        private WordCloudWordPadding _wordPadding;
        private WordCloudWordScaling _wordScaling;

        /// <summary>
        /// Gets and sets the property CloudLayout. 
        /// <para>
        /// The cloud layout options (fluid, normal) of a word cloud.
        /// </para>
        /// </summary>
        public WordCloudCloudLayout CloudLayout
        {
            get { return this._cloudLayout; }
            set { this._cloudLayout = value; }
        }

        // Check to see if CloudLayout property is set
        internal bool IsSetCloudLayout()
        {
            return this._cloudLayout != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumStringLength. 
        /// <para>
        /// The length limit of each word from 1-100.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int MaximumStringLength
        {
            get { return this._maximumStringLength.GetValueOrDefault(); }
            set { this._maximumStringLength = value; }
        }

        // Check to see if MaximumStringLength property is set
        internal bool IsSetMaximumStringLength()
        {
            return this._maximumStringLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WordCasing. 
        /// <para>
        /// The word casing options (lower_case, existing_case) for the words in a word cloud.
        /// </para>
        /// </summary>
        public WordCloudWordCasing WordCasing
        {
            get { return this._wordCasing; }
            set { this._wordCasing = value; }
        }

        // Check to see if WordCasing property is set
        internal bool IsSetWordCasing()
        {
            return this._wordCasing != null;
        }

        /// <summary>
        /// Gets and sets the property WordOrientation. 
        /// <para>
        /// The word orientation options (horizontal, horizontal_and_vertical) for the words in
        /// a word cloud.
        /// </para>
        /// </summary>
        public WordCloudWordOrientation WordOrientation
        {
            get { return this._wordOrientation; }
            set { this._wordOrientation = value; }
        }

        // Check to see if WordOrientation property is set
        internal bool IsSetWordOrientation()
        {
            return this._wordOrientation != null;
        }

        /// <summary>
        /// Gets and sets the property WordPadding. 
        /// <para>
        /// The word padding options (none, small, medium, large) for the words in a word cloud.
        /// </para>
        /// </summary>
        public WordCloudWordPadding WordPadding
        {
            get { return this._wordPadding; }
            set { this._wordPadding = value; }
        }

        // Check to see if WordPadding property is set
        internal bool IsSetWordPadding()
        {
            return this._wordPadding != null;
        }

        /// <summary>
        /// Gets and sets the property WordScaling. 
        /// <para>
        /// The word scaling options (emphasize, normal) for the words in a word cloud.
        /// </para>
        /// </summary>
        public WordCloudWordScaling WordScaling
        {
            get { return this._wordScaling; }
            set { this._wordScaling = value; }
        }

        // Check to see if WordScaling property is set
        internal bool IsSetWordScaling()
        {
            return this._wordScaling != null;
        }

    }
}