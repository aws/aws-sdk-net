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
    /// A query limits configuration.
    /// </summary>
    public partial class PluginVisualItemsLimitConfiguration
    {
        private long? _itemsLimit;

        /// <summary>
        /// Gets and sets the property ItemsLimit. 
        /// <para>
        /// Determines how many values are be fetched at once.
        /// </para>
        /// </summary>
        public long? ItemsLimit
        {
            get { return this._itemsLimit; }
            set { this._itemsLimit = value; }
        }

        // Check to see if ItemsLimit property is set
        internal bool IsSetItemsLimit()
        {
            return this._itemsLimit.HasValue; 
        }

    }
}