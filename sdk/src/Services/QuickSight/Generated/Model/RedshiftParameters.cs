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
    /// The parameters for Amazon Redshift. The <c>ClusterId</c> field can be blank if <c>Host</c>
    /// and <c>Port</c> are both set. The <c>Host</c> and <c>Port</c> fields can be blank
    /// if the <c>ClusterId</c> field is set.
    /// </summary>
    public partial class RedshiftParameters
    {
        private string _clusterId;
        private string _database;
        private string _host;
        private RedshiftIAMParameters _iamParameters;
        private IdentityCenterConfiguration _identityCenterConfiguration;
        private int? _port;

        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// Cluster ID. This field can be blank if the <c>Host</c> and <c>Port</c> are provided.
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
        /// Host. This field can be blank if <c>ClusterId</c> is provided.
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
        /// Gets and sets the property IAMParameters. 
        /// <para>
        /// An optional parameter that uses IAM authentication to grant QuickSight access to your
        /// cluster. This parameter can be used instead of <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_DataSourceCredentials.html">DataSourceCredentials</a>.
        /// </para>
        /// </summary>
        public RedshiftIAMParameters IAMParameters
        {
            get { return this._iamParameters; }
            set { this._iamParameters = value; }
        }

        // Check to see if IAMParameters property is set
        internal bool IsSetIAMParameters()
        {
            return this._iamParameters != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityCenterConfiguration. 
        /// <para>
        /// An optional parameter that configures IAM Identity Center authentication to grant
        /// QuickSight access to your cluster.
        /// </para>
        ///  
        /// <para>
        /// This parameter can only be specified if your QuickSight account is configured with
        /// IAM Identity Center.
        /// </para>
        /// </summary>
        public IdentityCenterConfiguration IdentityCenterConfiguration
        {
            get { return this._identityCenterConfiguration; }
            set { this._identityCenterConfiguration = value; }
        }

        // Check to see if IdentityCenterConfiguration property is set
        internal bool IsSetIdentityCenterConfiguration()
        {
            return this._identityCenterConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// Port. This field can be blank if the <c>ClusterId</c> is provided.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65535)]
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

    }
}