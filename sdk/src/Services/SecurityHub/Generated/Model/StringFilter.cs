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
    /// A string filter for filtering Security Hub findings.
    /// </summary>
    public partial class StringFilter
    {
        private StringFilterComparison _comparison;
        private string _value;

        /// <summary>
        /// Gets and sets the property Comparison. 
        /// <para>
        /// The condition to apply to a string value when filtering Security Hub findings.
        /// </para>
        ///  
        /// <para>
        /// To search for values that have the filter value, use one of the following comparison
        /// operators:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To search for values that include the filter value, use <code>CONTAINS</code>. For
        /// example, the filter <code>Title CONTAINS CloudFront</code> matches findings that have
        /// a <code>Title</code> that includes the string CloudFront.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To search for values that exactly match the filter value, use <code>EQUALS</code>.
        /// For example, the filter <code>AwsAccountId EQUALS 123456789012</code> only matches
        /// findings that have an account ID of <code>123456789012</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To search for values that start with the filter value, use <code>PREFIX</code>. For
        /// example, the filter <code>ResourceRegion PREFIX us</code> matches findings that have
        /// a <code>ResourceRegion</code> that starts with <code>us</code>. A <code>ResourceRegion</code>
        /// that starts with a different value, such as <code>af</code>, <code>ap</code>, or <code>ca</code>,
        /// doesn't match.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <code>CONTAINS</code>, <code>EQUALS</code>, and <code>PREFIX</code> filters on the
        /// same field are joined by <code>OR</code>. A finding matches if it matches any one
        /// of those filters. For example, the filters <code>Title CONTAINS CloudFront OR Title
        /// CONTAINS CloudWatch</code> match a finding that includes either <code>CloudFront</code>,
        /// <code>CloudWatch</code>, or both strings in the title.
        /// </para>
        ///  
        /// <para>
        /// To search for values that don’t have the filter value, use one of the following comparison
        /// operators:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To search for values that exclude the filter value, use <code>NOT_CONTAINS</code>.
        /// For example, the filter <code>Title NOT_CONTAINS CloudFront</code> matches findings
        /// that have a <code>Title</code> that excludes the string CloudFront.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To search for values other than the filter value, use <code>NOT_EQUALS</code>. For
        /// example, the filter <code>AwsAccountId NOT_EQUALS 123456789012</code> only matches
        /// findings that have an account ID other than <code>123456789012</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To search for values that don't start with the filter value, use <code>PREFIX_NOT_EQUALS</code>.
        /// For example, the filter <code>ResourceRegion PREFIX_NOT_EQUALS us</code> matches findings
        /// with a <code>ResourceRegion</code> that starts with a value other than <code>us</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <code>NOT_CONTAINS</code>, <code>NOT_EQUALS</code>, and <code>PREFIX_NOT_EQUALS</code>
        /// filters on the same field are joined by <code>AND</code>. A finding matches only if
        /// it matches all of those filters. For example, the filters <code>Title NOT_CONTAINS
        /// CloudFront AND Title NOT_CONTAINS CloudWatch</code> match a finding that excludes
        /// both <code>CloudFront</code> and <code>CloudWatch</code> in the title.
        /// </para>
        ///  
        /// <para>
        /// You can’t have both a <code>CONTAINS</code> filter and a <code>NOT_CONTAINS</code>
        /// filter on the same field. Similarly, you can't provide both an <code>EQUALS</code>
        /// filter and a <code>NOT_EQUALS</code> or <code>PREFIX_NOT_EQUALS</code> filter on the
        /// same field. Combining filters in this way returns an error. <code>CONTAINS</code>
        /// filters can only be used with other <code>CONTAINS</code> filters. <code>NOT_CONTAINS</code>
        /// filters can only be used with other <code>NOT_CONTAINS</code> filters. 
        /// </para>
        ///  
        /// <para>
        /// You can combine <code>PREFIX</code> filters with <code>NOT_EQUALS</code> or <code>PREFIX_NOT_EQUALS</code>
        /// filters for the same field. Security Hub first processes the <code>PREFIX</code> filters,
        /// and then the <code>NOT_EQUALS</code> or <code>PREFIX_NOT_EQUALS</code> filters.
        /// </para>
        ///  
        /// <para>
        /// For example, for the following filters, Security Hub first identifies findings that
        /// have resource types that start with either <code>AwsIam</code> or <code>AwsEc2</code>.
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
        /// <para>
        ///  <code>CONTAINS</code> and <code>NOT_CONTAINS</code> operators can be used only with
        /// automation rules. For more information, see <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/automation-rules.html">Automation
        /// rules</a> in the <i>Security Hub User Guide</i>.
        /// </para>
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
        /// hub</code> as the filter value, there's no match.
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