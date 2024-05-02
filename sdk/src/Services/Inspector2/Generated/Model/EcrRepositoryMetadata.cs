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
    /// Information on the Amazon ECR repository metadata associated with a finding.
    /// </summary>
    public partial class EcrRepositoryMetadata
    {
        private string _name;
        private EcrScanFrequency _scanFrequency;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Amazon ECR repository.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ScanFrequency. 
        /// <para>
        /// The frequency of scans.
        /// </para>
        /// </summary>
        public EcrScanFrequency ScanFrequency
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