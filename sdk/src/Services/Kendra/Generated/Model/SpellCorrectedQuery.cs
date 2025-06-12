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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
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
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// A query with suggested spell corrections.
    /// </summary>
    public partial class SpellCorrectedQuery
    {
        private List<Correction> _corrections = AWSConfigs.InitializeCollections ? new List<Correction>() : null;
        private string _suggestedQueryText;

        /// <summary>
        /// Gets and sets the property Corrections. 
        /// <para>
        /// The corrected misspelled word or words in a query.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Correction> Corrections
        {
            get { return this._corrections; }
            set { this._corrections = value; }
        }

        // Check to see if Corrections property is set
        internal bool IsSetCorrections()
        {
            return this._corrections != null && (this._corrections.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SuggestedQueryText. 
        /// <para>
        /// The query with the suggested spell corrections.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string SuggestedQueryText
        {
            get { return this._suggestedQueryText; }
            set { this._suggestedQueryText = value; }
        }

        // Check to see if SuggestedQueryText property is set
        internal bool IsSetSuggestedQueryText()
        {
            return this._suggestedQueryText != null;
        }

    }
}