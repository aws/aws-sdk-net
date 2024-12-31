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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The environment configuration user parameters.
    /// </summary>
    public partial class EnvironmentConfigurationUserParameter
    {
        private string _environmentConfigurationName;
        private List<EnvironmentParameter> _environmentParameters = AWSConfigs.InitializeCollections ? new List<EnvironmentParameter>() : null;

        /// <summary>
        /// Gets and sets the property EnvironmentConfigurationName. 
        /// <para>
        /// The environment configuration name.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=64)]
        public string EnvironmentConfigurationName
        {
            get { return this._environmentConfigurationName; }
            set { this._environmentConfigurationName = value; }
        }

        // Check to see if EnvironmentConfigurationName property is set
        internal bool IsSetEnvironmentConfigurationName()
        {
            return this._environmentConfigurationName != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentParameters. 
        /// <para>
        /// The environment parameters.
        /// </para>
        /// </summary>
        public List<EnvironmentParameter> EnvironmentParameters
        {
            get { return this._environmentParameters; }
            set { this._environmentParameters = value; }
        }

        // Check to see if EnvironmentParameters property is set
        internal bool IsSetEnvironmentParameters()
        {
            return this._environmentParameters != null && (this._environmentParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}