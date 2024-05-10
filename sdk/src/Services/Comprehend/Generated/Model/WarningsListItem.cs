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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
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
        private int? _page;
        private PageBasedWarningCode _warnCode;
        private string _warnMessage;

        /// <summary>
        /// Gets and sets the property Page. 
        /// <para>
        /// Page number in the input document.
        /// </para>
        /// </summary>
        public int? Page
        {
            get { return this._page; }
            set { this._page = value; }
        }

        // Check to see if Page property is set
        internal bool IsSetPage()
        {
            return this._page.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WarnCode. 
        /// <para>
        /// The type of warning.
        /// </para>
        /// </summary>
        public PageBasedWarningCode WarnCode
        {
            get { return this._warnCode; }
            set { this._warnCode = value; }
        }

        // Check to see if WarnCode property is set
        internal bool IsSetWarnCode()
        {
            return this._warnCode != null;
        }

        /// <summary>
        /// Gets and sets the property WarnMessage. 
        /// <para>
        /// Text message associated with the warning.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string WarnMessage
        {
            get { return this._warnMessage; }
            set { this._warnMessage = value; }
        }

        // Check to see if WarnMessage property is set
        internal bool IsSetWarnMessage()
        {
            return this._warnMessage != null;
        }

    }
}