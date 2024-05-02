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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A structure that represents a default formatting definition.
    /// </summary>
    public partial class DefaultFormatting
    {
        private DisplayFormat _displayFormat;
        private DisplayFormatOptions _displayFormatOptions;

        /// <summary>
        /// Gets and sets the property DisplayFormat. 
        /// <para>
        /// The display format. Valid values for this structure are <c>AUTO</c>, <c>PERCENT</c>,
        /// <c>CURRENCY</c>, <c>NUMBER</c>, <c>DATE</c>, and <c>STRING</c>.
        /// </para>
        /// </summary>
        public DisplayFormat DisplayFormat
        {
            get { return this._displayFormat; }
            set { this._displayFormat = value; }
        }

        // Check to see if DisplayFormat property is set
        internal bool IsSetDisplayFormat()
        {
            return this._displayFormat != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayFormatOptions. 
        /// <para>
        /// The additional options for display formatting.
        /// </para>
        /// </summary>
        public DisplayFormatOptions DisplayFormatOptions
        {
            get { return this._displayFormatOptions; }
            set { this._displayFormatOptions = value; }
        }

        // Check to see if DisplayFormatOptions property is set
        internal bool IsSetDisplayFormatOptions()
        {
            return this._displayFormatOptions != null;
        }

    }
}