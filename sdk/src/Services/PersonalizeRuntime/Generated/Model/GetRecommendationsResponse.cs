/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PersonalizeRuntime.Model
{
    /// <summary>
    /// This is the response object from the GetRecommendations operation.
    /// </summary>
    public partial class GetRecommendationsResponse : AmazonWebServiceResponse
    {
        private List<PredictedItem> _itemList = new List<PredictedItem>();

        /// <summary>
        /// Gets and sets the property ItemList. 
        /// <para>
        /// A list of recommendations.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public List<PredictedItem> ItemList
        {
            get { return this._itemList; }
            set { this._itemList = value; }
        }

        // Check to see if ItemList property is set
        internal bool IsSetItemList()
        {
            return this._itemList != null && this._itemList.Count > 0; 
        }

    }
}