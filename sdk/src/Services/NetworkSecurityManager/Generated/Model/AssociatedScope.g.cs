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

namespace Amazon.NetworkSecurityManager.Model
{
    /// <summary>
    /// An association between a deployment and a scope, as returned in outputs. The corresponding
    /// request structure is <c>ScopeReference</c>.
    /// </summary>
    public partial class AssociatedScope
    {
        /// <summary>
        /// Gets and sets the property ScopeArn. 
        /// <para>
        /// The ARN of the associated scope.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 1010)]
        public string ScopeArn { get; set; }

        /// <summary>
        /// Checks to see if the ScopeArn property is set.
        /// </summary>
        internal bool IsSetScopeArn() => this.ScopeArn != null;
    }
}
