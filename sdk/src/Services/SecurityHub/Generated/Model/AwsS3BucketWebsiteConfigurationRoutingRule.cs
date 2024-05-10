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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A rule for redirecting requests to the website.
    /// </summary>
    public partial class AwsS3BucketWebsiteConfigurationRoutingRule
    {
        private AwsS3BucketWebsiteConfigurationRoutingRuleCondition _condition;
        private AwsS3BucketWebsiteConfigurationRoutingRuleRedirect _redirect;

        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// Provides the condition that must be met in order to apply the routing rule.
        /// </para>
        /// </summary>
        public AwsS3BucketWebsiteConfigurationRoutingRuleCondition Condition
        {
            get { return this._condition; }
            set { this._condition = value; }
        }

        // Check to see if Condition property is set
        internal bool IsSetCondition()
        {
            return this._condition != null;
        }

        /// <summary>
        /// Gets and sets the property Redirect. 
        /// <para>
        /// Provides the rules to redirect the request if the condition in <c>Condition</c> is
        /// met.
        /// </para>
        /// </summary>
        public AwsS3BucketWebsiteConfigurationRoutingRuleRedirect Redirect
        {
            get { return this._redirect; }
            set { this._redirect = value; }
        }

        // Check to see if Redirect property is set
        internal bool IsSetRedirect()
        {
            return this._redirect != null;
        }

    }
}