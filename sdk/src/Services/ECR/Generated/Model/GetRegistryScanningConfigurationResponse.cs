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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
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
namespace Amazon.ECR.Model
{
    /// <summary>
    /// This is the response object from the GetRegistryScanningConfiguration operation.
    /// </summary>
    public partial class GetRegistryScanningConfigurationResponse : AmazonWebServiceResponse
    {
        private string _registryId;
        private RegistryScanningConfiguration _scanningConfiguration;

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The registry ID associated with the request.
        /// </para>
        /// </summary>
        public string RegistryId
        {
            get { return this._registryId; }
            set { this._registryId = value; }
        }

        // Check to see if RegistryId property is set
        internal bool IsSetRegistryId()
        {
            return this._registryId != null;
        }

        /// <summary>
        /// Gets and sets the property ScanningConfiguration. 
        /// <para>
        /// The scanning configuration for the registry.
        /// </para>
        /// </summary>
        public RegistryScanningConfiguration ScanningConfiguration
        {
            get { return this._scanningConfiguration; }
            set { this._scanningConfiguration = value; }
        }

        // Check to see if ScanningConfiguration property is set
        internal bool IsSetScanningConfiguration()
        {
            return this._scanningConfiguration != null;
        }

    }
}