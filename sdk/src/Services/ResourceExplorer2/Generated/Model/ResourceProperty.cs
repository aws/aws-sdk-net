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
 * Do not modify this file. This file is generated from the resource-explorer-2-2022-07-28.normal.json service model.
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
namespace Amazon.ResourceExplorer2.Model
{
    /// <summary>
    /// A structure that describes a property of a resource.
    /// </summary>
    public partial class ResourceProperty
    {
        private Amazon.Runtime.Documents.Document _data;
        private DateTime? _lastReportedAt;
        private string _name;

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// Details about this property. The content of this field is a JSON object that varies
        /// based on the resource type.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document Data
        {
            get { return this._data; }
            set { this._data = value; }
        }

        // Check to see if Data property is set
        internal bool IsSetData()
        {
            return !this._data.IsNull();
        }

        /// <summary>
        /// Gets and sets the property LastReportedAt. 
        /// <para>
        /// The date and time that the information about this resource property was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastReportedAt
        {
            get { return this._lastReportedAt; }
            set { this._lastReportedAt = value; }
        }

        // Check to see if LastReportedAt property is set
        internal bool IsSetLastReportedAt()
        {
            return this._lastReportedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of this property of the resource.
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

    }
}