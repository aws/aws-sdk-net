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

namespace Amazon.APIPortal.Model
{
    /// <summary>
    /// One entry per Managed API ID that could not be processed in a batch call. Ids that
    /// succeed are omitted from the response — callers infer success by absence.
    /// </summary>
    public partial class FailedManagedApiItem
    {
        /// <summary>
        /// Gets and sets the property ErrorCode.
        /// </summary>
        [AWSProperty(Required = true)]
        public FailedItemErrorCode ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. A description of the failure.
        /// </summary>
        [AWSProperty(Required = true, Max = 1024)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property ManagedApiId. The identifier of the Managed API that could
        /// not be processed.
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 30)]
        public string ManagedApiId { get; set; }

        /// <summary>
        /// Checks to see if the ManagedApiId property is set.
        /// </summary>
        internal bool IsSetManagedApiId() => this.ManagedApiId != null;
    }
}
