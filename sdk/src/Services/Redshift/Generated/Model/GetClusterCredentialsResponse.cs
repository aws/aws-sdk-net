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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Temporary credentials with authorization to log on to an Amazon Redshift database.
    /// </summary>
    public partial class GetClusterCredentialsResponse : AmazonWebServiceResponse
    {
        private string _dbPassword;
        private string _dbUser;
        private DateTime? _expiration;

        /// <summary>
        /// Gets and sets the property DbPassword. 
        /// <para>
        /// A temporary password that authorizes the user name returned by <code>DbUser</code>
        /// to log on to the database <code>DbName</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string DbPassword
        {
            get { return this._dbPassword; }
            set { this._dbPassword = value; }
        }

        // Check to see if DbPassword property is set
        internal bool IsSetDbPassword()
        {
            return this._dbPassword != null;
        }

        /// <summary>
        /// Gets and sets the property DbUser. 
        /// <para>
        /// A database user name that is authorized to log on to the database <code>DbName</code>
        /// using the password <code>DbPassword</code>. If the specified DbUser exists in the
        /// database, the new user name has the same database permissions as the the user named
        /// in DbUser. By default, the user is added to PUBLIC. If the <code>DbGroups</code> parameter
        /// is specifed, <code>DbUser</code> is added to the listed groups for any sessions created
        /// using these credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string DbUser
        {
            get { return this._dbUser; }
            set { this._dbUser = value; }
        }

        // Check to see if DbUser property is set
        internal bool IsSetDbUser()
        {
            return this._dbUser != null;
        }

        /// <summary>
        /// Gets and sets the property Expiration. 
        /// <para>
        /// The date and time the password in <code>DbPassword</code> expires.
        /// </para>
        /// </summary>
        public DateTime Expiration
        {
            get { return this._expiration.GetValueOrDefault(); }
            set { this._expiration = value; }
        }

        // Check to see if Expiration property is set
        internal bool IsSetExpiration()
        {
            return this._expiration.HasValue; 
        }

    }
}