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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
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
namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Information about a Letter of Authorization - Connecting Facility Assignment (LOA-CFA)
    /// for a connection.
    /// </summary>
    public partial class DescribeLoaResponse : AmazonWebServiceResponse
    {
        private MemoryStream _loaContent;
        private LoaContentType _loaContentType;

        /// <summary>
        /// Gets and sets the property LoaContent. 
        /// <para>
        /// The binary contents of the LOA-CFA document.
        /// </para>
        /// </summary>
        public MemoryStream LoaContent
        {
            get { return this._loaContent; }
            set { this._loaContent = value; }
        }

        // Check to see if LoaContent property is set
        internal bool IsSetLoaContent()
        {
            return this._loaContent != null;
        }

        /// <summary>
        /// Gets and sets the property LoaContentType. 
        /// <para>
        /// The standard media type for the LOA-CFA document. The only supported value is application/pdf.
        /// </para>
        /// </summary>
        public LoaContentType LoaContentType
        {
            get { return this._loaContentType; }
            set { this._loaContentType = value; }
        }

        // Check to see if LoaContentType property is set
        internal bool IsSetLoaContentType()
        {
            return this._loaContentType != null;
        }

    }
}