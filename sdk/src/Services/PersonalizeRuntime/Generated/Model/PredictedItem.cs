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
 * Do not modify this file. This file is generated from the personalize-runtime-2018-05-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PersonalizeRuntime.Model
{
    /// <summary>
    /// An object that identifies an item.
    /// 
    ///  
    /// <para>
    /// The and APIs return a list of <code>PredictedItem</code>s.
    /// </para>
    /// </summary>
    public partial class PredictedItem
    {
        private string _itemId;
        private double? _score;

        /// <summary>
        /// Gets and sets the property ItemId. 
        /// <para>
        /// The recommended item ID.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ItemId
        {
            get { return this._itemId; }
            set { this._itemId = value; }
        }

        // Check to see if ItemId property is set
        internal bool IsSetItemId()
        {
            return this._itemId != null;
        }

        /// <summary>
        /// Gets and sets the property Score. 
        /// <para>
        /// A numeric representation of the model's certainty that the item will be the next user
        /// selection. For more information on scoring logic, see <a>how-scores-work</a>.
        /// </para>
        /// </summary>
        public double Score
        {
            get { return this._score.GetValueOrDefault(); }
            set { this._score = value; }
        }

        // Check to see if Score property is set
        internal bool IsSetScore()
        {
            return this._score.HasValue; 
        }

    }
}