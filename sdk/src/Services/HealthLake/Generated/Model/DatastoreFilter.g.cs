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

namespace Amazon.HealthLake.Model
{
    /// <summary>
    /// The filters applied to a data store query.
    /// </summary>
    public partial class DatastoreFilter
    {
        /// <summary>
        /// Gets and sets the property CreatedAfter. 
        /// <para>
        /// Filter to set cutoff dates for records. All data stores created after the specified
        /// date are included in the results.
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
        /// Filter to set cutoff dates for records. All data stores created before the specified
        /// date are included in the results. 
        /// </para>
        /// </summary>
        public DateTime? CreatedBefore { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBefore property is set.
        /// </summary>
        internal bool IsSetCreatedBefore() => this.CreatedBefore.HasValue;

        /// <summary>
        /// Gets and sets the property DatastoreName. 
        /// <para>
        /// Filter data store results by name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string DatastoreName { get; set; }

        /// <summary>
        /// Checks to see if the DatastoreName property is set.
        /// </summary>
        internal bool IsSetDatastoreName() => this.DatastoreName != null;

        /// <summary>
        /// Gets and sets the property DatastoreStatus. 
        /// <para>
        /// Filter data store results by status.
        /// </para>
        /// </summary>
        public DatastoreStatus DatastoreStatus { get; set; }

        /// <summary>
        /// Checks to see if the DatastoreStatus property is set.
        /// </summary>
        internal bool IsSetDatastoreStatus() => this.DatastoreStatus != null;
    }
}
