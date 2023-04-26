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

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Information about a conflicting query used across different sets of featured results.
    /// When you create a featured results set, you must check that the queries are unique
    /// per featured results set for each index.
    /// </summary>
    public partial class ConflictingItem
    {
        private string _queryText;
        private string _setId;
        private string _setName;

        /// <summary>
        /// Gets and sets the property QueryText. 
        /// <para>
        /// The text of the conflicting query.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string QueryText
        {
            get { return this._queryText; }
            set { this._queryText = value; }
        }

        // Check to see if QueryText property is set
        internal bool IsSetQueryText()
        {
            return this._queryText != null;
        }

        /// <summary>
        /// Gets and sets the property SetId. 
        /// <para>
        /// The identifier of the set of featured results that the conflicting query belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string SetId
        {
            get { return this._setId; }
            set { this._setId = value; }
        }

        // Check to see if SetId property is set
        internal bool IsSetSetId()
        {
            return this._setId != null;
        }

        /// <summary>
        /// Gets and sets the property SetName. 
        /// <para>
        /// The name for the set of featured results that the conflicting query belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string SetName
        {
            get { return this._setName; }
            set { this._setName = value; }
        }

        // Check to see if SetName property is set
        internal bool IsSetSetName()
        {
            return this._setName != null;
        }

    }
}