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

namespace Amazon.CloudWatchEvents.Model
{
    /// <summary>
    /// Contains additional parameters for the connection.
    /// </summary>
    public partial class ConnectionHttpParameters
    {
        /// <summary>
        /// Gets and sets the property BodyParameters. 
        /// <para>
        /// Contains additional body string parameters for the connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<ConnectionBodyParameter> BodyParameters { get; set; } = AWSConfigs.InitializeCollections ? new List<ConnectionBodyParameter>() : null;

        /// <summary>
        /// Checks to see if the BodyParameters property is set.
        /// </summary>
        internal bool IsSetBodyParameters() => this.BodyParameters != null && (this.BodyParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HeaderParameters. 
        /// <para>
        /// Contains additional header parameters for the connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<ConnectionHeaderParameter> HeaderParameters { get; set; } = AWSConfigs.InitializeCollections ? new List<ConnectionHeaderParameter>() : null;

        /// <summary>
        /// Checks to see if the HeaderParameters property is set.
        /// </summary>
        internal bool IsSetHeaderParameters() => this.HeaderParameters != null && (this.HeaderParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property QueryStringParameters. 
        /// <para>
        /// Contains additional query string parameters for the connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<ConnectionQueryStringParameter> QueryStringParameters { get; set; } = AWSConfigs.InitializeCollections ? new List<ConnectionQueryStringParameter>() : null;

        /// <summary>
        /// Checks to see if the QueryStringParameters property is set.
        /// </summary>
        internal bool IsSetQueryStringParameters() => this.QueryStringParameters != null && (this.QueryStringParameters.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
