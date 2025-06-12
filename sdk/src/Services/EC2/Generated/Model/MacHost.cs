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
    /// Information about the EC2 Mac Dedicated Host.
    /// </summary>
    public partial class MacHost
    {
        private string _hostId;
        private List<string> _macOSLatestSupportedVersions = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property HostId. 
        /// <para>
        ///  The EC2 Mac Dedicated Host ID. 
        /// </para>
        /// </summary>
        public string HostId
        {
            get { return this._hostId; }
            set { this._hostId = value; }
        }

        // Check to see if HostId property is set
        internal bool IsSetHostId()
        {
            return this._hostId != null;
        }

        /// <summary>
        /// Gets and sets the property MacOSLatestSupportedVersions. 
        /// <para>
        ///  The latest macOS versions that the EC2 Mac Dedicated Host can launch without being
        /// upgraded. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> MacOSLatestSupportedVersions
        {
            get { return this._macOSLatestSupportedVersions; }
            set { this._macOSLatestSupportedVersions = value; }
        }

        // Check to see if MacOSLatestSupportedVersions property is set
        internal bool IsSetMacOSLatestSupportedVersions()
        {
            return this._macOSLatestSupportedVersions != null && (this._macOSLatestSupportedVersions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}