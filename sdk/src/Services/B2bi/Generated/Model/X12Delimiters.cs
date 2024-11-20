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
 * Do not modify this file. This file is generated from the b2bi-2022-06-23.normal.json service model.
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
namespace Amazon.B2bi.Model
{
    /// <summary>
    /// In X12 EDI messages, delimiters are used to mark the end of segments or elements,
    /// and are defined in the interchange control header. The delimiters are part of the
    /// message's syntax and divide up its different elements.
    /// </summary>
    public partial class X12Delimiters
    {
        private string _componentSeparator;
        private string _dataElementSeparator;
        private string _segmentTerminator;

        /// <summary>
        /// Gets and sets the property ComponentSeparator. 
        /// <para>
        /// The component, or sub-element, separator. The default value is <c>:</c> (colon).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public string ComponentSeparator
        {
            get { return this._componentSeparator; }
            set { this._componentSeparator = value; }
        }

        // Check to see if ComponentSeparator property is set
        internal bool IsSetComponentSeparator()
        {
            return this._componentSeparator != null;
        }

        /// <summary>
        /// Gets and sets the property DataElementSeparator. 
        /// <para>
        /// The data element separator. The default value is <c>*</c> (asterisk).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public string DataElementSeparator
        {
            get { return this._dataElementSeparator; }
            set { this._dataElementSeparator = value; }
        }

        // Check to see if DataElementSeparator property is set
        internal bool IsSetDataElementSeparator()
        {
            return this._dataElementSeparator != null;
        }

        /// <summary>
        /// Gets and sets the property SegmentTerminator. 
        /// <para>
        /// The segment terminator. The default value is <c>~</c> (tilde).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public string SegmentTerminator
        {
            get { return this._segmentTerminator; }
            set { this._segmentTerminator = value; }
        }

        // Check to see if SegmentTerminator property is set
        internal bool IsSetSegmentTerminator()
        {
            return this._segmentTerminator != null;
        }

    }
}