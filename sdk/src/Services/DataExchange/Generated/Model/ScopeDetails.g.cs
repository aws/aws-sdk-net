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

namespace Amazon.DataExchange.Model
{
    /// <summary>
    /// Details about the scope of the notifications such as the affected resources.
    /// </summary>
    public partial class ScopeDetails
    {
        /// <summary>
        /// Gets and sets the property LakeFormationTagPolicies. 
        /// <para>
        /// Underlying LF resources that will be affected by this notification.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LakeFormationTagPolicyDetails> LakeFormationTagPolicies { get; set; } = AWSConfigs.InitializeCollections ? new List<LakeFormationTagPolicyDetails>() : null;

        /// <summary>
        /// Checks to see if the LakeFormationTagPolicies property is set.
        /// </summary>
        internal bool IsSetLakeFormationTagPolicies() => this.LakeFormationTagPolicies != null && (this.LakeFormationTagPolicies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RedshiftDataShares. 
        /// <para>
        /// Underlying Redshift resources that will be affected by this notification.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RedshiftDataShareDetails> RedshiftDataShares { get; set; } = AWSConfigs.InitializeCollections ? new List<RedshiftDataShareDetails>() : null;

        /// <summary>
        /// Checks to see if the RedshiftDataShares property is set.
        /// </summary>
        internal bool IsSetRedshiftDataShares() => this.RedshiftDataShares != null && (this.RedshiftDataShares.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property S3DataAccesses. 
        /// <para>
        /// Underlying S3 resources that will be affected by this notification.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<S3DataAccessDetails> S3DataAccesses { get; set; } = AWSConfigs.InitializeCollections ? new List<S3DataAccessDetails>() : null;

        /// <summary>
        /// Checks to see if the S3DataAccesses property is set.
        /// </summary>
        internal bool IsSetS3DataAccesses() => this.S3DataAccesses != null && (this.S3DataAccesses.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
