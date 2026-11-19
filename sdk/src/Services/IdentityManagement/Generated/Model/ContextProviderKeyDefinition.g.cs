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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Defines a single mapping from a source key in the external identity provider's assertion
    /// or token to a target trusted context key.
    /// 
    ///  
    /// <para>
    /// This data type is used as a member of the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ContextProvider.html">ContextProvider</a>
    /// data type.
    /// </para>
    /// </summary>
    public partial class ContextProviderKeyDefinition
    {
        /// <summary>
        /// Gets and sets the property SourceKey. 
        /// <para>
        /// The key in the external identity provider's assertion or token to read the value from.
        /// </para>
        ///  
        /// <para>
        /// The key can contain only ASCII letters (A-Z, a-z), numbers (0-9), single spaces, and
        /// the following characters: <c>_ . : / = + - @ #</c>. It can't start or end with a space
        /// or contain two spaces in a row.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string SourceKey { get; set; }

        /// <summary>
        /// Checks to see if the SourceKey property is set.
        /// </summary>
        internal bool IsSetSourceKey() => this.SourceKey != null;

        /// <summary>
        /// Gets and sets the property TargetKey. 
        /// <para>
        /// The trusted context key to map the source value into.
        /// </para>
        ///  
        /// <para>
        /// The key can contain only ASCII letters (A-Z, a-z), numbers (0-9), single spaces, and
        /// the following characters: <c>_ . : / = + - @ #</c>. It can't start or end with a space
        /// or contain two spaces in a row.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string TargetKey { get; set; }

        /// <summary>
        /// Checks to see if the TargetKey property is set.
        /// </summary>
        internal bool IsSetTargetKey() => this.TargetKey != null;
    }
}
