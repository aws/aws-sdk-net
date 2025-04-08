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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The parameters for Oracle.
    /// </summary>
    public partial class OracleParameters
    {
        private string _database;
        private string _host;
        private int? _port;
        private bool? _useServiceName;

        /// <summary>
        /// Gets and sets the property Database. 
        /// <para>
        /// The database.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Database
        {
            get { return this._database; }
            set { this._database = value; }
        }

        // Check to see if Database property is set
        internal bool IsSetDatabase()
        {
            return this._database != null;
        }

        /// <summary>
        /// Gets and sets the property Host. 
        /// <para>
        /// An Oracle host.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Host
        {
            get { return this._host; }
            set { this._host = value; }
        }

        // Check to see if Host property is set
        internal bool IsSetHost()
        {
            return this._host != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=65535)]
        public int? Port
        {
            get { return this._port; }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UseServiceName. 
        /// <para>
        /// A Boolean value that indicates whether the <c>Database</c> uses a service name or
        /// an SID. If this value is left blank, the default value is <c>SID</c>. If this value
        /// is set to <c>false</c>, the value is <c>SID</c>.
        /// </para>
        /// </summary>
        public bool? UseServiceName
        {
            get { return this._useServiceName; }
            set { this._useServiceName = value; }
        }

        // Check to see if UseServiceName property is set
        internal bool IsSetUseServiceName()
        {
            return this._useServiceName.HasValue; 
        }

    }
}