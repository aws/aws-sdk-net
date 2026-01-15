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
 * Do not modify this file. This file is generated from the evs-2023-07-27.normal.json service model.
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
namespace Amazon.Evs.Model
{
    /// <summary>
    /// Information about a VCF versions provided by Amazon EVS, including its status, default
    /// ESX version, and EC2 instance types.
    /// </summary>
    public partial class VcfVersionInfo
    {
        private string _defaultEsxVersion;
        private List<string> _instanceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _status;
        private VcfVersion _vcfVersion;

        /// <summary>
        /// Gets and sets the property DefaultEsxVersion. 
        /// <para>
        /// The default ESX version for this VCF version. It is based on Broadcom's Bill Of Materials
        /// (BOM).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DefaultEsxVersion
        {
            get { return this._defaultEsxVersion; }
            set { this._defaultEsxVersion = value; }
        }

        // Check to see if DefaultEsxVersion property is set
        internal bool IsSetDefaultEsxVersion()
        {
            return this._defaultEsxVersion != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceTypes. 
        /// <para>
        /// EC2 instance types provided by Amazon EVS for this VCF version for creating environments.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> InstanceTypes
        {
            get { return this._instanceTypes; }
            set { this._instanceTypes = value; }
        }

        // Check to see if InstanceTypes property is set
        internal bool IsSetInstanceTypes()
        {
            return this._instanceTypes != null && (this._instanceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status for this VCF version. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AVAILABLE</c> - This VCF version is available to you.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RESTRICTED</c> - This VCF version has limited availability.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        ///  If the version you need shows RESTRICTED, and you require, check out <a href="https://docs.aws.amazon.com/evs/latest/userguide/versions-provided.html">VCF
        /// versions and EC2 instance types provided by Amazon EVS</a> for more information. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property VcfVersion. 
        /// <para>
        /// The VCF version number.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VcfVersion VcfVersion
        {
            get { return this._vcfVersion; }
            set { this._vcfVersion = value; }
        }

        // Check to see if VcfVersion property is set
        internal bool IsSetVcfVersion()
        {
            return this._vcfVersion != null;
        }

    }
}