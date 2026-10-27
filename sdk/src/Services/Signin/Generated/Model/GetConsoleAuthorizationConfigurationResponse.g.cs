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

namespace Amazon.Signin.Model
{
    /// <summary>
    /// This is the response object from the GetConsoleAuthorizationConfiguration operation.
    /// </summary>
    public partial class GetConsoleAuthorizationConfigurationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ConsoleAuthorizationEnabled. Whether console authorization
        /// is enabled
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? ConsoleAuthorizationEnabled { get; set; }

        /// <summary>
        /// Checks to see if the ConsoleAuthorizationEnabled property is set.
        /// </summary>
        internal bool IsSetConsoleAuthorizationEnabled() => this.ConsoleAuthorizationEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property Scope. Authorization scope
        /// </summary>
        [AWSProperty(Required = true)]
        public string Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;

        /// <summary>
        /// Gets and sets the property TargetId. Target account identifier
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 32)]
        public string TargetId { get; set; }

        /// <summary>
        /// Checks to see if the TargetId property is set.
        /// </summary>
        internal bool IsSetTargetId() => this.TargetId != null;
    }
}
