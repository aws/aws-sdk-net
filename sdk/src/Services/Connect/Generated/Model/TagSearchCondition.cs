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
    /// The search criteria to be used to return tags.
    /// </summary>
    public partial class TagSearchCondition
    {
        private string _tagKey;
        private StringComparisonType _tagKeyComparisonType;
        private string _tagValue;
        private StringComparisonType _tagValueComparisonType;

        /// <summary>
        /// Gets and sets the property TagKey. 
        /// <para>
        /// The tag key used in the tag search condition.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string TagKey
        {
            get { return this._tagKey; }
            set { this._tagKey = value; }
        }

        // Check to see if TagKey property is set
        internal bool IsSetTagKey()
        {
            return this._tagKey != null;
        }

        /// <summary>
        /// Gets and sets the property TagKeyComparisonType. 
        /// <para>
        /// The type of comparison to be made when evaluating the tag key in tag search condition.
        /// </para>
        /// </summary>
        public StringComparisonType TagKeyComparisonType
        {
            get { return this._tagKeyComparisonType; }
            set { this._tagKeyComparisonType = value; }
        }

        // Check to see if TagKeyComparisonType property is set
        internal bool IsSetTagKeyComparisonType()
        {
            return this._tagKeyComparisonType != null;
        }

        /// <summary>
        /// Gets and sets the property TagValue. 
        /// <para>
        /// The tag value used in the tag search condition.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string TagValue
        {
            get { return this._tagValue; }
            set { this._tagValue = value; }
        }

        // Check to see if TagValue property is set
        internal bool IsSetTagValue()
        {
            return this._tagValue != null;
        }

        /// <summary>
        /// Gets and sets the property TagValueComparisonType. 
        /// <para>
        /// The type of comparison to be made when evaluating the tag value in tag search condition.
        /// </para>
        /// </summary>
        public StringComparisonType TagValueComparisonType
        {
            get { return this._tagValueComparisonType; }
            set { this._tagValueComparisonType = value; }
        }

        // Check to see if TagValueComparisonType property is set
        internal bool IsSetTagValueComparisonType()
        {
            return this._tagValueComparisonType != null;
        }

    }
}