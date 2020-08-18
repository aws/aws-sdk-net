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
    /// A string filter for querying findings.
    /// </summary>
    public partial class StringFilter
    {
        private StringFilterComparison _comparison;
        private string _value;

        /// <summary>
        /// Gets and sets the property Comparison. 
        /// <para>
        /// The condition to apply to a string value when querying for findings. To search for
        /// values that contain the filter criteria value, use one of the following comparison
        /// operators:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To search for values that exactly match the filter value, use <code>EQUALS</code>.
        /// </para>
        ///  
        /// <para>
        /// For example, the filter <code>ResourceType EQUALS AwsEc2SecurityGroup</code> only
        /// matches findings that have a resource type of <code>AwsEc2SecurityGroup</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To search for values that start with the filter value, use <code>PREFIX</code>.
        /// </para>
        ///  
        /// <para>
        /// For example, the filter <code>ResourceType PREFIX AwsIam</code> matches findings that
        /// have a resource type that starts with <code>AwsIam</code>. Findings with a resource
        /// type of <code>AwsIamPolicy</code>, <code>AwsIamRole</code>, or <code>AwsIamUser</code>
        /// would all match.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <code>EQUALS</code> and <code>PREFIX</code> filters on the same field are joined
        /// by <code>OR</code>. A finding matches if it matches any one of those filters.
        /// </para>
        ///  
        /// <para>
        /// To search for values that do not contain the filter criteria value, use one of the
        /// following comparison operators:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To search for values that do not exactly match the filter value, use <code>NOT_EQUALS</code>.
        /// </para>
        ///  
        /// <para>
        /// For example, the filter <code>ResourceType NOT_EQUALS AwsIamPolicy</code> matches
        /// findings that have a resource type other than <code>AwsIamPolicy</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To search for values that do not start with the filter value, use <code>PREFIX_NOT_EQUALS</code>.
        /// </para>
        ///  
        /// <para>
        /// For example, the filter <code>ResourceType PREFIX_NOT_EQUALS AwsIam</code> matches
        /// findings that have a resource type that does not start with <code>AwsIam</code>. Findings
        /// with a resource type of <code>AwsIamPolicy</code>, <code>AwsIamRole</code>, or <code>AwsIamUser</code>
        /// would all be excluded from the results.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <code>NOT_EQUALS</code> and <code>PREFIX_NOT_EQUALS</code> filters on the same field
        /// are joined by <code>AND</code>. A finding matches only if it matches all of those
        /// filters.
        /// </para>
        ///  
        /// <para>
        /// For filters on the same field, you cannot provide both an <code>EQUALS</code> filter
        /// and a <code>NOT_EQUALS</code> or <code>PREFIX_NOT_EQUALS</code> filter. Combining
        /// filters in this way always returns an error, even if the provided filter values would
        /// return valid results.
        /// </para>
        ///  
        /// <para>
        /// You can combine <code>PREFIX</code> filters with <code>NOT_EQUALS</code> or <code>PREFIX_NOT_EQUALS</code>
        /// filters for the same field. Security Hub first processes the <code>PREFIX</code> filters,
        /// then the <code>NOT_EQUALS</code> or <code>PREFIX_NOT_EQUALS</code> filters.
        /// </para>
        ///  
        /// <para>
        ///  For example, for the following filter, Security Hub first identifies findings that
        /// have resource types that start with either <code>AwsIAM</code> or <code>AwsEc2</code>.
        /// It then excludes findings that have a resource type of <code>AwsIamPolicy</code> and
        /// findings that have a resource type of <code>AwsEc2NetworkInterface</code>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ResourceType PREFIX AwsIam</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ResourceType PREFIX AwsEc2</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ResourceType NOT_EQUALS AwsIamPolicy</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ResourceType NOT_EQUALS AwsEc2NetworkInterface</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StringFilterComparison Comparison
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
        /// Gets and sets the property Value. 
        /// <para>
        /// The string filter value. Filter values are case sensitive. For example, the product
        /// name for control-based findings is <code>Security Hub</code>. If you provide <code>security
        /// hub</code> as the filter text, then there is no match.
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