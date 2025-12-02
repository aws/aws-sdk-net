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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Defines the data type structure for a log field, including the type, element information,
    /// and nested fields for complex types.
    /// </summary>
    public partial class LogFieldType
    {
        private LogFieldType _element;
        private List<LogFieldsListItem> _fields = AWSConfigs.InitializeCollections ? new List<LogFieldsListItem>() : null;
        private string _type;

        /// <summary>
        /// Gets and sets the property Element. 
        /// <para>
        /// For array or collection types, specifies the element type information.
        /// </para>
        /// </summary>
        public LogFieldType Element
        {
            get { return this._element; }
            set { this._element = value; }
        }

        // Check to see if Element property is set
        internal bool IsSetElement()
        {
            return this._element != null;
        }

        /// <summary>
        /// Gets and sets the property Fields. 
        /// <para>
        /// For complex types, contains the nested field definitions.
        /// </para>
        /// </summary>
        public List<LogFieldsListItem> Fields
        {
            get { return this._fields; }
            set { this._fields = value; }
        }

        // Check to see if Fields property is set
        internal bool IsSetFields()
        {
            return this._fields != null && (this._fields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The data type of the log field.
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}