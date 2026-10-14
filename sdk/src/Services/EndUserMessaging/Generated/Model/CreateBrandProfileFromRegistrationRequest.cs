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
 * Do not modify this file. This file is generated from the endusermessaging-2026-09-21.normal.json service model.
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
namespace Amazon.EndUserMessaging.Model
{
    /// <summary>
    /// Container for the parameters to the CreateBrandProfileFromRegistration operation.
    /// Creates a brand profile and populates its attributes from an existing registration.
    /// This operation runs asynchronously. Use the GetJob operation to track its progress.
    /// </summary>
    public partial class CreateBrandProfileFromRegistrationRequest : AmazonEndUserMessagingRequest
    {
        private string _brandProfileName;
        private string _clientToken;
        private string _registrationId;
        private bool? _smartMatch;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property BrandProfileName. 
        /// <para>
        /// The name of the brand profile. The name can contain alphanumeric characters, underscores,
        /// hyphens, and spaces.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string BrandProfileName
        {
            get { return this._brandProfileName; }
            set { this._brandProfileName = value; }
        }

        // Check to see if BrandProfileName property is set
        internal bool IsSetBrandProfileName()
        {
            return this._brandProfileName != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If you do not specify a client token, the AWS SDK automatically generates
        /// one.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
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
        /// Gets and sets the property RegistrationId. 
        /// <para>
        /// The identifier or Amazon Resource Name (ARN) of the registration to populate the brand
        /// profile from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string RegistrationId
        {
            get { return this._registrationId; }
            set { this._registrationId = value; }
        }

        // Check to see if RegistrationId property is set
        internal bool IsSetRegistrationId()
        {
            return this._registrationId != null;
        }

        /// <summary>
        /// Gets and sets the property SmartMatch. 
        /// <para>
        /// Specifies whether to use semantic field mapping between brand profile attributes and
        /// registration fields. The default is true. When false, the service maps fields using
        /// a fixed set of standard field types.
        /// </para>
        /// </summary>
        public bool? SmartMatch
        {
            get { return this._smartMatch; }
            set { this._smartMatch = value; }
        }

        // Check to see if SmartMatch property is set
        internal bool IsSetSmartMatch()
        {
            return this._smartMatch.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key and value pair tags that are associated with the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
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