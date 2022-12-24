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

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeServices operation.
    /// Returns the current list of Amazon Web Services services and a list of service categories
    /// for each service. You then use service names and categories in your <a>CreateCase</a>
    /// requests. Each Amazon Web Services service has its own set of categories.
    /// 
    ///  
    /// <para>
    /// The service codes and category codes correspond to the values that appear in the <b>Service</b>
    /// and <b>Category</b> lists on the Amazon Web Services Support Center <a href="https://console.aws.amazon.com/support/home#/case/create">Create
    /// Case</a> page. The values in those fields don't necessarily match the service codes
    /// and categories returned by the <code>DescribeServices</code> operation. Always use
    /// the service codes and categories that the <code>DescribeServices</code> operation
    /// returns, so that you have the most recent set of service and category codes.
    /// </para>
    ///  <note> <ul> <li> 
    /// <para>
    /// You must have a Business, Enterprise On-Ramp, or Enterprise Support plan to use the
    /// Amazon Web Services Support API. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you call the Amazon Web Services Support API from an account that doesn't have
    /// a Business, Enterprise On-Ramp, or Enterprise Support plan, the <code>SubscriptionRequiredException</code>
    /// error message appears. For information about changing your support plan, see <a href="http://aws.amazon.com/premiumsupport/">Amazon
    /// Web Services Support</a>.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class DescribeServicesRequest : AmazonAWSSupportRequest
    {
        private string _language;
        private List<string> _serviceCodeList = new List<string>();

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// The language in which Amazon Web Services Support handles the case. Amazon Web Services
        /// Support currently supports English ("en") and Japanese ("ja"). You must specify the
        /// ISO 639-1 code for the <code>language</code> parameter if you want support in that
        /// language.
        /// </para>
        /// </summary>
        public string Language
        {
            get { return this._language; }
            set { this._language = value; }
        }

        // Check to see if Language property is set
        internal bool IsSetLanguage()
        {
            return this._language != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceCodeList. 
        /// <para>
        /// A JSON-formatted list of service codes available for Amazon Web Services services.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> ServiceCodeList
        {
            get { return this._serviceCodeList; }
            set { this._serviceCodeList = value; }
        }

        // Check to see if ServiceCodeList property is set
        internal bool IsSetServiceCodeList()
        {
            return this._serviceCodeList != null && this._serviceCodeList.Count > 0; 
        }

    }
}