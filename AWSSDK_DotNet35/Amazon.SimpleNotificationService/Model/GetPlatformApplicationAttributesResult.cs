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
    /// <para>Response for GetPlatformApplicationAttributes action.</para>
    /// </summary>
    public partial class GetPlatformApplicationAttributesResult : AmazonWebServiceResponse
    {
        
        private Dictionary<string,string> attributes = new Dictionary<string,string>();


        /// <summary>
        /// Attributes include the following: <ul> <li><c>EventEndpointCreated</c> -- Topic ARN to which EndpointCreated event notifications should be
        /// sent.</li> <li><c>EventEndpointDeleted</c> -- Topic ARN to which EndpointDeleted event notifications should be sent.</li>
        /// <li><c>EventEndpointUpdated</c> -- Topic ARN to which EndpointUpdate event notifications should be sent.</li>
        /// <li><c>EventDeliveryFailure</c> -- Topic ARN to which DeliveryFailure event notifications should be sent upon Direct Publish delivery
        /// failure (permanent) to one of the application's endpoints.</li> </ul>
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
