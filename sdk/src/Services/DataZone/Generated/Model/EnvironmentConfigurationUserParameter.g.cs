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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The environment configuration user parameters.
    /// </summary>
    public partial class EnvironmentConfigurationUserParameter
    {
        /// <summary>
        /// Gets and sets the property EnvironmentConfigurationName. 
        /// <para>
        /// The environment configuration name.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 64)]
        public string EnvironmentConfigurationName { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentConfigurationName property is set.
        /// </summary>
        internal bool IsSetEnvironmentConfigurationName() => this.EnvironmentConfigurationName != null;

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The ID of the environment.
        /// </para>
        /// </summary>
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentId property is set.
        /// </summary>
        internal bool IsSetEnvironmentId() => this.EnvironmentId != null;

        /// <summary>
        /// Gets and sets the property EnvironmentParameters. 
        /// <para>
        /// The environment parameters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EnvironmentParameter> EnvironmentParameters { get; set; } = AWSConfigs.InitializeCollections ? new List<EnvironmentParameter>() : null;

        /// <summary>
        /// Checks to see if the EnvironmentParameters property is set.
        /// </summary>
        internal bool IsSetEnvironmentParameters() => this.EnvironmentParameters != null && (this.EnvironmentParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EnvironmentResolvedAccount. 
        /// <para>
        /// Specifies the account/Region that is to be used during project creation for a particular
        /// blueprint.
        /// </para>
        /// </summary>
        public EnvironmentResolvedAccount EnvironmentResolvedAccount { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentResolvedAccount property is set.
        /// </summary>
        internal bool IsSetEnvironmentResolvedAccount() => this.EnvironmentResolvedAccount != null;
    }
}
