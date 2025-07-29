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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateKey operation.
    /// Creates an API key resource in your Amazon Web Services account, which lets you grant
    /// actions for Amazon Location resources to the API key bearer.
    /// 
    ///  <note> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/location/previous/developerguide/using-apikeys.html">Using
    /// API keys</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateKeyRequest : AmazonLocationServiceRequest
    {
        private string _description;
        private DateTime? _expireTime;
        private string _keyName;
        private bool? _noExpiry;
        private ApiKeyRestrictions _restrictions;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description for the API key resource.
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
        /// The optional timestamp for when the API key resource will expire in <a href="https://www.iso.org/iso-8601-date-and-time-format.html">
        /// ISO 8601</a> format: <c>YYYY-MM-DDThh:mm:ss.sssZ</c>. One of <c>NoExpiry</c> or <c>ExpireTime</c>
        /// must be set.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public DateTime? ExpireTime
        {
            get { return this._expireTime; }
            set { this._expireTime = value; }
        }

        // Check to see if ExpireTime property is set
        internal bool IsSetExpireTime()
        {
            return this._expireTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KeyName. 
        /// <para>
        /// A custom name for the API key resource.
        /// </para>
        ///  
        /// <para>
        /// Requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Contain only alphanumeric characters (A–Z, a–z, 0–9), hyphens (-), periods (.), and
        /// underscores (_). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be a unique API key name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// No spaces allowed. For example, <c>ExampleAPIKey</c>.
        /// </para>
        ///  </li> </ul>
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
        /// Optionally set to <c>true</c> to set no expiration time for the API key. One of <c>NoExpiry</c>
        /// or <c>ExpireTime</c> must be set.
        /// </para>
        /// </summary>
        public bool? NoExpiry
        {
            get { return this._noExpiry; }
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
        /// The API key restrictions for the API key resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Applies one or more tags to the map resource. A tag is a key-value pair that helps
        /// manage, identify, search, and filter your resources by labelling them.
        /// </para>
        ///  
        /// <para>
        /// Format: <c>"key" : "value"</c> 
        /// </para>
        ///  
        /// <para>
        /// Restrictions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Maximum 50 tags per resource
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each resource tag must be unique with a maximum of one value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum key length: 128 Unicode characters in UTF-8
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum value length: 256 Unicode characters in UTF-8
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can use alphanumeric characters (A–Z, a–z, 0–9), and the following characters: + -
        /// = . _ : / @. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot use "aws:" as a prefix for a key.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}