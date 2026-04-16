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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// This data type is used as a response element in the action <c>DescribeServerlessV2PlatformVersions</c>.
    /// </summary>
    public partial class ServerlessV2PlatformVersionInfo
    {
        private string _engine;
        private bool? _isDefault;
        private ServerlessV2FeaturesSupport _serverlessV2FeaturesSupport;
        private string _serverlessV2PlatformVersion;
        private string _serverlessV2PlatformVersionDescription;
        private string _status;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The name of the database engine.
        /// </para>
        /// </summary>
        public string Engine
        {
            get { return this._engine; }
            set { this._engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this._engine != null;
        }

        /// <summary>
        /// Gets and sets the property IsDefault. 
        /// <para>
        /// Indicates whether this platform version is the default version for the engine. The
        /// default platform version is the version used for new DB clusters.
        /// </para>
        /// </summary>
        public bool? IsDefault
        {
            get { return this._isDefault; }
            set { this._isDefault = value; }
        }

        // Check to see if IsDefault property is set
        internal bool IsSetIsDefault()
        {
            return this._isDefault.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServerlessV2FeaturesSupport. 
        /// <para>
        /// Specifies any Aurora Serverless v2 properties or limits that differ between Aurora
        /// Serverless v2 platform versions. You can retrieve the platform version of an existing
        /// DB cluster and check whether that version supports certain Aurora Serverless v2 features
        /// before you attempt to use those features.
        /// </para>
        /// </summary>
        public ServerlessV2FeaturesSupport ServerlessV2FeaturesSupport
        {
            get { return this._serverlessV2FeaturesSupport; }
            set { this._serverlessV2FeaturesSupport = value; }
        }

        // Check to see if ServerlessV2FeaturesSupport property is set
        internal bool IsSetServerlessV2FeaturesSupport()
        {
            return this._serverlessV2FeaturesSupport != null;
        }

        /// <summary>
        /// Gets and sets the property ServerlessV2PlatformVersion. 
        /// <para>
        /// The version number of the serverless platform.
        /// </para>
        /// </summary>
        public string ServerlessV2PlatformVersion
        {
            get { return this._serverlessV2PlatformVersion; }
            set { this._serverlessV2PlatformVersion = value; }
        }

        // Check to see if ServerlessV2PlatformVersion property is set
        internal bool IsSetServerlessV2PlatformVersion()
        {
            return this._serverlessV2PlatformVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ServerlessV2PlatformVersionDescription. 
        /// <para>
        /// The description of the serverless platform.
        /// </para>
        /// </summary>
        public string ServerlessV2PlatformVersionDescription
        {
            get { return this._serverlessV2PlatformVersionDescription; }
            set { this._serverlessV2PlatformVersionDescription = value; }
        }

        // Check to see if ServerlessV2PlatformVersionDescription property is set
        internal bool IsSetServerlessV2PlatformVersionDescription()
        {
            return this._serverlessV2PlatformVersionDescription != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the serverless platform. Valid statuses are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>enabled</c> - The platform version is in use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>disabled</c> - The platform version is not in use.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}