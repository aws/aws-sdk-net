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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Specifies the settings required for kerberos authentication when creating the replication
    /// instance.
    /// </summary>
    public partial class KerberosAuthenticationSettings
    {
        private string _keyCacheSecretIamArn;
        private string _keyCacheSecretId;
        private string _krb5FileContents;

        /// <summary>
        /// Gets and sets the property KeyCacheSecretIamArn. 
        /// <para>
        /// Specifies the Amazon Resource Name (ARN) of the IAM role that grants Amazon Web Services
        /// DMS access to the secret containing key cache file for the kerberos authentication.
        /// </para>
        /// </summary>
        public string KeyCacheSecretIamArn
        {
            get { return this._keyCacheSecretIamArn; }
            set { this._keyCacheSecretIamArn = value; }
        }

        // Check to see if KeyCacheSecretIamArn property is set
        internal bool IsSetKeyCacheSecretIamArn()
        {
            return this._keyCacheSecretIamArn != null;
        }

        /// <summary>
        /// Gets and sets the property KeyCacheSecretId. 
        /// <para>
        /// Specifies the ID of the secret that stores the key cache file required for kerberos
        /// authentication.
        /// </para>
        /// </summary>
        public string KeyCacheSecretId
        {
            get { return this._keyCacheSecretId; }
            set { this._keyCacheSecretId = value; }
        }

        // Check to see if KeyCacheSecretId property is set
        internal bool IsSetKeyCacheSecretId()
        {
            return this._keyCacheSecretId != null;
        }

        /// <summary>
        /// Gets and sets the property Krb5FileContents. 
        /// <para>
        /// Specifies the contents of krb5 configuration file required for kerberos authentication.
        /// </para>
        /// </summary>
        public string Krb5FileContents
        {
            get { return this._krb5FileContents; }
            set { this._krb5FileContents = value; }
        }

        // Check to see if Krb5FileContents property is set
        internal bool IsSetKrb5FileContents()
        {
            return this._krb5FileContents != null;
        }

    }
}