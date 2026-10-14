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
    /// The minimum and maximum length values of an attribute that is of the string type,
    /// for example <c>custom:department</c>.
    /// </summary>
    public partial class StringAttributeConstraintsType
    {
        /// <summary>
        /// Gets and sets the property MaxLength. 
        /// <para>
        /// The maximum length of a string attribute value. Must be a number less than or equal
        /// to <c>2^1023</c>, represented as a string with a length of 131072 characters or fewer.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 131072)]
        public string MaxLength { get; set; }

        /// <summary>
        /// Checks to see if the MaxLength property is set.
        /// </summary>
        internal bool IsSetMaxLength() => this.MaxLength != null;

        /// <summary>
        /// Gets and sets the property MinLength. 
        /// <para>
        /// The minimum length of a string attribute value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 131072)]
        public string MinLength { get; set; }

        /// <summary>
        /// Checks to see if the MinLength property is set.
        /// </summary>
        internal bool IsSetMinLength() => this.MinLength != null;
    }
}
