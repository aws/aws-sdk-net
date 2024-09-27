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
 * Do not modify this file. This file is generated from the directory-service-data-2023-05-31.normal.json service model.
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
namespace Amazon.DirectoryServiceData.Model
{
    /// <summary>
    /// A structure containing a subset of the fields of a user object from a directory.
    /// </summary>
    public partial class UserSummary
    {
        private bool? _enabled;
        private string _givenName;
        private string _samAccountName;
        private string _sid;
        private string _surname;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether the user account is active.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GivenName. 
        /// <para>
        /// The first name of the user. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=64)]
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
        /// Gets and sets the property SAMAccountName. 
        /// <para>
        /// The name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public string SAMAccountName
        {
            get { return this._samAccountName; }
            set { this._samAccountName = value; }
        }

        // Check to see if SAMAccountName property is set
        internal bool IsSetSAMAccountName()
        {
            return this._samAccountName != null;
        }

        /// <summary>
        /// Gets and sets the property SID. 
        /// <para>
        ///  The unique security identifier (SID) of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string SID
        {
            get { return this._sid; }
            set { this._sid = value; }
        }

        // Check to see if SID property is set
        internal bool IsSetSID()
        {
            return this._sid != null;
        }

        /// <summary>
        /// Gets and sets the property Surname. 
        /// <para>
        /// The last name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=64)]
        public string Surname
        {
            get { return this._surname; }
            set { this._surname = value; }
        }

        // Check to see if Surname property is set
        internal bool IsSetSurname()
        {
            return this._surname != null;
        }

    }
}