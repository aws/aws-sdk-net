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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Indicates the success or failure of slots at the intent level.
    /// </summary>
    public partial class IntentLevelSlotResolutionTestResults
    {
        private List<IntentLevelSlotResolutionTestResultItem> _items = new List<IntentLevelSlotResolutionTestResultItem>();

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// Indicates the items for the slot level resolution for the intents.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<IntentLevelSlotResolutionTestResultItem> Items
        {
            get { return this._items; }
            set { this._items = value; }
        }

        // Check to see if Items property is set
        internal bool IsSetItems()
        {
            return this._items != null && this._items.Count > 0; 
        }

    }
}