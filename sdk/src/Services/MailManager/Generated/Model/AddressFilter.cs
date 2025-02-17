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
    /// Filtering options for ListMembersOfAddressList operation.
    /// </summary>
    public partial class AddressFilter
    {
        private string _addressPrefix;

        /// <summary>
        /// Gets and sets the property AddressPrefix. 
        /// <para>
        /// Filter to limit the results to addresses having the provided prefix.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=320)]
        public string AddressPrefix
        {
            get { return this._addressPrefix; }
            set { this._addressPrefix = value; }
        }

        // Check to see if AddressPrefix property is set
        internal bool IsSetAddressPrefix()
        {
            return this._addressPrefix != null;
        }

    }
}