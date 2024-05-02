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
 * Do not modify this file. This file is generated from the m2-2021-04-28.normal.json service model.
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
namespace Amazon.MainframeModernization.Model
{
    /// <summary>
    /// Defines an alternate key. This value is optional. A legacy data set might not have
    /// any alternate key defined but if those alternate keys definitions exist, provide them,
    /// as some applications will make use of them.
    /// </summary>
    public partial class AlternateKey
    {
        private bool? _allowDuplicates;
        private int? _length;
        private string _name;
        private int? _offset;

        /// <summary>
        /// Gets and sets the property AllowDuplicates. 
        /// <para>
        /// Indicates whether the alternate key values are supposed to be unique for the given
        /// data set.
        /// </para>
        /// </summary>
        public bool? AllowDuplicates
        {
            get { return this._allowDuplicates; }
            set { this._allowDuplicates = value; }
        }

        // Check to see if AllowDuplicates property is set
        internal bool IsSetAllowDuplicates()
        {
            return this._allowDuplicates.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Length. 
        /// <para>
        /// A strictly positive integer value representing the length of the alternate key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Length
        {
            get { return this._length; }
            set { this._length = value; }
        }

        // Check to see if Length property is set
        internal bool IsSetLength()
        {
            return this._length.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the alternate key.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Offset. 
        /// <para>
        /// A positive integer value representing the offset to mark the start of the alternate
        /// key part in the record byte array.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Offset
        {
            get { return this._offset; }
            set { this._offset = value; }
        }

        // Check to see if Offset property is set
        internal bool IsSetOffset()
        {
            return this._offset.HasValue; 
        }

    }
}