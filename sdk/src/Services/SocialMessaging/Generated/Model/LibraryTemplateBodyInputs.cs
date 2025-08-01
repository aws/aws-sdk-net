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
 * Do not modify this file. This file is generated from the socialmessaging-2024-01-01.normal.json service model.
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
        private bool? _addContactNumber;
        private bool? _addLearnMoreLink;
        private bool? _addSecurityRecommendation;
        private bool? _addTrackPackageLink;
        private int? _codeExpirationMinutes;

        /// <summary>
        /// Gets and sets the property AddContactNumber. 
        /// <para>
        /// When true, includes a contact number in the template body.
        /// </para>
        /// </summary>
        public bool? AddContactNumber
        {
            get { return this._addContactNumber; }
            set { this._addContactNumber = value; }
        }

        // Check to see if AddContactNumber property is set
        internal bool IsSetAddContactNumber()
        {
            return this._addContactNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AddLearnMoreLink. 
        /// <para>
        /// When true, includes a "learn more" link in the template body.
        /// </para>
        /// </summary>
        public bool? AddLearnMoreLink
        {
            get { return this._addLearnMoreLink; }
            set { this._addLearnMoreLink = value; }
        }

        // Check to see if AddLearnMoreLink property is set
        internal bool IsSetAddLearnMoreLink()
        {
            return this._addLearnMoreLink.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AddSecurityRecommendation. 
        /// <para>
        /// When true, includes security recommendations in the template body.
        /// </para>
        /// </summary>
        public bool? AddSecurityRecommendation
        {
            get { return this._addSecurityRecommendation; }
            set { this._addSecurityRecommendation = value; }
        }

        // Check to see if AddSecurityRecommendation property is set
        internal bool IsSetAddSecurityRecommendation()
        {
            return this._addSecurityRecommendation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AddTrackPackageLink. 
        /// <para>
        /// When true, includes a package tracking link in the template body.
        /// </para>
        /// </summary>
        public bool? AddTrackPackageLink
        {
            get { return this._addTrackPackageLink; }
            set { this._addTrackPackageLink = value; }
        }

        // Check to see if AddTrackPackageLink property is set
        internal bool IsSetAddTrackPackageLink()
        {
            return this._addTrackPackageLink.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CodeExpirationMinutes. 
        /// <para>
        /// The number of minutes until a verification code or OTP expires.
        /// </para>
        /// </summary>
        public int? CodeExpirationMinutes
        {
            get { return this._codeExpirationMinutes; }
            set { this._codeExpirationMinutes = value; }
        }

        // Check to see if CodeExpirationMinutes property is set
        internal bool IsSetCodeExpirationMinutes()
        {
            return this._codeExpirationMinutes.HasValue; 
        }

    }
}