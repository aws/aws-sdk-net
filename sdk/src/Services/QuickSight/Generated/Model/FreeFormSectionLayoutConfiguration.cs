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
    /// The free-form layout configuration of a section.
    /// </summary>
    public partial class FreeFormSectionLayoutConfiguration
    {
        private List<FreeFormLayoutElement> _elements = new List<FreeFormLayoutElement>();

        /// <summary>
        /// Gets and sets the property Elements. 
        /// <para>
        /// The elements that are included in the free-form layout.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=430)]
        public List<FreeFormLayoutElement> Elements
        {
            get { return this._elements; }
            set { this._elements = value; }
        }

        // Check to see if Elements property is set
        internal bool IsSetElements()
        {
            return this._elements != null && this._elements.Count > 0; 
        }

    }
}