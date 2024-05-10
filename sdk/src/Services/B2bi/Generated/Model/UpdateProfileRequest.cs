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
 * Do not modify this file. This file is generated from the b2bi-2022-06-23.normal.json service model.
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
namespace Amazon.B2bi.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateProfile operation.
    /// Updates the specified parameters for a profile. A profile is the mechanism used to
    /// create the concept of a private network.
    /// </summary>
    public partial class UpdateProfileRequest : AmazonB2biRequest
    {
        private string _businessName;
        private string _email;
        private string _name;
        private string _phone;
        private string _profileId;

        /// <summary>
        /// Gets and sets the property BusinessName. 
        /// <para>
        /// Specifies the name for the business associated with this profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=254)]
        public string BusinessName
        {
            get { return this._businessName; }
            set { this._businessName = value; }
        }

        // Check to see if BusinessName property is set
        internal bool IsSetBusinessName()
        {
            return this._businessName != null;
        }

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// Specifies the email address associated with this customer profile.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=5, Max=254)]
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        // Check to see if Email property is set
        internal bool IsSetEmail()
        {
            return this._email != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the profile, used to identify it.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=254)]
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
        /// Gets and sets the property Phone. 
        /// <para>
        /// Specifies the phone number associated with the profile.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=7, Max=22)]
        public string Phone
        {
            get { return this._phone; }
            set { this._phone = value; }
        }

        // Check to see if Phone property is set
        internal bool IsSetPhone()
        {
            return this._phone != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// Specifies the unique, system-generated identifier for the profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ProfileId
        {
            get { return this._profileId; }
            set { this._profileId = value; }
        }

        // Check to see if ProfileId property is set
        internal bool IsSetProfileId()
        {
            return this._profileId != null;
        }

    }
}