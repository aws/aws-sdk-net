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

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// Container for the parameters to the BatchGetTask operation. Retrieves multiple tasks
    /// in a single request. This is a batch version of the <c>GetTask</c> API. The result
    /// of getting each task is reported individually in the response. Because the batch request
    /// can result in a combination of successful and unsuccessful actions, you should check
    /// for batch errors even when the call returns an HTTP status code of 200.
    /// </summary>
    public partial class BatchGetTaskRequest : AmazonDeadlineRequest
    {
        /// <summary>
        /// Gets and sets the property Identifiers. The list of task identifiers to retrieve.
        /// You can specify up to 100 identifiers per request.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public List<BatchGetTaskIdentifier> Identifiers { get; set; } = AWSConfigs.InitializeCollections ? new List<BatchGetTaskIdentifier>() : null;

        /// <summary>
        /// Checks to see if the Identifiers property is set.
        /// </summary>
        internal bool IsSetIdentifiers() => this.Identifiers != null && (this.Identifiers.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
