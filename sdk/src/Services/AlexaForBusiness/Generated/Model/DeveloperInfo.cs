/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// The details about the developer that published the skill.
    /// </summary>
    public partial class DeveloperInfo
    {
        private string _developerName;
        private string _email;
        private string _privacyPolicy;
        private string _url;

        /// <summary>
        /// Gets and sets the property DeveloperName. 
        /// <para>
        /// The name of the developer.
        /// </para>
        /// </summary>
        public string DeveloperName
        {
            get { return this._developerName; }
            set { this._developerName = value; }
        }

        // Check to see if DeveloperName property is set
        internal bool IsSetDeveloperName()
        {
            return this._developerName != null;
        }

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The email of the developer.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property PrivacyPolicy. 
        /// <para>
        /// The URL of the privacy policy.
        /// </para>
        /// </summary>
        public string PrivacyPolicy
        {
            get { return this._privacyPolicy; }
            set { this._privacyPolicy = value; }
        }

        // Check to see if PrivacyPolicy property is set
        internal bool IsSetPrivacyPolicy()
        {
            return this._privacyPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The website of the developer.
        /// </para>
        /// </summary>
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}