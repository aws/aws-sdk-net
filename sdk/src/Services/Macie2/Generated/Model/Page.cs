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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
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
namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Specifies the location of an occurrence of sensitive data in an Adobe Portable Document
    /// Format file.
    /// </summary>
    public partial class Page
    {
        private Range _lineRange;
        private Range _offsetRange;
        private long? _pageNumber;

        /// <summary>
        /// Gets and sets the property LineRange.  
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public Range LineRange
        {
            get { return this._lineRange; }
            set { this._lineRange = value; }
        }

        // Check to see if LineRange property is set
        internal bool IsSetLineRange()
        {
            return this._lineRange != null;
        }

        /// <summary>
        /// Gets and sets the property OffsetRange.  
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public Range OffsetRange
        {
            get { return this._offsetRange; }
            set { this._offsetRange = value; }
        }

        // Check to see if OffsetRange property is set
        internal bool IsSetOffsetRange()
        {
            return this._offsetRange != null;
        }

        /// <summary>
        /// Gets and sets the property PageNumber. 
        /// <para>
        /// The page number of the page that contains the sensitive data.
        /// </para>
        /// </summary>
        public long? PageNumber
        {
            get { return this._pageNumber; }
            set { this._pageNumber = value; }
        }

        // Check to see if PageNumber property is set
        internal bool IsSetPageNumber()
        {
            return this._pageNumber.HasValue; 
        }

    }
}