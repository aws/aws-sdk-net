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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// The scope of Azure resources that Amazon Inspector scans, defined separately for VM,
    /// container image, and serverless scanning. Returned as part of a connector's configuration.
    /// </summary>
    public partial class AzureScopeConfiguration
    {
        private ScopeConfiguration _containerImageScanning;
        private ScopeConfiguration _serverlessScanning;
        private ScopeConfiguration _vmScanning;

        /// <summary>
        /// Gets and sets the property ContainerImageScanning. 
        /// <para>
        /// The scope configuration for container image scanning.
        /// </para>
        /// </summary>
        public ScopeConfiguration ContainerImageScanning
        {
            get { return this._containerImageScanning; }
            set { this._containerImageScanning = value; }
        }

        // Check to see if ContainerImageScanning property is set
        internal bool IsSetContainerImageScanning()
        {
            return this._containerImageScanning != null;
        }

        /// <summary>
        /// Gets and sets the property ServerlessScanning. 
        /// <para>
        /// The scope configuration for serverless scanning.
        /// </para>
        /// </summary>
        public ScopeConfiguration ServerlessScanning
        {
            get { return this._serverlessScanning; }
            set { this._serverlessScanning = value; }
        }

        // Check to see if ServerlessScanning property is set
        internal bool IsSetServerlessScanning()
        {
            return this._serverlessScanning != null;
        }

        /// <summary>
        /// Gets and sets the property VmScanning. 
        /// <para>
        /// The scope configuration for VM scanning.
        /// </para>
        /// </summary>
        public ScopeConfiguration VmScanning
        {
            get { return this._vmScanning; }
            set { this._vmScanning = value; }
        }

        // Check to see if VmScanning property is set
        internal bool IsSetVmScanning()
        {
            return this._vmScanning != null;
        }

    }
}