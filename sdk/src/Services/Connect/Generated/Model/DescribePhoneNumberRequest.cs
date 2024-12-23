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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the DescribePhoneNumber operation.
    /// Gets details and status of a phone number that’s claimed to your Amazon Connect instance
    /// or traffic distribution group.
    /// 
    ///  <important> 
    /// <para>
    /// If the number is claimed to a traffic distribution group, and you are calling in the
    /// Amazon Web Services Region where the traffic distribution group was created, you can
    /// use either a phone number ARN or UUID value for the <c>PhoneNumberId</c> URI request
    /// parameter. However, if the number is claimed to a traffic distribution group and you
    /// are calling this API in the alternate Amazon Web Services Region associated with the
    /// traffic distribution group, you must provide a full phone number ARN. If a UUID is
    /// provided in this scenario, you receive a <c>ResourceNotFoundException</c>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class DescribePhoneNumberRequest : AmazonConnectRequest
    {
        private string _phoneNumberId;

        /// <summary>
        /// Gets and sets the property PhoneNumberId. 
        /// <para>
        /// A unique identifier for the phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PhoneNumberId
        {
            get { return this._phoneNumberId; }
            set { this._phoneNumberId = value; }
        }

        // Check to see if PhoneNumberId property is set
        internal bool IsSetPhoneNumberId()
        {
            return this._phoneNumberId != null;
        }

    }
}