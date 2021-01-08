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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Amazon Redshift parameters. The <code>ClusterId</code> field can be blank if <code>Host</code>
    /// and <code>Port</code> are both set. The <code>Host</code> and <code>Port</code> fields
    /// can be blank if the <code>ClusterId</code> field is set.
    /// </summary>
    public partial class RedshiftParameters
    {
        private string _clusterId;
        private string _database;
        private string _host;
        private int? _port;

        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// Cluster ID. This field can be blank if the <code>Host</code> and <code>Port</code>
        /// are provided.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClusterId
        {
            get { return this._clusterId; }
            set { this._clusterId = value; }
        }

        // Check to see if ClusterId property is set
        internal bool IsSetClusterId()
        {
            return this._clusterId != null;
        }

        /// <summary>
        /// Gets and sets the property Database. 
        /// <para>
        /// Database.
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
        /// Host. This field can be blank if <code>ClusterId</code> is provided.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Port. This field can be blank if the <code>ClusterId</code> is provided.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65535)]
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

    }
}