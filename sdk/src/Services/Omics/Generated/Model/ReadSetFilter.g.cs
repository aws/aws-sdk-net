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
    /// A filter for read sets.
    /// </summary>
    public partial class ReadSetFilter
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
        /// Gets and sets the property CreationType. 
        /// <para>
        ///  The creation type of the read set. 
        /// </para>
        /// </summary>
        public CreationType CreationType { get; set; }

        /// <summary>
        /// Checks to see if the CreationType property is set.
        /// </summary>
        internal bool IsSetCreationType() => this.CreationType != null;

        /// <summary>
        /// Gets and sets the property GeneratedFrom. 
        /// <para>
        ///  Where the source originated. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 127)]
        public string GeneratedFrom { get; set; }

        /// <summary>
        /// Checks to see if the GeneratedFrom property is set.
        /// </summary>
        internal bool IsSetGeneratedFrom() => this.GeneratedFrom != null;

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
        /// Gets and sets the property ReferenceArn. 
        /// <para>
        /// A genome reference ARN to filter on.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 127)]
        public string ReferenceArn { get; set; }

        /// <summary>
        /// Checks to see if the ReferenceArn property is set.
        /// </summary>
        internal bool IsSetReferenceArn() => this.ReferenceArn != null;

        /// <summary>
        /// Gets and sets the property SampleId. 
        /// <para>
        ///  The read set source's sample ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 127)]
        public string SampleId { get; set; }

        /// <summary>
        /// Checks to see if the SampleId property is set.
        /// </summary>
        internal bool IsSetSampleId() => this.SampleId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// A status to filter on.
        /// </para>
        /// </summary>
        public ReadSetStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SubjectId. 
        /// <para>
        ///  The read set source's subject ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 127)]
        public string SubjectId { get; set; }

        /// <summary>
        /// Checks to see if the SubjectId property is set.
        /// </summary>
        internal bool IsSetSubjectId() => this.SubjectId != null;
    }
}
