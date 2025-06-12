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
    /// Container for the parameters to the DescribeTrustedAdvisorCheckRefreshStatuses operation.
    /// Returns the refresh status of the Trusted Advisor checks that have the specified check
    /// IDs. You can get the check IDs by calling the <a>DescribeTrustedAdvisorChecks</a>
    /// operation.
    /// 
    ///  
    /// <para>
    /// Some checks are refreshed automatically, and you can't return their refresh statuses
    /// by using the <c>DescribeTrustedAdvisorCheckRefreshStatuses</c> operation. If you call
    /// this operation for these checks, you might see an <c>InvalidParameterValue</c> error.
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
    public partial class DescribeTrustedAdvisorCheckRefreshStatusesRequest : AmazonAWSSupportRequest
    {
        private List<string> _checkIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property CheckIds. 
        /// <para>
        /// The IDs of the Trusted Advisor checks to get the status.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you specify the check ID of a check that is automatically refreshed, you might
        /// see an <c>InvalidParameterValue</c> error.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> CheckIds
        {
            get { return this._checkIds; }
            set { this._checkIds = value; }
        }

        // Check to see if CheckIds property is set
        internal bool IsSetCheckIds()
        {
            return this._checkIds != null && (this._checkIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}