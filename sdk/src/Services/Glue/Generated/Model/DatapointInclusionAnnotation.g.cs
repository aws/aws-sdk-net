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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// An Inclusion Annotation.
    /// </summary>
    public partial class DatapointInclusionAnnotation
    {
        /// <summary>
        /// Gets and sets the property InclusionAnnotation. 
        /// <para>
        /// The inclusion annotation value to apply to the statistic.
        /// </para>
        /// </summary>
        public InclusionAnnotationValue InclusionAnnotation { get; set; }

        /// <summary>
        /// Checks to see if the InclusionAnnotation property is set.
        /// </summary>
        internal bool IsSetInclusionAnnotation() => this.InclusionAnnotation != null;

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// The ID of the data quality profile the statistic belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ProfileId { get; set; }

        /// <summary>
        /// Checks to see if the ProfileId property is set.
        /// </summary>
        internal bool IsSetProfileId() => this.ProfileId != null;

        /// <summary>
        /// Gets and sets the property StatisticId. 
        /// <para>
        /// The Statistic ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string StatisticId { get; set; }

        /// <summary>
        /// Checks to see if the StatisticId property is set.
        /// </summary>
        internal bool IsSetStatisticId() => this.StatisticId != null;
    }
}
