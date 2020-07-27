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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Provides information that defines an Oracle endpoint.
    /// </summary>
    public partial class OracleSettings
    {
        private string _asmPassword;
        private string _asmServer;
        private string _asmUser;
        private string _databaseName;
        private string _password;
        private int? _port;
        private string _securityDbEncryption;
        private string _securityDbEncryptionName;
        private string _serverName;
        private string _username;

        /// <summary>
        /// Gets and sets the property AsmPassword. 
        /// <para>
        /// For an Oracle source endpoint, your Oracle Automatic Storage Management (ASM) password.
        /// You can set this value from the <code> <i>asm_user_password</i> </code> value. You
        /// set this value as part of the comma-separated value that you set to the <code>Password</code>
        /// request parameter when you create the endpoint to access transaction logs using Binary
        /// Reader. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Source.Oracle.html#dms/latest/userguide/CHAP_Source.Oracle.html#CHAP_Source.Oracle.CDC.Configuration">Configuration
        /// for change data capture (CDC) on an Oracle source database</a>.
        /// </para>
        /// </summary>
        public string AsmPassword
        {
            get { return this._asmPassword; }
            set { this._asmPassword = value; }
        }

        // Check to see if AsmPassword property is set
        internal bool IsSetAsmPassword()
        {
            return this._asmPassword != null;
        }

        /// <summary>
        /// Gets and sets the property AsmServer. 
        /// <para>
        /// For an Oracle source endpoint, your ASM server address. You can set this value from
        /// the <code>asm_server</code> value. You set <code>asm_server</code> as part of the
        /// extra connection attribute string to access an Oracle server with Binary Reader that
        /// uses ASM. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Source.Oracle.html#dms/latest/userguide/CHAP_Source.Oracle.html#CHAP_Source.Oracle.CDC.Configuration">Configuration
        /// for change data capture (CDC) on an Oracle source database</a>.
        /// </para>
        /// </summary>
        public string AsmServer
        {
            get { return this._asmServer; }
            set { this._asmServer = value; }
        }

        // Check to see if AsmServer property is set
        internal bool IsSetAsmServer()
        {
            return this._asmServer != null;
        }

        /// <summary>
        /// Gets and sets the property AsmUser. 
        /// <para>
        /// For an Oracle source endpoint, your ASM user name. You can set this value from the
        /// <code>asm_user</code> value. You set <code>asm_user</code> as part of the extra connection
        /// attribute string to access an Oracle server with Binary Reader that uses ASM. For
        /// more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Source.Oracle.html#dms/latest/userguide/CHAP_Source.Oracle.html#CHAP_Source.Oracle.CDC.Configuration">Configuration
        /// for change data capture (CDC) on an Oracle source database</a>.
        /// </para>
        /// </summary>
        public string AsmUser
        {
            get { return this._asmUser; }
            set { this._asmUser = value; }
        }

        // Check to see if AsmUser property is set
        internal bool IsSetAsmUser()
        {
            return this._asmUser != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// Database name for the endpoint.
        /// </para>
        /// </summary>
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// Endpoint connection password.
        /// </para>
        /// </summary>
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }

        // Check to see if Password property is set
        internal bool IsSetPassword()
        {
            return this._password != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// Endpoint TCP port.
        /// </para>
        /// </summary>
        public int Port
        {
            get { return this._port.GetValueOrDefault(); }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecurityDbEncryption. 
        /// <para>
        /// For an Oracle source endpoint, the transparent data encryption (TDE) password required
        /// by AWM DMS to access Oracle redo logs encrypted by TDE using Binary Reader. It is
        /// also the <code> <i>TDE_Password</i> </code> part of the comma-separated value you
        /// set to the <code>Password</code> request parameter when you create the endpoint. The
        /// <code>SecurityDbEncryptian</code> setting is related to this <code>SecurityDbEncryptionName</code>
        /// setting. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Source.Oracle.html#CHAP_Source.Oracle.Encryption">
        /// Supported encryption methods for using Oracle as a source for AWS DMS</a> in the <i>AWS
        /// Database Migration Service User Guide</i>. 
        /// </para>
        /// </summary>
        public string SecurityDbEncryption
        {
            get { return this._securityDbEncryption; }
            set { this._securityDbEncryption = value; }
        }

        // Check to see if SecurityDbEncryption property is set
        internal bool IsSetSecurityDbEncryption()
        {
            return this._securityDbEncryption != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityDbEncryptionName. 
        /// <para>
        /// For an Oracle source endpoint, the name of a key used for the transparent data encryption
        /// (TDE) of the columns and tablespaces in an Oracle source database that is encrypted
        /// using TDE. The key value is the value of the <code>SecurityDbEncryption</code> setting.
        /// For more information on setting the key name value of <code>SecurityDbEncryptionName</code>,
        /// see the information and example for setting the <code>securityDbEncryptionName</code>
        /// extra connection attribute in <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Source.Oracle.html#CHAP_Source.Oracle.Encryption">
        /// Supported encryption methods for using Oracle as a source for AWS DMS</a> in the <i>AWS
        /// Database Migration Service User Guide</i>.
        /// </para>
        /// </summary>
        public string SecurityDbEncryptionName
        {
            get { return this._securityDbEncryptionName; }
            set { this._securityDbEncryptionName = value; }
        }

        // Check to see if SecurityDbEncryptionName property is set
        internal bool IsSetSecurityDbEncryptionName()
        {
            return this._securityDbEncryptionName != null;
        }

        /// <summary>
        /// Gets and sets the property ServerName. 
        /// <para>
        /// Fully qualified domain name of the endpoint.
        /// </para>
        /// </summary>
        public string ServerName
        {
            get { return this._serverName; }
            set { this._serverName = value; }
        }

        // Check to see if ServerName property is set
        internal bool IsSetServerName()
        {
            return this._serverName != null;
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// Endpoint connection user name.
        /// </para>
        /// </summary>
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

    }
}