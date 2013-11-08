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
    /// Container for the parameters to the CreatePlatformEndpoint operation.
    /// <para>The <c>CreatePlatformEndpoint</c> creates an endpoint for a device and mobile app on one of the supported push notification services,
    /// such as GCM and APNS. <c>CreatePlatformEndpoint</c> requires the PlatformApplicationArn that is returned from
    /// <c>CreatePlatformApplication</c> . The EndpointArn that is returned when using <c>CreatePlatformEndpoint</c> can then be used by the
    /// <c>Publish</c> action to send a message to a mobile app or by the <c>Subscribe</c> action for subscription to a topic. For more information,
    /// see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html" >Using Amazon SNS Mobile Push Notifications</a> .
    /// </para>
    /// </summary>
    public partial class CreatePlatformEndpointRequest : AmazonWebServiceRequest
    {
        private string platformApplicationArn;
        private string token;
        private string customUserData;
        private Dictionary<string,string> attributes = new Dictionary<string,string>();

        /// <summary>
        /// PlatformApplicationArn returned from CreatePlatformApplication is used to create a an endpoint.
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
        /// Unique identifier created by the notification service for an app on a device. The specific name for Token will vary, depending on which
        /// notification service is being used. For example, when using APNS as the notification service, you need the device token. Alternatively, when
        /// using GCM or ADM, the device token equivalent is called the registration ID.
        ///  
        /// </summary>
        public string Token
        {
            get { return this.token; }
            set { this.token = value; }
        }

        // Check to see if Token property is set
        internal bool IsSetToken()
        {
            return this.token != null;
        }

        /// <summary>
        /// Arbitrary user data to associate with the endpoint. SNS does not use this data. The data must be in UTF-8 format and less than 2KB.
        ///  
        /// </summary>
        public string CustomUserData
        {
            get { return this.customUserData; }
            set { this.customUserData = value; }
        }

        // Check to see if CustomUserData property is set
        internal bool IsSetCustomUserData()
        {
            return this.customUserData != null;
        }

        /// <summary>
        /// For a list of attributes, see <a href="http://docs.aws.amazon.com/sns/latest/api/API_SetEndpointAttributes.html">SetEndpointAttributes</a>.
        ///  
        /// </summary>
        public Dictionary<string,string> Attributes
        {
            get { return this.attributes; }
            set { this.attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this.attributes != null;
        }

    }
}
    
