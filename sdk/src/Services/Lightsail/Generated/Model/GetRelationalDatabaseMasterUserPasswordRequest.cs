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
    /// Container for the parameters to the GetRelationalDatabaseMasterUserPassword operation.
    /// Returns the current, previous, or pending versions of the master user password for
    /// a Lightsail database.
    /// 
    ///  
    /// <para>
    /// The <c>GetRelationalDatabaseMasterUserPassword</c> operation supports tag-based access
    /// control via resource tags applied to the resource identified by relationalDatabaseName.
    /// </para>
    /// </summary>
    public partial class GetRelationalDatabaseMasterUserPasswordRequest : AmazonLightsailRequest
    {
        private RelationalDatabasePasswordVersion _passwordVersion;
        private string _relationalDatabaseName;

        /// <summary>
        /// Gets and sets the property PasswordVersion. 
        /// <para>
        /// The password version to return.
        /// </para>
        ///  
        /// <para>
        /// Specifying <c>CURRENT</c> or <c>PREVIOUS</c> returns the current or previous passwords
        /// respectively. Specifying <c>PENDING</c> returns the newest version of the password
        /// that will rotate to <c>CURRENT</c>. After the <c>PENDING</c> password rotates to <c>CURRENT</c>,
        /// the <c>PENDING</c> password is no longer available.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>CURRENT</c> 
        /// </para>
        /// </summary>
        public RelationalDatabasePasswordVersion PasswordVersion
        {
            get { return this._passwordVersion; }
            set { this._passwordVersion = value; }
        }

        // Check to see if PasswordVersion property is set
        internal bool IsSetPasswordVersion()
        {
            return this._passwordVersion != null;
        }

        /// <summary>
        /// Gets and sets the property RelationalDatabaseName. 
        /// <para>
        /// The name of your database for which to get the master user password.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RelationalDatabaseName
        {
            get { return this._relationalDatabaseName; }
            set { this._relationalDatabaseName = value; }
        }

        // Check to see if RelationalDatabaseName property is set
        internal bool IsSetRelationalDatabaseName()
        {
            return this._relationalDatabaseName != null;
        }

    }
}