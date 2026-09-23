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

namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// This is the response object from the ReportInstrumentationConfigurationStatus operation.
    /// </summary>
    public partial class ReportInstrumentationConfigurationStatusResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment echoed from the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Environment { get; set; }

        /// <summary>
        /// Checks to see if the Environment property is set.
        /// </summary>
        internal bool IsSetEnvironment() => this.Environment != null;

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// The service name echoed from the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Service { get; set; }

        /// <summary>
        /// Checks to see if the Service property is set.
        /// </summary>
        internal bool IsSetService() => this.Service != null;

        /// <summary>
        /// Gets and sets the property UnprocessedStatusEvents. 
        /// <para>
        /// Status events that failed to be processed. Each entry includes the configuration identifiers,
        /// status, timestamp, and a reason for the failure.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<UnprocessedStatusEvent> UnprocessedStatusEvents { get; set; } = AWSConfigs.InitializeCollections ? new List<UnprocessedStatusEvent>() : null;

        /// <summary>
        /// Checks to see if the UnprocessedStatusEvents property is set.
        /// </summary>
        internal bool IsSetUnprocessedStatusEvents() => this.UnprocessedStatusEvents != null && (this.UnprocessedStatusEvents.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
