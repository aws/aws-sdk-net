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

namespace Amazon.SocialMessaging.Model
{
    /// <summary>
    /// Configuration options for customizing the body content of a template from Meta's library.
    /// </summary>
    public partial class LibraryTemplateBodyInputs
    {
        /// <summary>
        /// Gets and sets the property AddContactNumber. 
        /// <para>
        /// When true, includes a contact number in the template body.
        /// </para>
        /// </summary>
        public bool? AddContactNumber { get; set; }

        /// <summary>
        /// Checks to see if the AddContactNumber property is set.
        /// </summary>
        internal bool IsSetAddContactNumber() => this.AddContactNumber.HasValue;

        /// <summary>
        /// Gets and sets the property AddLearnMoreLink. 
        /// <para>
        /// When true, includes a "learn more" link in the template body.
        /// </para>
        /// </summary>
        public bool? AddLearnMoreLink { get; set; }

        /// <summary>
        /// Checks to see if the AddLearnMoreLink property is set.
        /// </summary>
        internal bool IsSetAddLearnMoreLink() => this.AddLearnMoreLink.HasValue;

        /// <summary>
        /// Gets and sets the property AddSecurityRecommendation. 
        /// <para>
        /// When true, includes security recommendations in the template body.
        /// </para>
        /// </summary>
        public bool? AddSecurityRecommendation { get; set; }

        /// <summary>
        /// Checks to see if the AddSecurityRecommendation property is set.
        /// </summary>
        internal bool IsSetAddSecurityRecommendation() => this.AddSecurityRecommendation.HasValue;

        /// <summary>
        /// Gets and sets the property AddTrackPackageLink. 
        /// <para>
        /// When true, includes a package tracking link in the template body.
        /// </para>
        /// </summary>
        public bool? AddTrackPackageLink { get; set; }

        /// <summary>
        /// Checks to see if the AddTrackPackageLink property is set.
        /// </summary>
        internal bool IsSetAddTrackPackageLink() => this.AddTrackPackageLink.HasValue;

        /// <summary>
        /// Gets and sets the property CodeExpirationMinutes. 
        /// <para>
        /// The number of minutes until a verification code or OTP expires.
        /// </para>
        /// </summary>
        public int? CodeExpirationMinutes { get; set; }

        /// <summary>
        /// Checks to see if the CodeExpirationMinutes property is set.
        /// </summary>
        internal bool IsSetCodeExpirationMinutes() => this.CodeExpirationMinutes.HasValue;
    }
}
