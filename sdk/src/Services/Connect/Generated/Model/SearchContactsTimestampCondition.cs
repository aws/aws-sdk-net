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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// The timestamp condition indicating which timestamp should be used and how it should
    /// be filtered.
    /// </summary>
    public partial class SearchContactsTimestampCondition
    {
        private SearchContactsTimeRangeConditionType _conditionType;
        private SearchContactsTimeRangeType _type;

        /// <summary>
        /// Gets and sets the property ConditionType. 
        /// <para>
        /// Condition of the timestamp on the contact.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SearchContactsTimeRangeConditionType ConditionType
        {
            get { return this._conditionType; }
            set { this._conditionType = value; }
        }

        // Check to see if ConditionType property is set
        internal bool IsSetConditionType()
        {
            return this._conditionType != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Type of the timestamps to use for the filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SearchContactsTimeRangeType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}