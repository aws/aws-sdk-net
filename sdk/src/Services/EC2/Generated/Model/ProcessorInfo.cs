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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the processor used by the instance type.
    /// </summary>
    public partial class ProcessorInfo
    {
        private string _manufacturer;
        private List<string> _supportedArchitectures = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _supportedFeatures = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private double? _sustainedClockSpeedInGhz;

        /// <summary>
        /// Gets and sets the property Manufacturer. 
        /// <para>
        /// The manufacturer of the processor.
        /// </para>
        /// </summary>
        public string Manufacturer
        {
            get { return this._manufacturer; }
            set { this._manufacturer = value; }
        }

        // Check to see if Manufacturer property is set
        internal bool IsSetManufacturer()
        {
            return this._manufacturer != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedArchitectures. 
        /// <para>
        /// The architectures supported by the instance type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedArchitectures
        {
            get { return this._supportedArchitectures; }
            set { this._supportedArchitectures = value; }
        }

        // Check to see if SupportedArchitectures property is set
        internal bool IsSetSupportedArchitectures()
        {
            return this._supportedArchitectures != null && (this._supportedArchitectures.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportedFeatures. 
        /// <para>
        /// Indicates whether the instance type supports AMD SEV-SNP. If the request returns <c>amd-sev-snp</c>,
        /// AMD SEV-SNP is supported. Otherwise, it is not supported. For more information, see
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/sev-snp.html"> AMD SEV-SNP</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedFeatures
        {
            get { return this._supportedFeatures; }
            set { this._supportedFeatures = value; }
        }

        // Check to see if SupportedFeatures property is set
        internal bool IsSetSupportedFeatures()
        {
            return this._supportedFeatures != null && (this._supportedFeatures.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SustainedClockSpeedInGhz. 
        /// <para>
        /// The speed of the processor, in GHz.
        /// </para>
        /// </summary>
        public double? SustainedClockSpeedInGhz
        {
            get { return this._sustainedClockSpeedInGhz; }
            set { this._sustainedClockSpeedInGhz = value; }
        }

        // Check to see if SustainedClockSpeedInGhz property is set
        internal bool IsSetSustainedClockSpeedInGhz()
        {
            return this._sustainedClockSpeedInGhz.HasValue; 
        }

    }
}