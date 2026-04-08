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
 * Do not modify this file. This file is generated from the marketplace-discovery-2026-02-05.normal.json service model.
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
namespace Amazon.MarketplaceDiscovery.Model
{
    /// <summary>
    /// Describes an operating system supported by an AMI fulfillment option.
    /// </summary>
    public partial class AmazonMachineImageOperatingSystem
    {
        private string _operatingSystemFamilyName;
        private string _operatingSystemName;
        private string _operatingSystemVersion;

        /// <summary>
        /// Gets and sets the property OperatingSystemFamilyName. 
        /// <para>
        /// The operating system family, such as Linux or Windows.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OperatingSystemFamilyName
        {
            get { return this._operatingSystemFamilyName; }
            set { this._operatingSystemFamilyName = value; }
        }

        // Check to see if OperatingSystemFamilyName property is set
        internal bool IsSetOperatingSystemFamilyName()
        {
            return this._operatingSystemFamilyName != null;
        }

        /// <summary>
        /// Gets and sets the property OperatingSystemName. 
        /// <para>
        /// The specific operating system name, such as Amazon Linux 2 or Windows Server 2022.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OperatingSystemName
        {
            get { return this._operatingSystemName; }
            set { this._operatingSystemName = value; }
        }

        // Check to see if OperatingSystemName property is set
        internal bool IsSetOperatingSystemName()
        {
            return this._operatingSystemName != null;
        }

        /// <summary>
        /// Gets and sets the property OperatingSystemVersion. 
        /// <para>
        /// The version of the operating system.
        /// </para>
        /// </summary>
        public string OperatingSystemVersion
        {
            get { return this._operatingSystemVersion; }
            set { this._operatingSystemVersion = value; }
        }

        // Check to see if OperatingSystemVersion property is set
        internal bool IsSetOperatingSystemVersion()
        {
            return this._operatingSystemVersion != null;
        }

    }
}