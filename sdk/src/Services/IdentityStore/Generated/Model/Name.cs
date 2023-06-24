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
 * Do not modify this file. This file is generated from the identitystore-2020-06-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityStore.Model
{
    /// <summary>
    /// The full name of the user.
    /// </summary>
    public partial class Name
    {
        private string _familyName;
        private string _formatted;
        private string _givenName;
        private string _honorificPrefix;
        private string _honorificSuffix;
        private string _middleName;

        /// <summary>
        /// Gets and sets the property FamilyName. 
        /// <para>
        /// The family name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string FamilyName
        {
            get { return this._familyName; }
            set { this._familyName = value; }
        }

        // Check to see if FamilyName property is set
        internal bool IsSetFamilyName()
        {
            return this._familyName != null;
        }

        /// <summary>
        /// Gets and sets the property Formatted. 
        /// <para>
        /// A string containing a formatted version of the name for display.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string Formatted
        {
            get { return this._formatted; }
            set { this._formatted = value; }
        }

        // Check to see if Formatted property is set
        internal bool IsSetFormatted()
        {
            return this._formatted != null;
        }

        /// <summary>
        /// Gets and sets the property GivenName. 
        /// <para>
        /// The given name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string GivenName
        {
            get { return this._givenName; }
            set { this._givenName = value; }
        }

        // Check to see if GivenName property is set
        internal bool IsSetGivenName()
        {
            return this._givenName != null;
        }

        /// <summary>
        /// Gets and sets the property HonorificPrefix. 
        /// <para>
        /// The honorific prefix of the user. For example, "Dr."
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string HonorificPrefix
        {
            get { return this._honorificPrefix; }
            set { this._honorificPrefix = value; }
        }

        // Check to see if HonorificPrefix property is set
        internal bool IsSetHonorificPrefix()
        {
            return this._honorificPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property HonorificSuffix. 
        /// <para>
        /// The honorific suffix of the user. For example, "M.D."
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string HonorificSuffix
        {
            get { return this._honorificSuffix; }
            set { this._honorificSuffix = value; }
        }

        // Check to see if HonorificSuffix property is set
        internal bool IsSetHonorificSuffix()
        {
            return this._honorificSuffix != null;
        }

        /// <summary>
        /// Gets and sets the property MiddleName. 
        /// <para>
        /// The middle name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string MiddleName
        {
            get { return this._middleName; }
            set { this._middleName = value; }
        }

        // Check to see if MiddleName property is set
        internal bool IsSetMiddleName()
        {
            return this._middleName != null;
        }

    }
}