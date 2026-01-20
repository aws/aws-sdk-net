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
 * Do not modify this file. This file is generated from the workspaces-instances-2022-07-26.normal.json service model.
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
namespace Amazon.WorkspacesInstances.Model
{
    /// <summary>
    /// Provides details about a specific WorkSpace Instance type.
    /// </summary>
    public partial class InstanceTypeInfo
    {
        private string _instanceType;
        private List<SupportedInstanceConfiguration> _supportedInstanceConfigurations = AWSConfigs.InitializeCollections ? new List<SupportedInstanceConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// Unique identifier for the WorkSpace Instance type.
        /// </para>
        /// </summary>
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedInstanceConfigurations. 
        /// <para>
        /// Lists all valid combinations of tenancy, platform type, and billing mode supported
        /// for the specific WorkSpace Instance type. Contains the complete set of configuration
        /// options available for this instance type.
        /// </para>
        /// </summary>
        public List<SupportedInstanceConfiguration> SupportedInstanceConfigurations
        {
            get { return this._supportedInstanceConfigurations; }
            set { this._supportedInstanceConfigurations = value; }
        }

        // Check to see if SupportedInstanceConfigurations property is set
        internal bool IsSetSupportedInstanceConfigurations()
        {
            return this._supportedInstanceConfigurations != null && (this._supportedInstanceConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}