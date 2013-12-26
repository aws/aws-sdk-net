/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// Container for the parameters to the ListPlatformApplications operation.
    /// <para>The <c>ListPlatformApplications</c> action lists the platform application objects for the supported push notification services, such
    /// as APNS and GCM. The results for <c>ListPlatformApplications</c> are paginated and return a limited list of applications, up to 100. If
    /// additional records are available after the first page results, then a NextToken string will be returned. To receive the next page, you call
    /// <c>ListPlatformApplications</c> using the NextToken string received from the previous call. When there are no more records to return,
    /// NextToken will be null. For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html" >Using Amazon SNS
    /// Mobile Push Notifications</a> .
    /// </para>
    /// </summary>
    public partial class ListPlatformApplicationsRequest : AmazonSimpleNotificationServiceRequest
    {
        private string nextToken;


        /// <summary>
        /// NextToken string is used when calling ListPlatformApplications action to retrieve additional records that are available after the first page
        /// results.
        ///  
        /// </summary>
        public string NextToken
        {
            get { return this.nextToken; }
            set { this.nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this.nextToken != null;
        }

    }
}
    
