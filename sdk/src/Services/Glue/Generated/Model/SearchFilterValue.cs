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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// A filter value. Exactly one of <c>stringValue</c> or <c>longValue</c> must be specified.
    /// </summary>
    public partial class SearchFilterValue
    {
        private long? _longValue;
        private string _stringValue;

        /// <summary>
        /// Gets and sets the property LongValue. 
        /// <para>
        /// A long integer filter value.
        /// </para>
        /// </summary>
        public long? LongValue
        {
            get { return this._longValue; }
            set { this._longValue = value; }
        }

        // Check to see if LongValue property is set
        internal bool IsSetLongValue()
        {
            return this._longValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StringValue. 
        /// <para>
        /// A string filter value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string StringValue
        {
            get { return this._stringValue; }
            set { this._stringValue = value; }
        }

        // Check to see if StringValue property is set
        internal bool IsSetStringValue()
        {
            return this._stringValue != null;
        }

    }
}