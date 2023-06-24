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
    /// A single modification to the configuration section.
    /// </summary>
    public partial class SectionModification
    {
        private Operation _operation;
        private string _path;
        private string _section;
        private Amazon.Runtime.Documents.Document _value;

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// The operation to be performed on a configuration section.
        /// </para>
        ///  
        /// <para>
        ///  Content can be added, deleted, or replaced within a section. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Operation Operation
        {
            get { return this._operation; }
            set { this._operation = value; }
        }

        // Check to see if Operation property is set
        internal bool IsSetOperation()
        {
            return this._operation != null;
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path within the section content to be modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property Section. 
        /// <para>
        /// The name of the section to be modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
        public string Section
        {
            get { return this._section; }
            set { this._section = value; }
        }

        // Check to see if Section property is set
        internal bool IsSetSection()
        {
            return this._section != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// For add and replace operations, this is the value that will be used.
        /// </para>
        ///  
        /// <para>
        ///  This field should be omitted for delete operations. 
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return !this._value.IsNull();
        }

    }
}