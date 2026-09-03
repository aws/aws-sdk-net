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
    /// The instance type specification for an AMI, which contains lists of supported and
    /// unsupported instance types that define which instance types are compatible with the
    /// AMI.
    /// </summary>
    public partial class InstanceTypeSpecificationRequest
    {
        private List<string> _supportedInstanceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _unsupportedInstanceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property SupportedInstanceTypes. 
        /// <para>
        /// The instance types that the AMI supports. You can specify instance type names or use
        /// wildcard patterns (for example, <c>t3.*</c>).
        /// </para>
        ///  
        /// <para>
        /// Constraints: Maximum 100 entries. Each entry must be 1-24 characters and match the
        /// pattern <c>^[A-Za-z0-9_.*-]+$</c>. Consecutive wildcard characters (<c>**</c>) are
        /// not allowed. Entries must be unique within each list and across both lists; duplicate
        /// entries cause the request to fail.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> SupportedInstanceTypes
        {
            get { return this._supportedInstanceTypes; }
            set { this._supportedInstanceTypes = value; }
        }

        // Check to see if SupportedInstanceTypes property is set
        internal bool IsSetSupportedInstanceTypes()
        {
            return this._supportedInstanceTypes != null && (this._supportedInstanceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UnsupportedInstanceTypes. 
        /// <para>
        /// The instance types that the AMI does not support. You can specify instance type names
        /// or use wildcard patterns (for example, <c>t3.*</c>).
        /// </para>
        ///  
        /// <para>
        /// Constraints: Maximum 100 entries. Each entry must be 1-24 characters and match the
        /// pattern <c>^[A-Za-z0-9_.*-]+$</c>. Consecutive wildcard characters (<c>**</c>) are
        /// not allowed. Entries must be unique within each list and across both lists; duplicate
        /// entries cause the request to fail.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> UnsupportedInstanceTypes
        {
            get { return this._unsupportedInstanceTypes; }
            set { this._unsupportedInstanceTypes = value; }
        }

        // Check to see if UnsupportedInstanceTypes property is set
        internal bool IsSetUnsupportedInstanceTypes()
        {
            return this._unsupportedInstanceTypes != null && (this._unsupportedInstanceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}