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

namespace Amazon.Translate.Model
{
    /// <summary>
    /// The number of documents successfully and unsuccessfully processed during a translation
    /// job.
    /// </summary>
    public partial class JobDetails
    {
        /// <summary>
        /// Gets and sets the property DocumentsWithErrorsCount. 
        /// <para>
        /// The number of documents that could not be processed during a translation job.
        /// </para>
        /// </summary>
        public int? DocumentsWithErrorsCount { get; set; }

        /// <summary>
        /// Checks to see if the DocumentsWithErrorsCount property is set.
        /// </summary>
        internal bool IsSetDocumentsWithErrorsCount() => this.DocumentsWithErrorsCount.HasValue;

        /// <summary>
        /// Gets and sets the property InputDocumentsCount. 
        /// <para>
        /// The number of documents used as input in a translation job.
        /// </para>
        /// </summary>
        public int? InputDocumentsCount { get; set; }

        /// <summary>
        /// Checks to see if the InputDocumentsCount property is set.
        /// </summary>
        internal bool IsSetInputDocumentsCount() => this.InputDocumentsCount.HasValue;

        /// <summary>
        /// Gets and sets the property TranslatedDocumentsCount. 
        /// <para>
        /// The number of documents successfully processed during a translation job.
        /// </para>
        /// </summary>
        public int? TranslatedDocumentsCount { get; set; }

        /// <summary>
        /// Checks to see if the TranslatedDocumentsCount property is set.
        /// </summary>
        internal bool IsSetTranslatedDocumentsCount() => this.TranslatedDocumentsCount.HasValue;
    }
}
