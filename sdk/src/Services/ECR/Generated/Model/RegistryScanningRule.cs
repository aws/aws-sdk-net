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
    /// The details of a scanning rule for a private registry.
    /// </summary>
    public partial class RegistryScanningRule
    {
        private List<ScanningRepositoryFilter> _repositoryFilters = new List<ScanningRepositoryFilter>();
        private ScanFrequency _scanFrequency;

        /// <summary>
        /// Gets and sets the property RepositoryFilters. 
        /// <para>
        /// The repository filters associated with the scanning configuration for a private registry.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<ScanningRepositoryFilter> RepositoryFilters
        {
            get { return this._repositoryFilters; }
            set { this._repositoryFilters = value; }
        }

        // Check to see if RepositoryFilters property is set
        internal bool IsSetRepositoryFilters()
        {
            return this._repositoryFilters != null && this._repositoryFilters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ScanFrequency. 
        /// <para>
        /// The frequency that scans are performed at for a private registry. When the <code>ENHANCED</code>
        /// scan type is specified, the supported scan frequencies are <code>CONTINUOUS_SCAN</code>
        /// and <code>SCAN_ON_PUSH</code>. When the <code>BASIC</code> scan type is specified,
        /// the <code>SCAN_ON_PUSH</code> and <code>MANUAL</code> scan frequencies are supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ScanFrequency ScanFrequency
        {
            get { return this._scanFrequency; }
            set { this._scanFrequency = value; }
        }

        // Check to see if ScanFrequency property is set
        internal bool IsSetScanFrequency()
        {
            return this._scanFrequency != null;
        }

    }
}