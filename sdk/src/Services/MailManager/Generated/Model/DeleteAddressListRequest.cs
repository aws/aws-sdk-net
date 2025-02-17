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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
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
namespace Amazon.MailManager.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteAddressList operation.
    /// Deletes an address list.
    /// </summary>
    public partial class DeleteAddressListRequest : AmazonMailManagerRequest
    {
        private string _addressListId;

        /// <summary>
        /// Gets and sets the property AddressListId. 
        /// <para>
        /// The identifier of an existing address list resource to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string AddressListId
        {
            get { return this._addressListId; }
            set { this._addressListId = value; }
        }

        // Check to see if AddressListId property is set
        internal bool IsSetAddressListId()
        {
            return this._addressListId != null;
        }

    }
}