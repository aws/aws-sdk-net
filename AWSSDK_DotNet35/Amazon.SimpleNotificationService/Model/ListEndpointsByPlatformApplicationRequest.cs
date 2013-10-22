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
    /// Container for the parameters to the ListEndpointsByPlatformApplication operation.
    /// <para>The <c>ListEndpointsByPlatformApplication</c> action lists the endpoints and endpoint attributes for devices in a supported push
    /// notification service, such as GCM and APNS. The results for <c>ListEndpointsByPlatformApplication</c> are paginated and return a limited
    /// list of endpoints, up to 100. If additional records are available after the first page results, then a NextToken string will be returned. To
    /// receive the next page, you call <c>ListEndpointsByPlatformApplication</c> again using the NextToken string received from the previous call.
    /// When there are no more records to return, NextToken will be null. For more information, see <a
    /// href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html" >Using Amazon SNS Mobile Push Notifications</a> .
    /// </para>
    /// </summary>
    public partial class ListEndpointsByPlatformApplicationRequest : AmazonWebServiceRequest
    {
        private string platformApplicationArn;
        private string nextToken;

        /// <summary>
        /// PlatformApplicationArn for ListEndpointsByPlatformApplicationInput action.
        ///  
        /// </summary>
        public string PlatformApplicationArn
        {
            get { return this.platformApplicationArn; }
            set { this.platformApplicationArn = value; }
        }

        // Check to see if PlatformApplicationArn property is set
        internal bool IsSetPlatformApplicationArn()
        {
            return this.platformApplicationArn != null;
        }

        /// <summary>
        /// NextToken string is used when calling ListEndpointsByPlatformApplication action to retrieve additional records that are available after the
        /// first page results.
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
    
