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

namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// The General Authorization update information containing authorization materials to
    /// add or update.
    /// </summary>
    public partial class GeneralAuthorizationUpdate
    {
        /// <summary>
        /// Gets and sets the property AuthMaterialsToAdd. 
        /// <para>
        /// The authorization materials to add.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 3)]
        public List<AuthMaterial> AuthMaterialsToAdd { get; set; } = AWSConfigs.InitializeCollections ? new List<AuthMaterial>() : null;

        /// <summary>
        /// Checks to see if the AuthMaterialsToAdd property is set.
        /// </summary>
        internal bool IsSetAuthMaterialsToAdd() => this.AuthMaterialsToAdd != null && (this.AuthMaterialsToAdd.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AuthMaterialsToUpdate. 
        /// <para>
        /// The authorization materials to update.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 3)]
        public List<AuthMaterial> AuthMaterialsToUpdate { get; set; } = AWSConfigs.InitializeCollections ? new List<AuthMaterial>() : null;

        /// <summary>
        /// Checks to see if the AuthMaterialsToUpdate property is set.
        /// </summary>
        internal bool IsSetAuthMaterialsToUpdate() => this.AuthMaterialsToUpdate != null && (this.AuthMaterialsToUpdate.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
