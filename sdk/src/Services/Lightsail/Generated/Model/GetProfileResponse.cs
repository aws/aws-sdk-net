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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// This is the response object from the GetProfile operation.
    /// </summary>
    public partial class GetProfileResponse : AmazonWebServiceResponse
    {
        private PartnerInfo _partner;
        private ProfileType _profileType;

        /// <summary>
        /// Gets and sets the property Partner. 
        /// <para>
        /// An object that describes the partner membership of the account, such as the tier of
        /// the membership, its status, and when the account was enrolled.
        /// </para>
        ///  
        /// <para>
        /// This parameter is returned only for accounts that have a <c>profileType</c> of <c>LightsailPartner</c>.
        /// </para>
        /// </summary>
        public PartnerInfo Partner
        {
            get { return this._partner; }
            set { this._partner = value; }
        }

        // Check to see if Partner property is set
        internal bool IsSetPartner()
        {
            return this._partner != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileType. 
        /// <para>
        /// The type of the profile.
        /// </para>
        ///  
        /// <para>
        /// The following profile types are possible:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Lightsailor</c> – The account is not enrolled in the Lightsail partner program.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LightsailPartner</c> – The account is enrolled in the Lightsail partner program.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProfileType ProfileType
        {
            get { return this._profileType; }
            set { this._profileType = value; }
        }

        // Check to see if ProfileType property is set
        internal bool IsSetProfileType()
        {
            return this._profileType != null;
        }

    }
}