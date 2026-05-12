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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Configuration for a filesystem that can be mounted into the AgentCore Runtime.
    /// </summary>
    public partial class FilesystemConfiguration
    {
        private EfsAccessPointConfiguration _efsAccessPoint;
        private S3FilesAccessPointConfiguration _s3FilesAccessPoint;
        private SessionStorageConfiguration _sessionStorage;

        /// <summary>
        /// Gets and sets the property EfsAccessPoint. 
        /// <para>
        /// Configuration for an Amazon EFS access point to mount into the AgentCore Runtime.
        /// </para>
        /// </summary>
        public EfsAccessPointConfiguration EfsAccessPoint
        {
            get { return this._efsAccessPoint; }
            set { this._efsAccessPoint = value; }
        }

        // Check to see if EfsAccessPoint property is set
        internal bool IsSetEfsAccessPoint()
        {
            return this._efsAccessPoint != null;
        }

        /// <summary>
        /// Gets and sets the property S3FilesAccessPoint. 
        /// <para>
        /// Configuration for an Amazon S3 Files access point to mount into the AgentCore Runtime.
        /// </para>
        /// </summary>
        public S3FilesAccessPointConfiguration S3FilesAccessPoint
        {
            get { return this._s3FilesAccessPoint; }
            set { this._s3FilesAccessPoint = value; }
        }

        // Check to see if S3FilesAccessPoint property is set
        internal bool IsSetS3FilesAccessPoint()
        {
            return this._s3FilesAccessPoint != null;
        }

        /// <summary>
        /// Gets and sets the property SessionStorage. 
        /// <para>
        /// Configuration for session storage. Session storage provides persistent storage that
        /// is preserved across AgentCore Runtime session invocations.
        /// </para>
        /// </summary>
        public SessionStorageConfiguration SessionStorage
        {
            get { return this._sessionStorage; }
            set { this._sessionStorage = value; }
        }

        // Check to see if SessionStorage property is set
        internal bool IsSetSessionStorage()
        {
            return this._sessionStorage != null;
        }

    }
}