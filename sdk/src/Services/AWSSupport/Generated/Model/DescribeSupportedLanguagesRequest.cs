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
 * Do not modify this file. This file is generated from the support-2013-04-15.normal.json service model.
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
namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeSupportedLanguages operation.
    /// Returns a list of supported languages for a specified <c>categoryCode</c>, <c>issueType</c>
    /// and <c>serviceCode</c>. The returned supported languages will include a ISO 639-1
    /// code for the <c>language</c>, and the language display name.
    /// 
    ///  <note> <ul> <li> 
    /// <para>
    /// You must have a Business, Enterprise On-Ramp, or Enterprise Support plan to use the
    /// Amazon Web Services Support API. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you call the Amazon Web Services Support API from an account that doesn't have
    /// a Business, Enterprise On-Ramp, or Enterprise Support plan, the <c>SubscriptionRequiredException</c>
    /// error message appears. For information about changing your support plan, see <a href="http://aws.amazon.com/premiumsupport/">Amazon
    /// Web Services Support</a>.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class DescribeSupportedLanguagesRequest : AmazonAWSSupportRequest
    {
        private string _categoryCode;
        private string _issueType;
        private string _serviceCode;

        /// <summary>
        /// Gets and sets the property CategoryCode. 
        /// <para>
        /// The category of problem for the support case. You also use the <a>DescribeServices</a>
        /// operation to get the category code for a service. Each Amazon Web Services service
        /// defines its own set of category codes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public string CategoryCode
        {
            get { return this._categoryCode; }
            set { this._categoryCode = value; }
        }

        // Check to see if CategoryCode property is set
        internal bool IsSetCategoryCode()
        {
            return this._categoryCode != null;
        }

        /// <summary>
        /// Gets and sets the property IssueType. 
        /// <para>
        /// The type of issue for the case. You can specify <c>customer-service</c> or <c>technical</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=9, Max=22)]
        public string IssueType
        {
            get { return this._issueType; }
            set { this._issueType = value; }
        }

        // Check to see if IssueType property is set
        internal bool IsSetIssueType()
        {
            return this._issueType != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceCode. 
        /// <para>
        /// The code for the Amazon Web Services service. You can use the <a>DescribeServices</a>
        /// operation to get the possible <c>serviceCode</c> values.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public string ServiceCode
        {
            get { return this._serviceCode; }
            set { this._serviceCode = value; }
        }

        // Check to see if ServiceCode property is set
        internal bool IsSetServiceCode()
        {
            return this._serviceCode != null;
        }

    }
}