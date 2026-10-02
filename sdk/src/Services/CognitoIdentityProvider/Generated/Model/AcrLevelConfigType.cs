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
    /// The configuration for a single authentication context class reference (ACR) level
    /// in a user pool. Each entry in an <c>AcrConfiguration</c> map associates a level (<c>Level1</c>
    /// through <c>Level4</c>) with this configuration, which provides the custom name that
    /// Amazon Cognito reports for that level in the <c>acr</c> token claim.
    /// </summary>
    public partial class AcrLevelConfigType
    {
        private string _acrValue;

        /// <summary>
        /// Gets and sets the property AcrValue. 
        /// <para>
        /// The custom name for this authentication context class reference (ACR) level. This
        /// value is the URI that Amazon Cognito reports in the <c>acr</c> token claim when a
        /// user meets this level. The name must be unique across all levels in the user pool,
        /// including default names.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string AcrValue
        {
            get { return this._acrValue; }
            set { this._acrValue = value; }
        }

        // Check to see if AcrValue property is set
        internal bool IsSetAcrValue()
        {
            return this._acrValue != null;
        }

    }
}