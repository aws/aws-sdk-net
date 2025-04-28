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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDomainAssociation operation.
    /// Moves a domain from its current distribution or distribution tenant to another one.
    /// </summary>
    public partial class UpdateDomainAssociationRequest : AmazonCloudFrontRequest
    {
        private string _domain;
        private string _ifMatch;
        private DistributionResourceId _targetResource;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The domain to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property IfMatch. 
        /// <para>
        /// The value of the <c>ETag</c> identifier for the distribution or distribution tenant
        /// that will be associated with the domain.
        /// </para>
        /// </summary>
        public string IfMatch
        {
            get { return this._ifMatch; }
            set { this._ifMatch = value; }
        }

        // Check to see if IfMatch property is set
        internal bool IsSetIfMatch()
        {
            return this._ifMatch != null;
        }

        /// <summary>
        /// Gets and sets the property TargetResource. 
        /// <para>
        /// The target distribution resource for the domain. You can specify either <c>DistributionId</c>
        /// or <c>DistributionTenantId</c>, but not both.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DistributionResourceId TargetResource
        {
            get { return this._targetResource; }
            set { this._targetResource = value; }
        }

        // Check to see if TargetResource property is set
        internal bool IsSetTargetResource()
        {
            return this._targetResource != null;
        }

    }
}