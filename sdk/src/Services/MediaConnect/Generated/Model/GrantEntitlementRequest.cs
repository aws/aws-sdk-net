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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// The entitlements that you want to grant on a flow.
    /// </summary>
    public partial class GrantEntitlementRequest
    {
        private int? _dataTransferSubscriberFeePercent;
        private string _description;
        private Encryption _encryption;
        private EntitlementStatus _entitlementStatus;
        private string _name;
        private List<string> _subscribers = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DataTransferSubscriberFeePercent. 
        /// <para>
        ///  Percentage from 0-100 of the data transfer cost to be billed to the subscriber.
        /// </para>
        /// </summary>
        public int? DataTransferSubscriberFeePercent
        {
            get { return this._dataTransferSubscriberFeePercent; }
            set { this._dataTransferSubscriberFeePercent = value; }
        }

        // Check to see if DataTransferSubscriberFeePercent property is set
        internal bool IsSetDataTransferSubscriberFeePercent()
        {
            return this._dataTransferSubscriberFeePercent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A description of the entitlement. This description appears only on the MediaConnect
        /// console and will not be seen by the subscriber or end user. 
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
        /// Gets and sets the property Encryption. 
        /// <para>
        ///  The type of encryption that will be used on the output that is associated with this
        /// entitlement. Allowable encryption types: static-key, speke.
        /// </para>
        /// </summary>
        public Encryption Encryption
        {
            get { return this._encryption; }
            set { this._encryption = value; }
        }

        // Check to see if Encryption property is set
        internal bool IsSetEncryption()
        {
            return this._encryption != null;
        }

        /// <summary>
        /// Gets and sets the property EntitlementStatus. 
        /// <para>
        ///  An indication of whether the new entitlement should be enabled or disabled as soon
        /// as it is created. If you don’t specify the entitlementStatus field in your request,
        /// MediaConnect sets it to ENABLED.
        /// </para>
        /// </summary>
        public EntitlementStatus EntitlementStatus
        {
            get { return this._entitlementStatus; }
            set { this._entitlementStatus = value; }
        }

        // Check to see if EntitlementStatus property is set
        internal bool IsSetEntitlementStatus()
        {
            return this._entitlementStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the entitlement. This value must be unique within the current flow.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Subscribers. 
        /// <para>
        ///  The Amazon Web Services account IDs that you want to share your content with. The
        /// receiving accounts (subscribers) will be allowed to create their own flows using your
        /// content as the source.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Subscribers
        {
            get { return this._subscribers; }
            set { this._subscribers = value; }
        }

        // Check to see if Subscribers property is set
        internal bool IsSetSubscribers()
        {
            return this._subscribers != null && (this._subscribers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}