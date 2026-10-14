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

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Filter the datasets based on creation time or dataset status.
    /// </summary>
    public partial class DatasetFilter
    {
        /// <summary>
        /// Gets and sets the property CreationTimeAfter. 
        /// <para>
        /// Filter the datasets to include datasets created after the specified time.
        /// </para>
        /// </summary>
        public DateTime? CreationTimeAfter { get; set; }

        /// <summary>
        /// Checks to see if the CreationTimeAfter property is set.
        /// </summary>
        internal bool IsSetCreationTimeAfter() => this.CreationTimeAfter.HasValue;

        /// <summary>
        /// Gets and sets the property CreationTimeBefore. 
        /// <para>
        /// Filter the datasets to include datasets created before the specified time.
        /// </para>
        /// </summary>
        public DateTime? CreationTimeBefore { get; set; }

        /// <summary>
        /// Checks to see if the CreationTimeBefore property is set.
        /// </summary>
        internal bool IsSetCreationTimeBefore() => this.CreationTimeBefore.HasValue;

        /// <summary>
        /// Gets and sets the property DatasetType. 
        /// <para>
        /// Filter the datasets based on the dataset type.
        /// </para>
        /// </summary>
        public DatasetType DatasetType { get; set; }

        /// <summary>
        /// Checks to see if the DatasetType property is set.
        /// </summary>
        internal bool IsSetDatasetType() => this.DatasetType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Filter the datasets based on the dataset status.
        /// </para>
        /// </summary>
        public DatasetStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
