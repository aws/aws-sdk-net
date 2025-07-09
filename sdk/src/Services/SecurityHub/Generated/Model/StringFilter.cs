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
        /// To search for values that include the filter value, use <c>CONTAINS</c>. For example,
        /// the filter <c>Title CONTAINS CloudFront</c> matches findings that have a <c>Title</c>
        /// that includes the string CloudFront.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To search for values that exactly match the filter value, use <c>EQUALS</c>. For example,
        /// the filter <c>AwsAccountId EQUALS 123456789012</c> only matches findings that have
        /// an account ID of <c>123456789012</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To search for values that start with the filter value, use <c>PREFIX</c>. For example,
        /// the filter <c>ResourceRegion PREFIX us</c> matches findings that have a <c>ResourceRegion</c>
        /// that starts with <c>us</c>. A <c>ResourceRegion</c> that starts with a different value,
        /// such as <c>af</c>, <c>ap</c>, or <c>ca</c>, doesn't match.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <c>CONTAINS</c>, <c>EQUALS</c>, and <c>PREFIX</c> filters on the same field are joined
        /// by <c>OR</c>. A finding matches if it matches any one of those filters. For example,
        /// the filters <c>Title CONTAINS CloudFront OR Title CONTAINS CloudWatch</c> match a
        /// finding that includes either <c>CloudFront</c>, <c>CloudWatch</c>, or both strings
        /// in the title.
        /// </para>
        ///  
        /// <para>
        /// To search for values that don’t have the filter value, use one of the following comparison
        /// operators:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To search for values that exclude the filter value, use <c>NOT_CONTAINS</c>. For example,
        /// the filter <c>Title NOT_CONTAINS CloudFront</c> matches findings that have a <c>Title</c>
        /// that excludes the string CloudFront.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To search for values other than the filter value, use <c>NOT_EQUALS</c>. For example,
        /// the filter <c>AwsAccountId NOT_EQUALS 123456789012</c> only matches findings that
        /// have an account ID other than <c>123456789012</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To search for values that don't start with the filter value, use <c>PREFIX_NOT_EQUALS</c>.
        /// For example, the filter <c>ResourceRegion PREFIX_NOT_EQUALS us</c> matches findings
        /// with a <c>ResourceRegion</c> that starts with a value other than <c>us</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <c>NOT_CONTAINS</c>, <c>NOT_EQUALS</c>, and <c>PREFIX_NOT_EQUALS</c> filters on the
        /// same field are joined by <c>AND</c>. A finding matches only if it matches all of those
        /// filters. For example, the filters <c>Title NOT_CONTAINS CloudFront AND Title NOT_CONTAINS
        /// CloudWatch</c> match a finding that excludes both <c>CloudFront</c> and <c>CloudWatch</c>
        /// in the title.
        /// </para>
        ///  
        /// <para>
        /// You can’t have both a <c>CONTAINS</c> filter and a <c>NOT_CONTAINS</c> filter on the
        /// same field. Similarly, you can't provide both an <c>EQUALS</c> filter and a <c>NOT_EQUALS</c>
        /// or <c>PREFIX_NOT_EQUALS</c> filter on the same field. Combining filters in this way
        /// returns an error. <c>CONTAINS</c> filters can only be used with other <c>CONTAINS</c>
        /// filters. <c>NOT_CONTAINS</c> filters can only be used with other <c>NOT_CONTAINS</c>
        /// filters. 
        /// </para>
        ///  
        /// <para>
        /// You can combine <c>PREFIX</c> filters with <c>NOT_EQUALS</c> or <c>PREFIX_NOT_EQUALS</c>
        /// filters for the same field. Security Hub first processes the <c>PREFIX</c> filters,
        /// and then the <c>NOT_EQUALS</c> or <c>PREFIX_NOT_EQUALS</c> filters.
        /// </para>
        ///  
        /// <para>
        /// For example, for the following filters, Security Hub first identifies findings that
        /// have resource types that start with either <c>AwsIam</c> or <c>AwsEc2</c>. It then
        /// excludes findings that have a resource type of <c>AwsIamPolicy</c> and findings that
        /// have a resource type of <c>AwsEc2NetworkInterface</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ResourceType PREFIX AwsIam</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ResourceType PREFIX AwsEc2</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ResourceType NOT_EQUALS AwsIamPolicy</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ResourceType NOT_EQUALS AwsEc2NetworkInterface</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <c>CONTAINS</c> and <c>NOT_CONTAINS</c> operators can be used only with automation
        /// rules V1. <c>CONTAINS_WORD</c> operator is only supported in <c>GetFindingsV2</c>,
        /// <c>GetFindingStatisticsV2</c>, <c>GetResourcesV2</c>, and <c>GetResourceStatisticsV2</c>
        /// APIs. For more information, see <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/automation-rules.html">Automation
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
        /// name for control-based findings is <c>Security Hub</c>. If you provide <c>security
        /// hub</c> as the filter value, there's no match.
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