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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
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
namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// The processing rules for when a registration can be associated with an origination
    /// identity and disassociated from an origination identity.
    /// </summary>
    public partial class SupportedAssociation
    {
        private RegistrationAssociationBehavior _associationBehavior;
        private RegistrationDisassociationBehavior _disassociationBehavior;
        private string _isoCountryCode;
        private string _resourceType;

        /// <summary>
        /// Gets and sets the property AssociationBehavior. 
        /// <para>
        /// The association behavior.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ASSOCIATE_BEFORE_SUBMIT</c> The origination identity has to be supplied when creating
        /// a registration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ASSOCIATE_ON_APPROVAL</c> This applies to all sender ID registrations. The sender
        /// ID will be automatically provisioned once the registration is approved.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ASSOCIATE_AFTER_COMPLETE</c> This applies to phone number registrations when you
        /// must complete a registration first, then associate one or more phone numbers later.
        /// For example 10DLC campaigns and long codes. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public RegistrationAssociationBehavior AssociationBehavior
        {
            get { return this._associationBehavior; }
            set { this._associationBehavior = value; }
        }

        // Check to see if AssociationBehavior property is set
        internal bool IsSetAssociationBehavior()
        {
            return this._associationBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property DisassociationBehavior. 
        /// <para>
        /// The disassociation behavior.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DISASSOCIATE_ALL_CLOSES_REGISTRATION</c> All origination identities must be disassociated
        /// from the registration before the registration can be closed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISASSOCIATE_ALL_ALLOWS_DELETE_REGISTRATION</c> All origination identities must
        /// be disassociated from the registration before the registration can be deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETE_REGISTRATION_DISASSOCIATES</c> The registration can be deleted and all
        /// origination identities will be disasscoiated.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public RegistrationDisassociationBehavior DisassociationBehavior
        {
            get { return this._disassociationBehavior; }
            set { this._disassociationBehavior = value; }
        }

        // Check to see if DisassociationBehavior property is set
        internal bool IsSetDisassociationBehavior()
        {
            return this._disassociationBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property IsoCountryCode. 
        /// <para>
        /// The two-character code, in ISO 3166-1 alpha-2 format, for the country or region.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=2)]
        public string IsoCountryCode
        {
            get { return this._isoCountryCode; }
            set { this._isoCountryCode = value; }
        }

        // Check to see if IsoCountryCode property is set
        internal bool IsSetIsoCountryCode()
        {
            return this._isoCountryCode != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Defines the behavior of when an origination identity and registration can be associated
        /// with each other.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}