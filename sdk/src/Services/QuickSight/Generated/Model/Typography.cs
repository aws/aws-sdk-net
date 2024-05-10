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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Determines the typography options.
    /// </summary>
    public partial class Typography
    {
        private List<Font> _fontFamilies = AWSConfigs.InitializeCollections ? new List<Font>() : null;

        /// <summary>
        /// Gets and sets the property FontFamilies. 
        /// <para>
        /// Determines the list of font families.
        /// </para>
        /// </summary>
        [AWSProperty(Max=5)]
        public List<Font> FontFamilies
        {
            get { return this._fontFamilies; }
            set { this._fontFamilies = value; }
        }

        // Check to see if FontFamilies property is set
        internal bool IsSetFontFamilies()
        {
            return this._fontFamilies != null && (this._fontFamilies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}