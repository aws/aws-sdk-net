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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDatalake operation.
    /// Specifies where to store your security data and for how long. You can add a rollup
    /// Region to consolidate data from multiple Amazon Web Services Regions.
    /// </summary>
    public partial class UpdateDatalakeRequest : AmazonSecurityLakeRequest
    {
        private Dictionary<string, LakeConfigurationRequest> _configurations = new Dictionary<string, LakeConfigurationRequest>();

        /// <summary>
        /// Gets and sets the property Configurations. 
        /// <para>
        /// Specify the Region or Regions that will contribute data to the rollup region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, LakeConfigurationRequest> Configurations
        {
            get { return this._configurations; }
            set { this._configurations = value; }
        }

        // Check to see if Configurations property is set
        internal bool IsSetConfigurations()
        {
            return this._configurations != null && this._configurations.Count > 0; 
        }

    }
}