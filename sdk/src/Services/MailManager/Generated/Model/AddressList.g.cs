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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// An address list contains a list of emails and domains that are used in MailManager
    /// Ingress endpoints and Rules for email management.
    /// </summary>
    public partial class AddressList
    {
        /// <summary>
        /// Gets and sets the property AddressListArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the address list.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AddressListArn { get; set; }

        /// <summary>
        /// Checks to see if the AddressListArn property is set.
        /// </summary>
        internal bool IsSetAddressListArn() => this.AddressListArn != null;

        /// <summary>
        /// Gets and sets the property AddressListId. 
        /// <para>
        /// The identifier of the address list.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string AddressListId { get; set; }

        /// <summary>
        /// Checks to see if the AddressListId property is set.
        /// </summary>
        internal bool IsSetAddressListId() => this.AddressListId != null;

        /// <summary>
        /// Gets and sets the property AddressListName. 
        /// <para>
        /// The user-friendly name of the address list.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string AddressListName { get; set; }

        /// <summary>
        /// Checks to see if the AddressListName property is set.
        /// </summary>
        internal bool IsSetAddressListName() => this.AddressListName != null;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The timestamp of when the address list was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdatedTimestamp. 
        /// <para>
        /// The timestamp of when the address list was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastUpdatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTimestamp property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTimestamp() => this.LastUpdatedTimestamp.HasValue;
    }
}
