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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateManagedPrefixList operation.
    /// Creates a managed prefix list. You can specify one or more entries for the prefix
    /// list. Each entry consists of a CIDR block and an optional description.
    /// 
    ///  
    /// <para>
    /// You must specify the maximum number of entries for the prefix list. The maximum number
    /// of entries cannot be changed later.
    /// </para>
    /// </summary>
    public partial class CreateManagedPrefixListRequest : AmazonEC2Request
    {
        private string _addressFamily;
        private string _clientToken;
        private List<AddPrefixListEntry> _entries = new List<AddPrefixListEntry>();
        private int? _maxEntries;
        private string _prefixListName;
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();

        /// <summary>
        /// Gets and sets the property AddressFamily. 
        /// <para>
        /// The IP address type.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>IPv4</code> | <code>IPv6</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AddressFamily
        {
            get { return this._addressFamily; }
            set { this._addressFamily = value; }
        }

        // Check to see if AddressFamily property is set
        internal bool IsSetAddressFamily()
        {
            return this._addressFamily != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier you provide to ensure the idempotency of the request.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// Idempotency</a>.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Up to 255 UTF-8 characters in length.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Entries. 
        /// <para>
        /// One or more entries for the prefix list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public List<AddPrefixListEntry> Entries
        {
            get { return this._entries; }
            set { this._entries = value; }
        }

        // Check to see if Entries property is set
        internal bool IsSetEntries()
        {
            return this._entries != null && this._entries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxEntries. 
        /// <para>
        /// The maximum number of entries for the prefix list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int MaxEntries
        {
            get { return this._maxEntries.GetValueOrDefault(); }
            set { this._maxEntries = value; }
        }

        // Check to see if MaxEntries property is set
        internal bool IsSetMaxEntries()
        {
            return this._maxEntries.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PrefixListName. 
        /// <para>
        /// A name for the prefix list.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Up to 255 characters in length. The name cannot start with <code>com.amazonaws</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PrefixListName
        {
            get { return this._prefixListName; }
            set { this._prefixListName = value; }
        }

        // Check to see if PrefixListName property is set
        internal bool IsSetPrefixListName()
        {
            return this._prefixListName != null;
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the prefix list during creation.
        /// </para>
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && this._tagSpecifications.Count > 0; 
        }

    }
}