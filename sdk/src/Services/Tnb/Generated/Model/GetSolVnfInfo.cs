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
 * Do not modify this file. This file is generated from the tnb-2008-10-21.normal.json service model.
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
namespace Amazon.Tnb.Model
{
    /// <summary>
    /// Information about the network function.
    /// 
    ///  
    /// <para>
    /// A network function instance is a function in a function package .
    /// </para>
    /// </summary>
    public partial class GetSolVnfInfo
    {
        private List<GetSolVnfcResourceInfo> _vnfcResourceInfo = AWSConfigs.InitializeCollections ? new List<GetSolVnfcResourceInfo>() : null;
        private VnfOperationalState _vnfState;

        /// <summary>
        /// Gets and sets the property VnfcResourceInfo. 
        /// <para>
        /// Compute info used by the network function instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GetSolVnfcResourceInfo> VnfcResourceInfo
        {
            get { return this._vnfcResourceInfo; }
            set { this._vnfcResourceInfo = value; }
        }

        // Check to see if VnfcResourceInfo property is set
        internal bool IsSetVnfcResourceInfo()
        {
            return this._vnfcResourceInfo != null && (this._vnfcResourceInfo.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VnfState. 
        /// <para>
        /// State of the network function instance.
        /// </para>
        /// </summary>
        public VnfOperationalState VnfState
        {
            get { return this._vnfState; }
            set { this._vnfState = value; }
        }

        // Check to see if VnfState property is set
        internal bool IsSetVnfState()
        {
            return this._vnfState != null;
        }

    }
}