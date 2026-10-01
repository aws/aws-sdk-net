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
    /// A filter for a sequence store.
    /// </summary>
    public partial class SequenceStoreFilter
    {
        /// <summary>
        /// Gets and sets the property CreatedAfter. 
        /// <para>
        /// The filter's start date.
        /// </para>
        /// </summary>
        public DateTime? CreatedAfter { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAfter property is set.
        /// </summary>
        internal bool IsSetCreatedAfter() => this.CreatedAfter.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBefore. 
        /// <para>
        /// The filter's end date.
        /// </para>
        /// </summary>
        public DateTime? CreatedBefore { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBefore property is set.
        /// </summary>
        internal bool IsSetCreatedBefore() => this.CreatedBefore.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name to filter on.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 127)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Filter results based on status.
        /// </para>
        /// </summary>
        public SequenceStoreStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAfter. 
        /// <para>
        /// Filter results based on stores updated after the specified time.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAfter { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAfter property is set.
        /// </summary>
        internal bool IsSetUpdatedAfter() => this.UpdatedAfter.HasValue;

        /// <summary>
        /// Gets and sets the property UpdatedBefore. 
        /// <para>
        /// Filter results based on stores updated before the specified time.
        /// </para>
        /// </summary>
        public DateTime? UpdatedBefore { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedBefore property is set.
        /// </summary>
        internal bool IsSetUpdatedBefore() => this.UpdatedBefore.HasValue;
    }
}
