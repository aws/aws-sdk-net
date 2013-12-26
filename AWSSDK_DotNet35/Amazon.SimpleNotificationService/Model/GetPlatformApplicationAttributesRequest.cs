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
    /// Container for the parameters to the GetPlatformApplicationAttributes operation.
    /// <para>The <c>GetPlatformApplicationAttributes</c> action retrieves the attributes of the platform application object for the supported push
    /// notification services, such as APNS and GCM. For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html"
    /// >Using Amazon SNS Mobile Push Notifications</a> .
    /// </para>
    /// </summary>
    public partial class GetPlatformApplicationAttributesRequest : AmazonSimpleNotificationServiceRequest
    {
        private string platformApplicationArn;


        /// <summary>
        /// PlatformApplicationArn for GetPlatformApplicationAttributesInput.
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

    }
}
    
