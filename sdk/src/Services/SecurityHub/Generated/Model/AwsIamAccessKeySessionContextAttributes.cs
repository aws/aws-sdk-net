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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Attributes of the session that the key was used for.
    /// </summary>
    public partial class AwsIamAccessKeySessionContextAttributes
    {
        private string _creationDate;
        private bool? _mfaAuthenticated;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// Indicates when the session was created.
        /// </para>
        ///  
        /// <para>
        /// Uses the <code>date-time</code> format specified in <a href="https://tools.ietf.org/html/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>. The value cannot contain spaces,
        /// and date and time should be separated by <code>T</code>. For example, <code>2020-03-22T13:22:13.933Z</code>.
        /// </para>
        /// </summary>
        public string CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate != null;
        }

        /// <summary>
        /// Gets and sets the property MfaAuthenticated. 
        /// <para>
        /// Indicates whether the session used multi-factor authentication (MFA).
        /// </para>
        /// </summary>
        public bool MfaAuthenticated
        {
            get { return this._mfaAuthenticated.GetValueOrDefault(); }
            set { this._mfaAuthenticated = value; }
        }

        // Check to see if MfaAuthenticated property is set
        internal bool IsSetMfaAuthenticated()
        {
            return this._mfaAuthenticated.HasValue; 
        }

    }
}