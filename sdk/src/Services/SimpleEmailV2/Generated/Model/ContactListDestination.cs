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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An object that contains details about the action of a contact list.
    /// </summary>
    public partial class ContactListDestination
    {
        private ContactListImportAction _contactListImportAction;
        private string _contactListName;

        /// <summary>
        /// Gets and sets the property ContactListImportAction. 
        /// <para>
        /// &gt;The type of action to perform on the addresses. The following are the possible
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PUT: add the addresses to the contact list. If the record already exists, it will
        /// override it with the new value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETE: remove the addresses from the contact list.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ContactListImportAction ContactListImportAction
        {
            get { return this._contactListImportAction; }
            set { this._contactListImportAction = value; }
        }

        // Check to see if ContactListImportAction property is set
        internal bool IsSetContactListImportAction()
        {
            return this._contactListImportAction != null;
        }

        /// <summary>
        /// Gets and sets the property ContactListName. 
        /// <para>
        /// The name of the contact list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ContactListName
        {
            get { return this._contactListName; }
            set { this._contactListName = value; }
        }

        // Check to see if ContactListName property is set
        internal bool IsSetContactListName()
        {
            return this._contactListName != null;
        }

    }
}