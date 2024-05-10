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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A map filter for filtering Security Hub findings. Each map filter provides the field
    /// to check for, the value to check for, and the comparison operator.
    /// </summary>
    public partial class MapFilter
    {
        private MapFilterComparison _comparison;
        private string _key;
        private string _value;

        /// <summary>
        /// Gets and sets the property Comparison. 
        /// <para>
        /// The condition to apply to the key value when filtering Security Hub findings with
        /// a map filter.
        /// </para>
        ///  
        /// <para>
        /// To search for values that have the filter value, use one of the following comparison
        /// operators:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To search for values that include the filter value, use <c>CONTAINS</c>. For example,
        /// for the <c>ResourceTags</c> field, the filter <c>Department CONTAINS Security</c>
        /// matches findings that include the value <c>Security</c> for the <c>Department</c>
        /// tag. In the same example, a finding with a value of <c>Security team</c> for the <c>Department</c>
        /// tag is a match.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To search for values that exactly match the filter value, use <c>EQUALS</c>. For example,
        /// for the <c>ResourceTags</c> field, the filter <c>Department EQUALS Security</c> matches
        /// findings that have the value <c>Security</c> for the <c>Department</c> tag.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <c>CONTAINS</c> and <c>EQUALS</c> filters on the same field are joined by <c>OR</c>.
        /// A finding matches if it matches any one of those filters. For example, the filters
        /// <c>Department CONTAINS Security OR Department CONTAINS Finance</c> match a finding
        /// that includes either <c>Security</c>, <c>Finance</c>, or both values.
        /// </para>
        ///  
        /// <para>
        /// To search for values that don't have the filter value, use one of the following comparison
        /// operators:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To search for values that exclude the filter value, use <c>NOT_CONTAINS</c>. For example,
        /// for the <c>ResourceTags</c> field, the filter <c>Department NOT_CONTAINS Finance</c>
        /// matches findings that exclude the value <c>Finance</c> for the <c>Department</c> tag.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To search for values other than the filter value, use <c>NOT_EQUALS</c>. For example,
        /// for the <c>ResourceTags</c> field, the filter <c>Department NOT_EQUALS Finance</c>
        /// matches findings that don’t have the value <c>Finance</c> for the <c>Department</c>
        /// tag.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <c>NOT_CONTAINS</c> and <c>NOT_EQUALS</c> filters on the same field are joined by
        /// <c>AND</c>. A finding matches only if it matches all of those filters. For example,
        /// the filters <c>Department NOT_CONTAINS Security AND Department NOT_CONTAINS Finance</c>
        /// match a finding that excludes both the <c>Security</c> and <c>Finance</c> values.
        /// </para>
        ///  
        /// <para>
        ///  <c>CONTAINS</c> filters can only be used with other <c>CONTAINS</c> filters. <c>NOT_CONTAINS</c>
        /// filters can only be used with other <c>NOT_CONTAINS</c> filters.
        /// </para>
        ///  
        /// <para>
        /// You can’t have both a <c>CONTAINS</c> filter and a <c>NOT_CONTAINS</c> filter on the
        /// same field. Similarly, you can’t have both an <c>EQUALS</c> filter and a <c>NOT_EQUALS</c>
        /// filter on the same field. Combining filters in this way returns an error. 
        /// </para>
        ///  
        /// <para>
        ///  <c>CONTAINS</c> and <c>NOT_CONTAINS</c> operators can be used only with automation
        /// rules. For more information, see <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/automation-rules.html">Automation
        /// rules</a> in the <i>Security Hub User Guide</i>.
        /// </para>
        /// </summary>
        public MapFilterComparison Comparison
        {
            get { return this._comparison; }
            set { this._comparison = value; }
        }

        // Check to see if Comparison property is set
        internal bool IsSetComparison()
        {
            return this._comparison != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The key of the map filter. For example, for <c>ResourceTags</c>, <c>Key</c> identifies
        /// the name of the tag. For <c>UserDefinedFields</c>, <c>Key</c> is the name of the field.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Value. 
        /// <para>
        /// The value for the key in the map filter. Filter values are case sensitive. For example,
        /// one of the values for a tag called <c>Department</c> might be <c>Security</c>. If
        /// you provide <c>security</c> as the filter value, then there's no match.
        /// </para>
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}