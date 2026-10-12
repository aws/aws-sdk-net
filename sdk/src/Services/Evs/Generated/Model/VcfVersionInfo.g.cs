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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property DefaultEsxVersion. 
        /// <para>
        /// The default ESX version for this VCF version. It is based on Broadcom's Bill Of Materials
        /// (BOM).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DefaultEsxVersion { get; set; }

        /// <summary>
        /// Checks to see if the DefaultEsxVersion property is set.
        /// </summary>
        internal bool IsSetDefaultEsxVersion() => this.DefaultEsxVersion != null;

        /// <summary>
        /// Gets and sets the property InstanceTypes. 
        /// <para>
        /// EC2 instance types provided by Amazon EVS for this VCF version for creating environments.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> InstanceTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InstanceTypes property is set.
        /// </summary>
        internal bool IsSetInstanceTypes() => this.InstanceTypes != null && (this.InstanceTypes.Count > 0 || !AWSConfigs.InitializeCollections);

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
        [AWSProperty(Required = true)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property VcfVersion. 
        /// <para>
        /// The VCF version number.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public VcfVersion VcfVersion { get; set; }

        /// <summary>
        /// Checks to see if the VcfVersion property is set.
        /// </summary>
        internal bool IsSetVcfVersion() => this.VcfVersion != null;
    }
}
