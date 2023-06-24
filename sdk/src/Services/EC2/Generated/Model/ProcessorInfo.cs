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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the processor used by the instance type.
    /// </summary>
    public partial class ProcessorInfo
    {
        private List<string> _supportedArchitectures = new List<string>();
        private List<string> _supportedFeatures = new List<string>();
        private double? _sustainedClockSpeedInGhz;

        /// <summary>
        /// Gets and sets the property SupportedArchitectures. 
        /// <para>
        /// The architectures supported by the instance type.
        /// </para>
        /// </summary>
        public List<string> SupportedArchitectures
        {
            get { return this._supportedArchitectures; }
            set { this._supportedArchitectures = value; }
        }

        // Check to see if SupportedArchitectures property is set
        internal bool IsSetSupportedArchitectures()
        {
            return this._supportedArchitectures != null && this._supportedArchitectures.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SupportedFeatures. 
        /// <para>
        /// Indicates whether the instance type supports AMD SEV-SNP. If the request returns <code>amd-sev-snp</code>,
        /// AMD SEV-SNP is supported. Otherwise, it is not supported. For more information, see
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/sev-snp.html"> AMD SEV-SNP</a>.
        /// </para>
        /// </summary>
        public List<string> SupportedFeatures
        {
            get { return this._supportedFeatures; }
            set { this._supportedFeatures = value; }
        }

        // Check to see if SupportedFeatures property is set
        internal bool IsSetSupportedFeatures()
        {
            return this._supportedFeatures != null && this._supportedFeatures.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SustainedClockSpeedInGhz. 
        /// <para>
        /// The speed of the processor, in GHz.
        /// </para>
        /// </summary>
        public double SustainedClockSpeedInGhz
        {
            get { return this._sustainedClockSpeedInGhz.GetValueOrDefault(); }
            set { this._sustainedClockSpeedInGhz = value; }
        }

        // Check to see if SustainedClockSpeedInGhz property is set
        internal bool IsSetSustainedClockSpeedInGhz()
        {
            return this._sustainedClockSpeedInGhz.HasValue; 
        }

    }
}