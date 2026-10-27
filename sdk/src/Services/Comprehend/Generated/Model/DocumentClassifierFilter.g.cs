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
    /// Provides information for filtering a list of document classifiers. You can only specify
    /// one filtering parameter in a request. For more information, see the <c>ListDocumentClassifiers</c>
    /// operation.
    /// </summary>
    public partial class DocumentClassifierFilter
    {
        /// <summary>
        /// Gets and sets the property DocumentClassifierName. 
        /// <para>
        /// The name that you assigned to the document classifier
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string DocumentClassifierName { get; set; }

        /// <summary>
        /// Checks to see if the DocumentClassifierName property is set.
        /// </summary>
        internal bool IsSetDocumentClassifierName() => this.DocumentClassifierName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Filters the list of classifiers based on status.
        /// </para>
        /// </summary>
        public ModelStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SubmitTimeAfter. 
        /// <para>
        /// Filters the list of classifiers based on the time that the classifier was submitted
        /// for processing. Returns only classifiers submitted after the specified time. Classifiers
        /// are returned in descending order, newest to oldest.
        /// </para>
        /// </summary>
        public DateTime? SubmitTimeAfter { get; set; }

        /// <summary>
        /// Checks to see if the SubmitTimeAfter property is set.
        /// </summary>
        internal bool IsSetSubmitTimeAfter() => this.SubmitTimeAfter.HasValue;

        /// <summary>
        /// Gets and sets the property SubmitTimeBefore. 
        /// <para>
        /// Filters the list of classifiers based on the time that the classifier was submitted
        /// for processing. Returns only classifiers submitted before the specified time. Classifiers
        /// are returned in ascending order, oldest to newest.
        /// </para>
        /// </summary>
        public DateTime? SubmitTimeBefore { get; set; }

        /// <summary>
        /// Checks to see if the SubmitTimeBefore property is set.
        /// </summary>
        internal bool IsSetSubmitTimeBefore() => this.SubmitTimeBefore.HasValue;
    }
}
