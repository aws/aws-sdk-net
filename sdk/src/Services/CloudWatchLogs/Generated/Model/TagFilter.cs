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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// A tag filter that specifies a tag key and optional tag values for filtering log groups
    /// by tags.
    /// </summary>
    public partial class TagFilter
    {
        private string _key;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The tag key to filter on.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// An optional list of tag values to filter on.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you specify a filter that contains more than one value for a key, the response
        /// returns log groups that match any of the specified values for that key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you don't specify values, the response returns all log groups that are tagged with
        /// that key, with any or no value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>*</c> for wildcard matching. For example, <c>prod*</c> matches values that
        /// start with <c>prod</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>!</c> as a prefix for negation. For example, <c>!prod</c> matches values that
        /// are not <c>prod</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Exact matching and negation are case-sensitive. Wildcard matching is case-insensitive.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}