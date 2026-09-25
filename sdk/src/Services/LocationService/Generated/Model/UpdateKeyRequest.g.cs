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

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateKey operation. Updates the specified properties
    /// of a given API key resource.
    /// </summary>
    public partial class UpdateKeyRequest : AmazonLocationServiceRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Updates the description for the API key resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ExpireTime. 
        /// <para>
        /// Updates the timestamp for when the API key resource will expire in <a href="https://www.iso.org/iso-8601-date-and-time-format.html">
        /// ISO 8601</a> format: <c>YYYY-MM-DDThh:mm:ss.sssZ</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public DateTime? ExpireTime { get; set; }

        /// <summary>
        /// Checks to see if the ExpireTime property is set.
        /// </summary>
        internal bool IsSetExpireTime() => this.ExpireTime.HasValue;

        /// <summary>
        /// Gets and sets the property ForceUpdate. 
        /// <para>
        /// The boolean flag to be included for updating <c>ExpireTime</c> or <c>Restrictions</c>
        /// details.
        /// </para>
        ///  
        /// <para>
        /// Must be set to <c>true</c> to update an API key resource that has been used in the
        /// past 7 days.
        /// </para>
        ///  
        /// <para>
        ///  <c>False</c> if force update is not preferred
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>False</c> 
        /// </para>
        /// </summary>
        public bool? ForceUpdate { get; set; }

        /// <summary>
        /// Checks to see if the ForceUpdate property is set.
        /// </summary>
        internal bool IsSetForceUpdate() => this.ForceUpdate.HasValue;

        /// <summary>
        /// Gets and sets the property KeyName. 
        /// <para>
        /// The name of the API key resource to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string KeyName { get; set; }

        /// <summary>
        /// Checks to see if the KeyName property is set.
        /// </summary>
        internal bool IsSetKeyName() => this.KeyName != null;

        /// <summary>
        /// Gets and sets the property NoExpiry. 
        /// <para>
        /// Whether the API key should expire. Set to <c>true</c> to set the API key to have no
        /// expiration time.
        /// </para>
        /// </summary>
        public bool? NoExpiry { get; set; }

        /// <summary>
        /// Checks to see if the NoExpiry property is set.
        /// </summary>
        internal bool IsSetNoExpiry() => this.NoExpiry.HasValue;

        /// <summary>
        /// Gets and sets the property Restrictions. 
        /// <para>
        /// Updates the API key restrictions for the API key resource.
        /// </para>
        /// </summary>
        public ApiKeyRestrictions Restrictions { get; set; }

        /// <summary>
        /// Checks to see if the Restrictions property is set.
        /// </summary>
        internal bool IsSetRestrictions() => this.Restrictions != null;
    }
}
