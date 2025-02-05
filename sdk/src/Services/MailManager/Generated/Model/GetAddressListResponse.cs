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
    /// This is the response object from the GetAddressList operation.
    /// </summary>
    public partial class GetAddressListResponse : AmazonWebServiceResponse
    {
        private string _addressListArn;
        private string _addressListId;
        private string _addressListName;
        private DateTime? _createdTimestamp;
        private DateTime? _lastUpdatedTimestamp;

        /// <summary>
        /// Gets and sets the property AddressListArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the address list resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AddressListArn
        {
            get { return this._addressListArn; }
            set { this._addressListArn = value; }
        }

        // Check to see if AddressListArn property is set
        internal bool IsSetAddressListArn()
        {
            return this._addressListArn != null;
        }

        /// <summary>
        /// Gets and sets the property AddressListId. 
        /// <para>
        /// The identifier of the address list resource.
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

        /// <summary>
        /// Gets and sets the property AddressListName. 
        /// <para>
        /// A user-friendly name for the address list resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string AddressListName
        {
            get { return this._addressListName; }
            set { this._addressListName = value; }
        }

        // Check to see if AddressListName property is set
        internal bool IsSetAddressListName()
        {
            return this._addressListName != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The date of when then address list was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedTimestamp
        {
            get { return this._createdTimestamp; }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTimestamp. 
        /// <para>
        /// The date of when the address list was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastUpdatedTimestamp
        {
            get { return this._lastUpdatedTimestamp; }
            set { this._lastUpdatedTimestamp = value; }
        }

        // Check to see if LastUpdatedTimestamp property is set
        internal bool IsSetLastUpdatedTimestamp()
        {
            return this._lastUpdatedTimestamp.HasValue; 
        }

    }
}