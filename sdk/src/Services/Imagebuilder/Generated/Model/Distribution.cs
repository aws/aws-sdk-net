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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Defines the settings for a specific Region.
    /// </summary>
    public partial class Distribution
    {
        private AmiDistributionConfiguration _amiDistributionConfiguration;
        private ContainerDistributionConfiguration _containerDistributionConfiguration;
        private List<string> _licenseConfigurationArns = new List<string>();
        private string _region;

        /// <summary>
        /// Gets and sets the property AmiDistributionConfiguration. 
        /// <para>
        /// The specific AMI settings (for example, launch permissions, AMI tags). 
        /// </para>
        /// </summary>
        public AmiDistributionConfiguration AmiDistributionConfiguration
        {
            get { return this._amiDistributionConfiguration; }
            set { this._amiDistributionConfiguration = value; }
        }

        // Check to see if AmiDistributionConfiguration property is set
        internal bool IsSetAmiDistributionConfiguration()
        {
            return this._amiDistributionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerDistributionConfiguration. 
        /// <para>
        /// Container distribution settings for encryption, licensing, and sharing in a specific
        /// Region.
        /// </para>
        /// </summary>
        public ContainerDistributionConfiguration ContainerDistributionConfiguration
        {
            get { return this._containerDistributionConfiguration; }
            set { this._containerDistributionConfiguration = value; }
        }

        // Check to see if ContainerDistributionConfiguration property is set
        internal bool IsSetContainerDistributionConfiguration()
        {
            return this._containerDistributionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseConfigurationArns. 
        /// <para>
        /// The License Manager Configuration to associate with the AMI in the specified Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<string> LicenseConfigurationArns
        {
            get { return this._licenseConfigurationArns; }
            set { this._licenseConfigurationArns = value; }
        }

        // Check to see if LicenseConfigurationArns property is set
        internal bool IsSetLicenseConfigurationArns()
        {
            return this._licenseConfigurationArns != null && this._licenseConfigurationArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The target Region. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
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

    }
}