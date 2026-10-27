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

namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// HTTP invocation parameters for subscribers (API Gateway / API Destination). Values
    /// are forwarded to the HTTP endpoint.
    /// </summary>
    public partial class HttpParameters
    {
        /// <summary>
        /// Gets and sets the property HeaderParameters.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public Dictionary<string, string> HeaderParameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the HeaderParameters property is set.
        /// </summary>
        internal bool IsSetHeaderParameters() => this.HeaderParameters != null && (this.HeaderParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InvocationTimeoutSeconds. Timeout in seconds for each invocation
        /// of the target (1-30). String-typed (not integer) so the value may be a JSONata expression.
        /// </summary>
        public string InvocationTimeoutSeconds { get; set; }

        /// <summary>
        /// Checks to see if the InvocationTimeoutSeconds property is set.
        /// </summary>
        internal bool IsSetInvocationTimeoutSeconds() => this.InvocationTimeoutSeconds != null;

        /// <summary>
        /// Gets and sets the property PathParameterValues.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public List<string> PathParameterValues { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PathParameterValues property is set.
        /// </summary>
        internal bool IsSetPathParameterValues() => this.PathParameterValues != null && (this.PathParameterValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property QueryStringParameters.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public Dictionary<string, string> QueryStringParameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the QueryStringParameters property is set.
        /// </summary>
        internal bool IsSetQueryStringParameters() => this.QueryStringParameters != null && (this.QueryStringParameters.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
