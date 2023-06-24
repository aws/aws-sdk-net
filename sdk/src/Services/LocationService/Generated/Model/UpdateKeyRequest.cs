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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateKey operation.
    /// Updates the specified properties of a given API key resource.
    /// 
    ///  <important> 
    /// <para>
    /// The API keys feature is in preview. We may add, change, or remove features before
    /// announcing general availability. For more information, see <a href="https://docs.aws.amazon.com/location/latest/developerguide/using-apikeys.html">Using
    /// API keys</a>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class UpdateKeyRequest : AmazonLocationServiceRequest
    {
        private string _description;
        private DateTime? _expireTime;
        private bool? _forceUpdate;
        private string _keyName;
        private bool? _noExpiry;
        private ApiKeyRestrictions _restrictions;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Updates the description for the API key resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
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
        /// Gets and sets the property ExpireTime. 
        /// <para>
        /// Updates the timestamp for when the API key resource will expire in <a href="https://www.iso.org/iso-8601-date-and-time-format.html">
        /// ISO 8601</a> format: <code>YYYY-MM-DDThh:mm:ss.sssZ</code>. 
        /// </para>
        /// </summary>
        public DateTime ExpireTime
        {
            get { return this._expireTime.GetValueOrDefault(); }
            set { this._expireTime = value; }
        }

        // Check to see if ExpireTime property is set
        internal bool IsSetExpireTime()
        {
            return this._expireTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ForceUpdate. 
        /// <para>
        /// The boolean flag to be included for updating <code>ExpireTime</code> or <code>Restrictions</code>
        /// details.
        /// </para>
        ///  
        /// <para>
        /// Must be set to <code>true</code> to update an API key resource that has been used
        /// in the past 7 days.
        /// </para>
        ///  
        /// <para>
        ///  <code>False</code> if force update is not preferred
        /// </para>
        ///  
        /// <para>
        /// Default value: <code>False</code> 
        /// </para>
        /// </summary>
        public bool ForceUpdate
        {
            get { return this._forceUpdate.GetValueOrDefault(); }
            set { this._forceUpdate = value; }
        }

        // Check to see if ForceUpdate property is set
        internal bool IsSetForceUpdate()
        {
            return this._forceUpdate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KeyName. 
        /// <para>
        /// The name of the API key resource to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string KeyName
        {
            get { return this._keyName; }
            set { this._keyName = value; }
        }

        // Check to see if KeyName property is set
        internal bool IsSetKeyName()
        {
            return this._keyName != null;
        }

        /// <summary>
        /// Gets and sets the property NoExpiry. 
        /// <para>
        /// Whether the API key should expire. Set to <code>true</code> to set the API key to
        /// have no expiration time.
        /// </para>
        /// </summary>
        public bool NoExpiry
        {
            get { return this._noExpiry.GetValueOrDefault(); }
            set { this._noExpiry = value; }
        }

        // Check to see if NoExpiry property is set
        internal bool IsSetNoExpiry()
        {
            return this._noExpiry.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Restrictions. 
        /// <para>
        /// Updates the API key restrictions for the API key resource.
        /// </para>
        /// </summary>
        public ApiKeyRestrictions Restrictions
        {
            get { return this._restrictions; }
            set { this._restrictions = value; }
        }

        // Check to see if Restrictions property is set
        internal bool IsSetRestrictions()
        {
            return this._restrictions != null;
        }

    }
}