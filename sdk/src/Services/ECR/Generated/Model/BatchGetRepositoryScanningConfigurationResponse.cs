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

namespace Amazon.ECR.Model
{
    /// <summary>
    /// This is the response object from the BatchGetRepositoryScanningConfiguration operation.
    /// </summary>
    public partial class BatchGetRepositoryScanningConfigurationResponse : AmazonWebServiceResponse
    {
        private List<RepositoryScanningConfigurationFailure> _failures = new List<RepositoryScanningConfigurationFailure>();
        private List<RepositoryScanningConfiguration> _scanningConfigurations = new List<RepositoryScanningConfiguration>();

        /// <summary>
        /// Gets and sets the property Failures. 
        /// <para>
        /// Any failures associated with the call.
        /// </para>
        /// </summary>
        public List<RepositoryScanningConfigurationFailure> Failures
        {
            get { return this._failures; }
            set { this._failures = value; }
        }

        // Check to see if Failures property is set
        internal bool IsSetFailures()
        {
            return this._failures != null && this._failures.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ScanningConfigurations. 
        /// <para>
        /// The scanning configuration for the requested repositories.
        /// </para>
        /// </summary>
        public List<RepositoryScanningConfiguration> ScanningConfigurations
        {
            get { return this._scanningConfigurations; }
            set { this._scanningConfigurations = value; }
        }

        // Check to see if ScanningConfigurations property is set
        internal bool IsSetScanningConfigurations()
        {
            return this._scanningConfigurations != null && this._scanningConfigurations.Count > 0; 
        }

    }
}