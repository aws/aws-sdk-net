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
 * Do not modify this file. This file is generated from the agent-registry-control-2025-12-01.normal.json service model.
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
namespace Amazon.AgentRegistryControl.Model
{
    /// <summary>
    /// The configuration for an IAM role credential provider that signs requests to a registry
    /// record's source with AWS Signature Version 4 (SigV4).
    /// </summary>
    public partial class RegistryRecordIamCredentialProvider
    {
        private string _region;
        private string _roleArn;
        private string _service;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The AWS Region to use for request signing. If not specified, the Region is derived
        /// from the source URL hostname, falling back to the Region of the registry.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The &amp;ARN; of the IAM role to assume for request signing.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// The service name to use for request signing, such as execute-api.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Service
        {
            get { return this._service; }
            set { this._service = value; }
        }

        // Check to see if Service property is set
        internal bool IsSetService()
        {
            return this._service != null;
        }

    }
}