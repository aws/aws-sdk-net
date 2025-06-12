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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateManagedPrefixList operation.
    /// Creates a managed prefix list. You can specify entries for the prefix list. Each entry
    /// consists of a CIDR block and an optional description.
    /// </summary>
    public partial class CreateManagedPrefixListRequest : AmazonEC2Request
    {
        private string _addressFamily;
        private string _clientToken;
        private bool? _dryRun;
        private List<AddPrefixListEntry> _entries = AWSConfigs.InitializeCollections ? new List<AddPrefixListEntry>() : null;
        private int? _maxEntries;
        private string _prefixListName;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Gets and sets the property AddressFamily. 
        /// <para>
        /// The IP address type.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>IPv4</c> | <c>IPv6</c> 
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
        /// For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-idempotency.html">Ensuring
        /// idempotency</a>.
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
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Entries. 
        /// <para>
        /// One or more entries for the prefix list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<AddPrefixListEntry> Entries
        {
            get { return this._entries; }
            set { this._entries = value; }
        }

        // Check to see if Entries property is set
        internal bool IsSetEntries()
        {
            return this._entries != null && (this._entries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxEntries. 
        /// <para>
        /// The maximum number of entries for the prefix list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? MaxEntries
        {
            get { return this._maxEntries; }
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
        /// Constraints: Up to 255 characters in length. The name cannot start with <c>com.amazonaws</c>.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && (this._tagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}