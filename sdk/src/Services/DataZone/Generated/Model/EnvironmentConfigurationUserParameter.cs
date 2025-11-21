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
        private string _environmentId;
        private List<EnvironmentParameter> _environmentParameters = AWSConfigs.InitializeCollections ? new List<EnvironmentParameter>() : null;
        private EnvironmentResolvedAccount _environmentResolvedAccount;

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
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The ID of the environment.
        /// </para>
        /// </summary>
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentParameters. 
        /// <para>
        /// The environment parameters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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

        /// <summary>
        /// Gets and sets the property EnvironmentResolvedAccount. 
        /// <para>
        /// Specifies the account/Region that is to be used during project creation for a particular
        /// blueprint.
        /// </para>
        /// </summary>
        public EnvironmentResolvedAccount EnvironmentResolvedAccount
        {
            get { return this._environmentResolvedAccount; }
            set { this._environmentResolvedAccount = value; }
        }

        // Check to see if EnvironmentResolvedAccount property is set
        internal bool IsSetEnvironmentResolvedAccount()
        {
            return this._environmentResolvedAccount != null;
        }

    }
}