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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The additional attributes of an Amazon DataZone glossary term.
    /// </summary>
    public partial class GlossaryTermItemAdditionalAttributes
    {
        private List<MatchRationaleItem> _matchRationale = AWSConfigs.InitializeCollections ? new List<MatchRationaleItem>() : null;

        /// <summary>
        /// Gets and sets the property MatchRationale. 
        /// <para>
        /// List of rationales indicating why this item was matched by search.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MatchRationaleItem> MatchRationale
        {
            get { return this._matchRationale; }
            set { this._matchRationale = value; }
        }

        // Check to see if MatchRationale property is set
        internal bool IsSetMatchRationale()
        {
            return this._matchRationale != null && (this._matchRationale.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}