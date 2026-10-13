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

namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// Any additional query string parameter for the connection. You can include up to 100
    /// additional query string parameters per request. Each additional parameter counts towards
    /// the event payload size, which cannot exceed 64 KB.
    /// </summary>
    public partial class ConnectionQueryStringParameter
    {
        /// <summary>
        /// Gets and sets the property IsValueSecret. 
        /// <para>
        /// Specifies whether the value is secret.
        /// </para>
        /// </summary>
        public bool? IsValueSecret { get; set; }

        /// <summary>
        /// Checks to see if the IsValueSecret property is set.
        /// </summary>
        internal bool IsSetIsValueSecret() => this.IsValueSecret.HasValue;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The key for a query string parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value associated with the key for the query string parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 512)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
