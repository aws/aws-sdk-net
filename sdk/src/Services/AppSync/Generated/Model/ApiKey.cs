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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
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
namespace Amazon.AppSync.Model
{
    /// <summary>
    /// Describes an API key.
    /// 
    ///  
    /// <para>
    /// Customers invoke AppSync GraphQL API operations with API keys as an identity mechanism.
    /// There are two key versions:
    /// </para>
    ///  
    /// <para>
    ///  <b>da1</b>: We introduced this version at launch in November 2017. These keys always
    /// expire after 7 days. Amazon DynamoDB TTL manages key expiration. These keys ceased
    /// to be valid after February 21, 2018, and they should no longer be used.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>ListApiKeys</c> returns the expiration time in milliseconds.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>CreateApiKey</c> returns the expiration time in milliseconds.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>UpdateApiKey</c> is not available for this key version.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DeleteApiKey</c> deletes the item from the table.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Expiration is stored in DynamoDB as milliseconds. This results in a bug where keys
    /// are not automatically deleted because DynamoDB expects the TTL to be stored in seconds.
    /// As a one-time action, we deleted these keys from the table on February 21, 2018.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>da2</b>: We introduced this version in February 2018 when AppSync added support
    /// to extend key expiration.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>ListApiKeys</c> returns the expiration time and deletion time in seconds.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>CreateApiKey</c> returns the expiration time and deletion time in seconds and
    /// accepts a user-provided expiration time in seconds.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>UpdateApiKey</c> returns the expiration time and and deletion time in seconds
    /// and accepts a user-provided expiration time in seconds. Expired API keys are kept
    /// for 60 days after the expiration time. You can update the key expiration time as long
    /// as the key isn't deleted.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DeleteApiKey</c> deletes the item from the table.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Expiration is stored in DynamoDB as seconds. After the expiration time, using the
    /// key to authenticate will fail. However, you can reinstate the key before deletion.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Deletion is stored in DynamoDB as seconds. The key is deleted after deletion time.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ApiKey
    {
        private long? _deletes;
        private string _description;
        private long? _expires;
        private string _id;

        /// <summary>
        /// Gets and sets the property Deletes. 
        /// <para>
        /// The time after which the API key is deleted. The date is represented as seconds since
        /// the epoch, rounded down to the nearest hour.
        /// </para>
        /// </summary>
        public long? Deletes
        {
            get { return this._deletes; }
            set { this._deletes = value; }
        }

        // Check to see if Deletes property is set
        internal bool IsSetDeletes()
        {
            return this._deletes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the purpose of the API key.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Expires. 
        /// <para>
        /// The time after which the API key expires. The date is represented as seconds since
        /// the epoch, rounded down to the nearest hour.
        /// </para>
        /// </summary>
        public long? Expires
        {
            get { return this._expires; }
            set { this._expires = value; }
        }

        // Check to see if Expires property is set
        internal bool IsSetExpires()
        {
            return this._expires.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The API key ID.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

    }
}