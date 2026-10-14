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
    /// Container for the parameters to the CreateRegistrationsFromBrandProfile operation.
    /// Creates one or more registrations in the DRAFT state and prefills their fields from
    /// the attributes of a brand profile. This operation runs asynchronously. Use the GetJob
    /// operation to track its progress.
    /// </summary>
    public partial class CreateRegistrationsFromBrandProfileRequest : AmazonEndUserMessagingRequest
    {
        private string _brandProfileId;
        private string _clientToken;
        private List<string> _registrationTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _smartMatch;

        /// <summary>
        /// Gets and sets the property BrandProfileId. 
        /// <para>
        /// The unique identifier of the brand profile. You can specify either the bare ID or
        /// the full Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string BrandProfileId
        {
            get { return this._brandProfileId; }
            set { this._brandProfileId = value; }
        }

        // Check to see if BrandProfileId property is set
        internal bool IsSetBrandProfileId()
        {
            return this._brandProfileId != null;
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
        /// Gets and sets the property RegistrationTypes. 
        /// <para>
        /// The registration types to create, for example US_TOLL_FREE_REGISTRATION or SENDER_ID.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<string> RegistrationTypes
        {
            get { return this._registrationTypes; }
            set { this._registrationTypes = value; }
        }

        // Check to see if RegistrationTypes property is set
        internal bool IsSetRegistrationTypes()
        {
            return this._registrationTypes != null && (this._registrationTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
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

    }
}