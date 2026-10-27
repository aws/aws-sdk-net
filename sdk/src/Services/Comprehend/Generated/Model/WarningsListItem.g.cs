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
    /// The system identified one of the following warnings while processing the input document:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// The document to classify is plain text, but the classifier is a native document model.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The document to classify is semi-structured, but the classifier is a plain-text model.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class WarningsListItem
    {
        /// <summary>
        /// Gets and sets the property Page. 
        /// <para>
        /// Page number in the input document.
        /// </para>
        /// </summary>
        public int? Page { get; set; }

        /// <summary>
        /// Checks to see if the Page property is set.
        /// </summary>
        internal bool IsSetPage() => this.Page.HasValue;

        /// <summary>
        /// Gets and sets the property WarnCode. 
        /// <para>
        /// The type of warning.
        /// </para>
        /// </summary>
        public PageBasedWarningCode WarnCode { get; set; }

        /// <summary>
        /// Checks to see if the WarnCode property is set.
        /// </summary>
        internal bool IsSetWarnCode() => this.WarnCode != null;

        /// <summary>
        /// Gets and sets the property WarnMessage. 
        /// <para>
        /// Text message associated with the warning.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string WarnMessage { get; set; }

        /// <summary>
        /// Checks to see if the WarnMessage property is set.
        /// </summary>
        internal bool IsSetWarnMessage() => this.WarnMessage != null;
    }
}
