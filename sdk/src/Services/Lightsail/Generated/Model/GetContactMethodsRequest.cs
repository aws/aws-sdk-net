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

/*
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the GetContactMethods operation.
    /// Returns information about the configured contact methods. Specify a protocol in your
    /// request to return information about a specific contact method.
    /// 
    ///  
    /// <para>
    /// A contact method is used to send you notifications about your Amazon Lightsail resources.
    /// You can add one email address and one mobile phone number contact method in each AWS
    /// Region. However, SMS text messaging is not supported in some AWS Regions, and SMS
    /// text messages cannot be sent to some countries/regions. For more information, see
    /// <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-notifications">Notifications
    /// in Amazon Lightsail</a>.
    /// </para>
    /// </summary>
    public partial class GetContactMethodsRequest : AmazonLightsailRequest
    {
        private List<string> _protocols = new List<string>();

        /// <summary>
        /// Gets and sets the property Protocols. 
        /// <para>
        /// The protocols used to send notifications, such as <code>Email</code>, or <code>SMS</code>
        /// (text messaging).
        /// </para>
        ///  
        /// <para>
        /// Specify a protocol in your request to return information about a specific contact
        /// method protocol.
        /// </para>
        /// </summary>
        public List<string> Protocols
        {
            get { return this._protocols; }
            set { this._protocols = value; }
        }

        // Check to see if Protocols property is set
        internal bool IsSetProtocols()
        {
            return this._protocols != null && this._protocols.Count > 0; 
        }

    }
}