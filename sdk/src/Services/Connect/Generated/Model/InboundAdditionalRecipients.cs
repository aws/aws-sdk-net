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
    /// The additional TO CC recipients information of inbound email.
    /// </summary>
    public partial class InboundAdditionalRecipients
    {
        private List<EmailAddressInfo> _ccAddresses = AWSConfigs.InitializeCollections ? new List<EmailAddressInfo>() : null;
        private List<EmailAddressInfo> _toAddresses = AWSConfigs.InitializeCollections ? new List<EmailAddressInfo>() : null;

        /// <summary>
        /// Gets and sets the property CcAddresses. 
        /// <para>
        /// The additional recipients information present in cc list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<EmailAddressInfo> CcAddresses
        {
            get { return this._ccAddresses; }
            set { this._ccAddresses = value; }
        }

        // Check to see if CcAddresses property is set
        internal bool IsSetCcAddresses()
        {
            return this._ccAddresses != null && (this._ccAddresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ToAddresses. 
        /// <para>
        /// The additional recipients information present in to list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<EmailAddressInfo> ToAddresses
        {
            get { return this._toAddresses; }
            set { this._toAddresses = value; }
        }

        // Check to see if ToAddresses property is set
        internal bool IsSetToAddresses()
        {
            return this._toAddresses != null && (this._toAddresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}