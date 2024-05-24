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
    /// Container for the parameters to the DescribeTrustedAdvisorChecks operation.
    /// Returns information about all available Trusted Advisor checks, including the name,
    /// ID, category, description, and metadata. You must specify a language code.
    /// 
    ///  
    /// <para>
    /// The response contains a <a>TrustedAdvisorCheckDescription</a> object for each check.
    /// You must set the Amazon Web Services Region to us-east-1.
    /// </para>
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
    ///  </li> <li> 
    /// <para>
    /// The names and descriptions for Trusted Advisor checks are subject to change. We recommend
    /// that you specify the check ID in your code to uniquely identify a check.
    /// </para>
    ///  </li> </ul> </note> 
    /// <para>
    /// To call the Trusted Advisor operations in the Amazon Web Services Support API, you
    /// must use the US East (N. Virginia) endpoint. Currently, the US West (Oregon) and Europe
    /// (Ireland) endpoints don't support the Trusted Advisor operations. For more information,
    /// see <a href="https://docs.aws.amazon.com/awssupport/latest/user/about-support-api.html#endpoint">About
    /// the Amazon Web Services Support API</a> in the <i>Amazon Web Services Support User
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial class DescribeTrustedAdvisorChecksRequest : AmazonAWSSupportRequest
    {
        private string _language;

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// The ISO 639-1 code for the language that you want your checks to appear in.
        /// </para>
        ///  
        /// <para>
        /// The Amazon Web Services Support API currently supports the following languages for
        /// Trusted Advisor:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Chinese, Simplified - <c>zh</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Chinese, Traditional - <c>zh_TW</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// English - <c>en</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// French - <c>fr</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// German - <c>de</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Indonesian - <c>id</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Italian - <c>it</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Japanese - <c>ja</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Korean - <c>ko</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Portuguese, Brazilian - <c>pt_BR</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Spanish - <c>es</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}