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
    /// Contains summary information about a registration that is associated with a brand
    /// profile.
    /// </summary>
    public partial class RegistrationAssociationSummary
    {
        private DateTime? _createdAt;
        private string _registrationId;
        private string _registrationType;
        private bool? _smartMatchUsed;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when the resource was created, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RegistrationId. 
        /// <para>
        /// The identifier of the registration.
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
        /// Gets and sets the property RegistrationType. 
        /// <para>
        /// The type of the registration, for example US_TOLL_FREE_REGISTRATION or SENDER_ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string RegistrationType
        {
            get { return this._registrationType; }
            set { this._registrationType = value; }
        }

        // Check to see if RegistrationType property is set
        internal bool IsSetRegistrationType()
        {
            return this._registrationType != null;
        }

        /// <summary>
        /// Gets and sets the property SmartMatchUsed. 
        /// <para>
        /// Specifies whether smart matching was used to create the association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? SmartMatchUsed
        {
            get { return this._smartMatchUsed; }
            set { this._smartMatchUsed = value; }
        }

        // Check to see if SmartMatchUsed property is set
        internal bool IsSetSmartMatchUsed()
        {
            return this._smartMatchUsed.HasValue; 
        }

    }
}