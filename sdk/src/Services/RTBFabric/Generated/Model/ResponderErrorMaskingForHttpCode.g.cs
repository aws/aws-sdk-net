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

namespace Amazon.RTBFabric.Model
{
    /// <summary>
    /// Describes the masking for HTTP error codes.
    /// </summary>
    public partial class ResponderErrorMaskingForHttpCode
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action for the error..
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResponderErrorMaskingAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property HttpCode. 
        /// <para>
        /// The HTTP error code.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 7)]
        public string HttpCode { get; set; }

        /// <summary>
        /// Checks to see if the HttpCode property is set.
        /// </summary>
        internal bool IsSetHttpCode() => this.HttpCode != null;

        /// <summary>
        /// Gets and sets the property LoggingTypes. 
        /// <para>
        /// The error log type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2)]
        public List<string> LoggingTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LoggingTypes property is set.
        /// </summary>
        internal bool IsSetLoggingTypes() => this.LoggingTypes != null && (this.LoggingTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResponseLoggingPercentage. 
        /// <para>
        /// The percentage of response logging.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public float? ResponseLoggingPercentage { get; set; }

        /// <summary>
        /// Checks to see if the ResponseLoggingPercentage property is set.
        /// </summary>
        internal bool IsSetResponseLoggingPercentage() => this.ResponseLoggingPercentage.HasValue;
    }
}
