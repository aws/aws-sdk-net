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

namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// <para>Response from GetEndpointAttributes of the EndpointArn.</para>
    /// </summary>
    public partial class GetEndpointAttributesResult : AmazonWebServiceResponse
    {
        
        private Dictionary<string,string> attributes = new Dictionary<string,string>();


        /// <summary>
        /// Attributes include the following: <ul> <li><c>CustomUserData</c> -- arbitrary user data to associate with the endpoint. SNS does not use
        /// this data. The data must be in UTF-8 format and less than 2KB.</li> <li><c>Enabled</c> -- flag that enables/disables delivery to the
        /// endpoint. SNS will set this to false when a notification service indicates to SNS that the endpoint is invalid. Users can set it back to
        /// true, typically after updating Token.</li> <li><c>Token</c> -- device token, also referred to as a registration id, for an app and mobile
        /// device. This is returned from the notification service when an app and mobile device are registered with the notification service.</li>
        /// </ul>
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
