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
 * Do not modify this file. This file is generated from the gamesparks-2021-08-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameSparks.Model
{
    /// <summary>
    /// The configuration section.
    /// </summary>
    public partial class Section
    {
        private Amazon.Runtime.Documents.Document _attributes;
        private string _name;
        private int? _size;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The content of a configuration section.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return !this._attributes.IsNull();
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the section.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
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
        /// Gets and sets the property Size. 
        /// <para>
        /// The size, in bytes, of the section contents.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int Size
        {
            get { return this._size.GetValueOrDefault(); }
            set { this._size = value; }
        }

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this._size.HasValue; 
        }

    }
}