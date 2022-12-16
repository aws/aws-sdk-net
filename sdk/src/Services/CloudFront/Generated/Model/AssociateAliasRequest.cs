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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateAlias operation.
    /// Associates an alias (also known as a CNAME or an alternate domain name) with a CloudFront
    /// distribution.
    /// 
    ///  
    /// <para>
    /// With this operation you can move an alias that's already in use on a CloudFront distribution
    /// to a different distribution in one step. This prevents the downtime that could occur
    /// if you first remove the alias from one distribution and then separately add the alias
    /// to another distribution.
    /// </para>
    ///  
    /// <para>
    /// To use this operation to associate an alias with a distribution, you provide the alias
    /// and the ID of the target distribution for the alias. For more information, including
    /// how to set up the target distribution, prerequisites that you must complete, and other
    /// restrictions, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/CNAMEs.html#alternate-domain-names-move">Moving
    /// an alternate domain name to a different distribution</a> in the <i>Amazon CloudFront
    /// Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class AssociateAliasRequest : AmazonCloudFrontRequest
    {
        private string _alias;
        private string _targetDistributionId;

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// The alias (also known as a CNAME) to add to the target distribution.
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
        /// The ID of the distribution that you're associating the alias with.
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