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

namespace Amazon.Omics.Model
{
    /// <summary>
    /// Container for the parameters to the ListBatch operation. Returns a list of run batches
    /// in your account, with optional filtering by status, name, or run group. Results are
    /// paginated. Only one filter per call is supported.
    /// </summary>
    public partial class ListBatchRequest : AmazonOmicsRequest
    {
        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The maximum number of batches to return. If not specified, defaults to 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxItems { get; set; }

        /// <summary>
        /// Checks to see if the MaxItems property is set.
        /// </summary>
        internal bool IsSetMaxItems() => this.MaxItems.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Filter batches by name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RunGroupId. 
        /// <para>
        /// Filter batches by run group ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 18)]
        public string RunGroupId { get; set; }

        /// <summary>
        /// Checks to see if the RunGroupId property is set.
        /// </summary>
        internal bool IsSetRunGroupId() => this.RunGroupId != null;

        /// <summary>
        /// Gets and sets the property StartingToken. 
        /// <para>
        /// A pagination token returned from a prior <c>ListBatch</c> call.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string StartingToken { get; set; }

        /// <summary>
        /// Checks to see if the StartingToken property is set.
        /// </summary>
        internal bool IsSetStartingToken() => this.StartingToken != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Filter batches by status.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public BatchStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
