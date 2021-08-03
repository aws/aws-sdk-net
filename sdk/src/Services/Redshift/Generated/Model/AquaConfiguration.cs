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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// The AQUA (Advanced Query Accelerator) configuration of the cluster.
    /// </summary>
    public partial class AquaConfiguration
    {
        private AquaConfigurationStatus _aquaConfigurationStatus;
        private AquaStatus _aquaStatus;

        /// <summary>
        /// Gets and sets the property AquaConfigurationStatus. 
        /// <para>
        /// The value represents how the cluster is configured to use AQUA. Possible values include
        /// the following.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// enabled - Use AQUA if it is available for the current Amazon Web Services Region and
        /// Amazon Redshift node type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// disabled - Don't use AQUA. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// auto - Amazon Redshift determines whether to use AQUA.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AquaConfigurationStatus AquaConfigurationStatus
        {
            get { return this._aquaConfigurationStatus; }
            set { this._aquaConfigurationStatus = value; }
        }

        // Check to see if AquaConfigurationStatus property is set
        internal bool IsSetAquaConfigurationStatus()
        {
            return this._aquaConfigurationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property AquaStatus. 
        /// <para>
        /// The value indicates the status of AQUA on the cluster. Possible values include the
        /// following.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// enabled - AQUA is enabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// disabled - AQUA is not enabled. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// applying - AQUA status is being applied. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AquaStatus AquaStatus
        {
            get { return this._aquaStatus; }
            set { this._aquaStatus = value; }
        }

        // Check to see if AquaStatus property is set
        internal bool IsSetAquaStatus()
        {
            return this._aquaStatus != null;
        }

    }
}