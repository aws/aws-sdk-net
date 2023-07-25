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
        /// To search for values that include the filter value, use <code>CONTAINS</code>. For
        /// example, for the <code>ResourceTags</code> field, the filter <code>Department CONTAINS
        /// Security</code> matches findings that include the value <code>Security</code> for
        /// the <code>Department</code> tag. In the same example, a finding with a value of <code>Security
        /// team</code> for the <code>Department</code> tag is a match.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To search for values that exactly match the filter value, use <code>EQUALS</code>.
        /// For example, for the <code>ResourceTags</code> field, the filter <code>Department
        /// EQUALS Security</code> matches findings that have the value <code>Security</code>
        /// for the <code>Department</code> tag.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <code>CONTAINS</code> and <code>EQUALS</code> filters on the same field are joined
        /// by <code>OR</code>. A finding matches if it matches any one of those filters. For
        /// example, the filters <code>Department CONTAINS Security OR Department CONTAINS Finance</code>
        /// match a finding that includes either <code>Security</code>, <code>Finance</code>,
        /// or both values.
        /// </para>
        ///  
        /// <para>
        /// To search for values that don't have the filter value, use one of the following comparison
        /// operators:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To search for values that exclude the filter value, use <code>NOT_CONTAINS</code>.
        /// For example, for the <code>ResourceTags</code> field, the filter <code>Department
        /// NOT_CONTAINS Finance</code> matches findings that exclude the value <code>Finance</code>
        /// for the <code>Department</code> tag.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To search for values other than the filter value, use <code>NOT_EQUALS</code>. For
        /// example, for the <code>ResourceTags</code> field, the filter <code>Department NOT_EQUALS
        /// Finance</code> matches findings that don’t have the value <code>Finance</code> for
        /// the <code>Department</code> tag.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <code>NOT_CONTAINS</code> and <code>NOT_EQUALS</code> filters on the same field are
        /// joined by <code>AND</code>. A finding matches only if it matches all of those filters.
        /// For example, the filters <code>Department NOT_CONTAINS Security AND Department NOT_CONTAINS
        /// Finance</code> match a finding that excludes both the <code>Security</code> and <code>Finance</code>
        /// values.
        /// </para>
        ///  
        /// <para>
        ///  <code>CONTAINS</code> filters can only be used with other <code>CONTAINS</code> filters.
        /// <code>NOT_CONTAINS</code> filters can only be used with other <code>NOT_CONTAINS</code>
        /// filters.
        /// </para>
        ///  
        /// <para>
        /// You can’t have both a <code>CONTAINS</code> filter and a <code>NOT_CONTAINS</code>
        /// filter on the same field. Similarly, you can’t have both an <code>EQUALS</code> filter
        /// and a <code>NOT_EQUALS</code> filter on the same field. Combining filters in this
        /// way returns an error. 
        /// </para>
        ///  
        /// <para>
        ///  <code>CONTAINS</code> and <code>NOT_CONTAINS</code> operators can be used only with
        /// automation rules. For more information, see <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/automation-rules.html">Automation
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
        /// The key of the map filter. For example, for <code>ResourceTags</code>, <code>Key</code>
        /// identifies the name of the tag. For <code>UserDefinedFields</code>, <code>Key</code>
        /// is the name of the field.
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
        /// one of the values for a tag called <code>Department</code> might be <code>Security</code>.
        /// If you provide <code>security</code> as the filter value, then there's no match.
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