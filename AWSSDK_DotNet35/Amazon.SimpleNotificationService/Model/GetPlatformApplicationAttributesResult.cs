/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Response for GetPlatformApplicationAttributes action.
    /// </summary>
    public partial class GetPlatformApplicationAttributesResult : AmazonWebServiceResponse
    {
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();


        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// Attributes include the following:
        /// </para>
        ///     <ul>                        <li><code>EventEndpointCreated</code> -- Topic ARN
        /// to which EndpointCreated event notifications should be sent.</li>      <li><code>EventEndpointDeleted</code>
        /// -- Topic ARN to which EndpointDeleted event notifications should be sent.</li>   
        ///   <li><code>EventEndpointUpdated</code> -- Topic ARN to which EndpointUpdate event
        /// notifications should be sent.</li>            <li><code>EventDeliveryFailure</code>
        /// -- Topic ARN to which DeliveryFailure event notifications should be sent upon Direct
        /// Publish delivery failure (permanent) to one of the application's endpoints.</li> 
        ///         </ul>
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

    }
}