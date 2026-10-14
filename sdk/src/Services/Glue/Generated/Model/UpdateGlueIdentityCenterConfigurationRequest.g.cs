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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateGlueIdentityCenterConfiguration operation.
    /// Updates the existing Glue Identity Center configuration, allowing modification of
    /// scopes and permissions for the integration.
    /// </summary>
    public partial class UpdateGlueIdentityCenterConfigurationRequest : AmazonGlueRequest
    {
        /// <summary>
        /// Gets and sets the property Scopes. 
        /// <para>
        /// A list of Identity Center scopes that define the updated permissions and access levels
        /// for the Glue configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<string> Scopes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Scopes property is set.
        /// </summary>
        internal bool IsSetScopes() => this.Scopes != null && (this.Scopes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UserBackgroundSessionsEnabled. 
        /// <para>
        /// Specifies whether users can run background sessions when using Identity Center authentication
        /// with Glue services.
        /// </para>
        /// </summary>
        public bool? UserBackgroundSessionsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the UserBackgroundSessionsEnabled property is set.
        /// </summary>
        internal bool IsSetUserBackgroundSessionsEnabled() => this.UserBackgroundSessionsEnabled.HasValue;
    }
}
