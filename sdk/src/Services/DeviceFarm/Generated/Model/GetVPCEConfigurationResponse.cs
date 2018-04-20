/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// This is the response object from the GetVPCEConfiguration operation.
    /// </summary>
    public partial class GetVPCEConfigurationResponse : AmazonWebServiceResponse
    {
        private VPCEConfiguration _vpceConfiguration;

        /// <summary>
        /// Gets and sets the property VpceConfiguration. 
        /// <para>
        /// An object containing information about your VPC endpoint configuration.
        /// </para>
        /// </summary>
        public VPCEConfiguration VpceConfiguration
        {
            get { return this._vpceConfiguration; }
            set { this._vpceConfiguration = value; }
        }

        // Check to see if VpceConfiguration property is set
        internal bool IsSetVpceConfiguration()
        {
            return this._vpceConfiguration != null;
        }

    }
}