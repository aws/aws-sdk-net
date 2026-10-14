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

namespace Amazon.B2bi.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateProfile operation. Updates the specified
    /// parameters for a profile. A profile is the mechanism used to create the concept of
    /// a private network.
    /// </summary>
    public partial class UpdateProfileRequest : AmazonB2biRequest
    {
        /// <summary>
        /// Gets and sets the property BusinessName. 
        /// <para>
        /// Specifies the name for the business associated with this profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 254)]
        public string BusinessName { get; set; }

        /// <summary>
        /// Checks to see if the BusinessName property is set.
        /// </summary>
        internal bool IsSetBusinessName() => this.BusinessName != null;

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// Specifies the email address associated with this customer profile.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 5, Max = 254)]
        public string Email { get; set; }

        /// <summary>
        /// Checks to see if the Email property is set.
        /// </summary>
        internal bool IsSetEmail() => this.Email != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the profile, used to identify it.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 254)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Phone. 
        /// <para>
        /// Specifies the phone number associated with the profile.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 7, Max = 22)]
        public string Phone { get; set; }

        /// <summary>
        /// Checks to see if the Phone property is set.
        /// </summary>
        internal bool IsSetPhone() => this.Phone != null;

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// Specifies the unique, system-generated identifier for the profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ProfileId { get; set; }

        /// <summary>
        /// Checks to see if the ProfileId property is set.
        /// </summary>
        internal bool IsSetProfileId() => this.ProfileId != null;
    }
}
