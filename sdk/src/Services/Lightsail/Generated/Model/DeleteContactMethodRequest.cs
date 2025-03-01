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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteContactMethod operation.
    /// Deletes a contact method.
    /// 
    ///  
    /// <para>
    /// A contact method is used to send you notifications about your Amazon Lightsail resources.
    /// You can add one email address and one mobile phone number contact method in each Amazon
    /// Web Services Region. However, SMS text messaging is not supported in some Amazon Web
    /// Services Regions, and SMS text messages cannot be sent to some countries/regions.
    /// For more information, see <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-notifications">Notifications
    /// in Amazon Lightsail</a>.
    /// </para>
    /// </summary>
    public partial class DeleteContactMethodRequest : AmazonLightsailRequest
    {
        private ContactProtocol _protocol;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol that will be deleted, such as <c>Email</c> or <c>SMS</c> (text messaging).
        /// </para>
        ///  <note> 
        /// <para>
        /// To delete an <c>Email</c> and an <c>SMS</c> contact method if you added both, you
        /// must run separate <c>DeleteContactMethod</c> actions to delete each protocol.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public ContactProtocol Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

    }
}