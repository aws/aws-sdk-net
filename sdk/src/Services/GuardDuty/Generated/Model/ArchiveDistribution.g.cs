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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains the number and percentage of archived and unarchived findings.
    /// </summary>
    public partial class ArchiveDistribution
    {
        /// <summary>
        /// Gets and sets the property ArchivedCount. 
        /// <para>
        /// The number of archived findings.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? ArchivedCount { get; set; }

        /// <summary>
        /// Checks to see if the ArchivedCount property is set.
        /// </summary>
        internal bool IsSetArchivedCount() => this.ArchivedCount.HasValue;

        /// <summary>
        /// Gets and sets the property ArchivedPercentage. 
        /// <para>
        /// The percentage of findings that are archived, from 0 to 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public double? ArchivedPercentage { get; set; }

        /// <summary>
        /// Checks to see if the ArchivedPercentage property is set.
        /// </summary>
        internal bool IsSetArchivedPercentage() => this.ArchivedPercentage.HasValue;

        /// <summary>
        /// Gets and sets the property UnarchivedCount. 
        /// <para>
        /// The number of unarchived findings.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? UnarchivedCount { get; set; }

        /// <summary>
        /// Checks to see if the UnarchivedCount property is set.
        /// </summary>
        internal bool IsSetUnarchivedCount() => this.UnarchivedCount.HasValue;

        /// <summary>
        /// Gets and sets the property UnarchivedPercentage. 
        /// <para>
        /// The percentage of findings that are unarchived, from 0 to 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public double? UnarchivedPercentage { get; set; }

        /// <summary>
        /// Checks to see if the UnarchivedPercentage property is set.
        /// </summary>
        internal bool IsSetUnarchivedPercentage() => this.UnarchivedPercentage.HasValue;
    }
}
