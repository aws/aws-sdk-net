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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// This is the response object from the DescribeAccountSettings operation.
    /// </summary>
    public partial class DescribeAccountSettingsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AccountSettings. 
        /// <para>
        /// The Amazon Quick Sight settings for this Amazon Web Services account. This information
        /// includes the edition of Amazon Quick Sight that you subscribed to (Standard or Enterprise)
        /// and the notification email for the Amazon Quick Sight subscription. 
        /// </para>
        ///  
        /// <para>
        /// In the Quick Sight console, the Amazon Quick Sight subscription is sometimes referred
        /// to as a Quick Sight "account" even though it's technically not an account by itself.
        /// Instead, it's a subscription to the Amazon Quick Sight service for your Amazon Web
        /// Services account. The edition that you subscribe to applies to Quick in every Amazon
        /// Web Services Region where you use it.
        /// </para>
        /// </summary>
        public AccountSettings AccountSettings { get; set; }

        /// <summary>
        /// Checks to see if the AccountSettings property is set.
        /// </summary>
        internal bool IsSetAccountSettings() => this.AccountSettings != null;

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The Amazon Web Services request ID for this operation.
        /// </para>
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Checks to see if the RequestId property is set.
        /// </summary>
        internal bool IsSetRequestId() => this.RequestId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The HTTP status of the request.
        /// </para>
        /// </summary>
        public int? Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status.HasValue;
    }
}
