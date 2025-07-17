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
    /// Container for the parameters to the AssociateAlias operation.
    /// <note> 
    /// <para>
    /// The <c>AssociateAlias</c> API operation only supports standard distributions. To move
    /// domains between distribution tenants and/or standard distributions, we recommend that
    /// you use the <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_UpdateDomainAssociation.html">UpdateDomainAssociation</a>
    /// API operation instead.
    /// 
    ///  </note> 
    /// <para>
    /// Associates an alias with a CloudFront standard distribution. An alias is commonly
    /// known as a custom domain or vanity domain. It can also be called a CNAME or alternate
    /// domain name.
    /// </para>
    ///  
    /// <para>
    /// With this operation, you can move an alias that's already used for a standard distribution
    /// to a different standard distribution. This prevents the downtime that could occur
    /// if you first remove the alias from one standard distribution and then separately add
    /// the alias to another standard distribution.
    /// </para>
    ///  
    /// <para>
    /// To use this operation, specify the alias and the ID of the target standard distribution.
    /// </para>
    ///  
    /// <para>
    /// For more information, including how to set up the target standard distribution, prerequisites
    /// that you must complete, and other restrictions, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/CNAMEs.html#alternate-domain-names-move">Moving
    /// an alternate domain name to a different standard distribution or distribution tenant</a>
    /// in the <i>Amazon CloudFront Developer Guide</i>.
    /// </para>
    /// 
    /// </para>
    /// </summary>
    public partial class AssociateAliasRequest : AmazonCloudFrontRequest
    {
        private string _alias;
        private string _targetDistributionId;

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// The alias (also known as a CNAME) to add to the target standard distribution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Alias
        {
            get { return this._alias; }
            set { this._alias = value; }
        }

        // Check to see if Alias property is set
        internal bool IsSetAlias()
        {
            return this._alias != null;
        }

        /// <summary>
        /// Gets and sets the property TargetDistributionId. 
        /// <para>
        /// The ID of the standard distribution that you're associating the alias with.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TargetDistributionId
        {
            get { return this._targetDistributionId; }
            set { this._targetDistributionId = value; }
        }

        // Check to see if TargetDistributionId property is set
        internal bool IsSetTargetDistributionId()
        {
            return this._targetDistributionId != null;
        }

    }
}