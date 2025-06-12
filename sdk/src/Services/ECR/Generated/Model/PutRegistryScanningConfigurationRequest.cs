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
    /// Container for the parameters to the PutRegistryScanningConfiguration operation.
    /// Creates or updates the scanning configuration for your private registry.
    /// </summary>
    public partial class PutRegistryScanningConfigurationRequest : AmazonECRRequest
    {
        private List<RegistryScanningRule> _rules = AWSConfigs.InitializeCollections ? new List<RegistryScanningRule>() : null;
        private ScanType _scanType;

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        /// The scanning rules to use for the registry. A scanning rule is used to determine which
        /// repository filters are used and at what frequency scanning will occur.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public List<RegistryScanningRule> Rules
        {
            get { return this._rules; }
            set { this._rules = value; }
        }

        // Check to see if Rules property is set
        internal bool IsSetRules()
        {
            return this._rules != null && (this._rules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScanType. 
        /// <para>
        /// The scanning type to set for the registry.
        /// </para>
        ///  
        /// <para>
        /// When a registry scanning configuration is not defined, by default the <c>BASIC</c>
        /// scan type is used. When basic scanning is used, you may specify filters to determine
        /// which individual repositories, or all repositories, are scanned when new images are
        /// pushed to those repositories. Alternatively, you can do manual scans of images with
        /// basic scanning.
        /// </para>
        ///  
        /// <para>
        /// When the <c>ENHANCED</c> scan type is set, Amazon Inspector provides automated vulnerability
        /// scanning. You may choose between continuous scanning or scan on push and you may specify
        /// filters to determine which individual repositories, or all repositories, are scanned.
        /// </para>
        /// </summary>
        public ScanType ScanType
        {
            get { return this._scanType; }
            set { this._scanType = value; }
        }

        // Check to see if ScanType property is set
        internal bool IsSetScanType()
        {
            return this._scanType != null;
        }

    }
}