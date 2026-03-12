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
    /// The name and value of a user attribute.
    /// </summary>
    public partial class AttributeType
    {
        private string _name;
        private string _value;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the attribute, for example <c>email</c> or <c>custom:department</c>.
        /// </para>
        ///  
        /// <para>
        /// In some older user pools, the regex pattern for acceptable values of this parameter
        /// is <c>[\p{L}\p{M}\p{S}\p{N}\p{P}]+</c>. Older pools will eventually be updated to
        /// use the new pattern. Affected user pools are those created before May 2024 in US East
        /// (N. Virginia), US East (Ohio), US West (N. California), US West (Oregon), Asia Pacific
        /// (Mumbai), Asia Pacific (Tokyo), Asia Pacific (Seoul), Asia Pacific (Singapore), Asia
        /// Pacific (Sydney), Canada (Central), Europe (Frankfurt), Europe (Ireland), Europe (London),
        /// Europe (Paris), Europe (Stockholm), Middle East (Bahrain), and South America (São
        /// Paulo). 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=2048)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}