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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
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
namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyEndpointEncryptionMode operation.
    /// Modifies the endpoint encryption mode that allows you to configure the specified directory
    /// between Standard TLS and FIPS 140-2 validated mode.
    /// </summary>
    public partial class ModifyEndpointEncryptionModeRequest : AmazonWorkSpacesRequest
    {
        private string _directoryId;
        private EndpointEncryptionMode _endpointEncryptionMode;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        ///  The identifier of the directory.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=65)]
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointEncryptionMode. 
        /// <para>
        /// The encryption mode used for endpoint connections when streaming to WorkSpaces Personal
        /// or WorkSpace Pools.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EndpointEncryptionMode EndpointEncryptionMode
        {
            get { return this._endpointEncryptionMode; }
            set { this._endpointEncryptionMode = value; }
        }

        // Check to see if EndpointEncryptionMode property is set
        internal bool IsSetEndpointEncryptionMode()
        {
            return this._endpointEncryptionMode != null;
        }

    }
}