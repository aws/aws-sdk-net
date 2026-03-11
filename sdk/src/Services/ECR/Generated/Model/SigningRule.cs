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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
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
namespace Amazon.ECR.Model
{
    /// <summary>
    /// A signing rule that specifies a signing profile and optional repository filters. When
    /// an image is pushed to a matching repository, a signing job is created using the specified
    /// profile.
    /// </summary>
    public partial class SigningRule
    {
        private List<SigningRepositoryFilter> _repositoryFilters = AWSConfigs.InitializeCollections ? new List<SigningRepositoryFilter>() : null;
        private string _signingProfileArn;

        /// <summary>
        /// Gets and sets the property RepositoryFilters. 
        /// <para>
        /// A list of repository filters that determine which repositories have their images signed
        /// on push. If no filters are specified, all images pushed to the registry are signed
        /// using the rule's signing profile. Maximum of 100 filters per rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<SigningRepositoryFilter> RepositoryFilters
        {
            get { return this._repositoryFilters; }
            set { this._repositoryFilters = value; }
        }

        // Check to see if RepositoryFilters property is set
        internal bool IsSetRepositoryFilters()
        {
            return this._repositoryFilters != null && (this._repositoryFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SigningProfileArn. 
        /// <para>
        /// The ARN of the Amazon Web Services Signer signing profile to use for signing images
        /// that match this rule. For more information about signing profiles, see <a href="https://docs.aws.amazon.com/signer/latest/developerguide/signing-profiles.html">Signing
        /// profiles</a> in the <i>Amazon Web Services Signer Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=200)]
        public string SigningProfileArn
        {
            get { return this._signingProfileArn; }
            set { this._signingProfileArn = value; }
        }

        // Check to see if SigningProfileArn property is set
        internal bool IsSetSigningProfileArn()
        {
            return this._signingProfileArn != null;
        }

    }
}