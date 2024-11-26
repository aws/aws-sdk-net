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
    /// The additional recipients information of outbound email.
    /// </summary>
    public partial class OutboundAdditionalRecipients
    {
        private List<EmailAddressInfo> _ccEmailAddresses = AWSConfigs.InitializeCollections ? new List<EmailAddressInfo>() : null;

        /// <summary>
        /// Gets and sets the property CcEmailAddresses. 
        /// <para>
        /// The additional CC email address recipients information.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<EmailAddressInfo> CcEmailAddresses
        {
            get { return this._ccEmailAddresses; }
            set { this._ccEmailAddresses = value; }
        }

        // Check to see if CcEmailAddresses property is set
        internal bool IsSetCcEmailAddresses()
        {
            return this._ccEmailAddresses != null && (this._ccEmailAddresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}