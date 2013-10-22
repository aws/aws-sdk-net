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
    /// Container for the parameters to the GetEndpointAttributes operation.
    /// <para>The <c>GetEndpointAttributes</c> retrieves the endpoint attributes for a device on one of the supported push notification services,
    /// such as GCM and APNS. For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html" >Using Amazon SNS
    /// Mobile Push Notifications</a> .
    /// </para>
    /// </summary>
    public partial class GetEndpointAttributesRequest : AmazonWebServiceRequest
    {
        private string endpointArn;

        /// <summary>
        /// EndpointArn for GetEndpointAttributes input.
        ///  
        /// </summary>
        public string EndpointArn
        {
            get { return this.endpointArn; }
            set { this.endpointArn = value; }
        }

        // Check to see if EndpointArn property is set
        internal bool IsSetEndpointArn()
        {
            return this.endpointArn != null;
        }

    }
}
    
