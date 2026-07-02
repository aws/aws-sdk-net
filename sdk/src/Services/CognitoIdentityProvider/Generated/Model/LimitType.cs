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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
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
        private int? _freeLimitValue;
        private LimitDefinitionType _limitDefinition;
        private int? _provisionedLimitValue;

        /// <summary>
        /// Gets and sets the property FreeLimitValue. 
        /// <para>
        /// The default (free) limit value, in requests per second (RPS). This is the rate included
        /// at no additional cost.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? FreeLimitValue
        {
            get { return this._freeLimitValue; }
            set { this._freeLimitValue = value; }
        }

        // Check to see if FreeLimitValue property is set
        internal bool IsSetFreeLimitValue()
        {
            return this._freeLimitValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LimitDefinition. 
        /// <para>
        /// The definition that identifies this limit, including the class and attributes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LimitDefinitionType LimitDefinition
        {
            get { return this._limitDefinition; }
            set { this._limitDefinition = value; }
        }

        // Check to see if LimitDefinition property is set
        internal bool IsSetLimitDefinition()
        {
            return this._limitDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisionedLimitValue. 
        /// <para>
        /// The provisioned limit value, in requests per second (RPS). This is the rate that Amazon
        /// Cognito currently enforces for your account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? ProvisionedLimitValue
        {
            get { return this._provisionedLimitValue; }
            set { this._provisionedLimitValue = value; }
        }

        // Check to see if ProvisionedLimitValue property is set
        internal bool IsSetProvisionedLimitValue()
        {
            return this._provisionedLimitValue.HasValue; 
        }

    }
}