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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// A list of service integrations.
    /// </summary>
    public partial class ServiceIntegrationsUnion
    {
        /// <summary>
        /// Gets and sets the property LakeFormation. 
        /// <para>
        /// A list of scopes set up for Lake Formation integration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LakeFormationScopeUnion> LakeFormation { get; set; } = AWSConfigs.InitializeCollections ? new List<LakeFormationScopeUnion>() : null;

        /// <summary>
        /// Checks to see if the LakeFormation property is set.
        /// </summary>
        internal bool IsSetLakeFormation() => this.LakeFormation != null && (this.LakeFormation.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Redshift. 
        /// <para>
        /// A list of scopes set up for Amazon Redshift integration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RedshiftScopeUnion> Redshift { get; set; } = AWSConfigs.InitializeCollections ? new List<RedshiftScopeUnion>() : null;

        /// <summary>
        /// Checks to see if the Redshift property is set.
        /// </summary>
        internal bool IsSetRedshift() => this.Redshift != null && (this.Redshift.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property S3AccessGrants. 
        /// <para>
        /// A list of scopes set up for S3 Access Grants integration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<S3AccessGrantsScopeUnion> S3AccessGrants { get; set; } = AWSConfigs.InitializeCollections ? new List<S3AccessGrantsScopeUnion>() : null;

        /// <summary>
        /// Checks to see if the S3AccessGrants property is set.
        /// </summary>
        internal bool IsSetS3AccessGrants() => this.S3AccessGrants != null && (this.S3AccessGrants.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
