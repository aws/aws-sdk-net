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

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// The limit definition and current limit values for a provisioned limit.
    /// </summary>
    public partial class LimitType
    {
        /// <summary>
        /// Gets and sets the property FreeLimitValue. 
        /// <para>
        /// The default (free) limit value, in requests per second (RPS). This is the rate included
        /// at no additional cost.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? FreeLimitValue { get; set; }

        /// <summary>
        /// Checks to see if the FreeLimitValue property is set.
        /// </summary>
        internal bool IsSetFreeLimitValue() => this.FreeLimitValue.HasValue;

        /// <summary>
        /// Gets and sets the property LimitDefinition. 
        /// <para>
        /// The definition that identifies this limit, including the class and attributes.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LimitDefinitionType LimitDefinition { get; set; }

        /// <summary>
        /// Checks to see if the LimitDefinition property is set.
        /// </summary>
        internal bool IsSetLimitDefinition() => this.LimitDefinition != null;

        /// <summary>
        /// Gets and sets the property ProvisionedLimitValue. 
        /// <para>
        /// The provisioned limit value, in requests per second (RPS). This is the rate that Amazon
        /// Cognito currently enforces for your account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? ProvisionedLimitValue { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedLimitValue property is set.
        /// </summary>
        internal bool IsSetProvisionedLimitValue() => this.ProvisionedLimitValue.HasValue;
    }
}
