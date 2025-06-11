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
 * Do not modify this file. This file is generated from the controlcatalog-2018-05-10.normal.json service model.
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
namespace Amazon.ControlCatalog.Model
{
    /// <summary>
    /// A structure that contains information about a control mapping, including the control
    /// ARN, mapping type, and mapping details.
    /// </summary>
    public partial class ControlMapping
    {
        private string _controlArn;
        private Mapping _mapping;
        private MappingType _mappingType;

        /// <summary>
        /// Gets and sets the property ControlArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the control in the mapping.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=34, Max=2048)]
        public string ControlArn
        {
            get { return this._controlArn; }
            set { this._controlArn = value; }
        }

        // Check to see if ControlArn property is set
        internal bool IsSetControlArn()
        {
            return this._controlArn != null;
        }

        /// <summary>
        /// Gets and sets the property Mapping. 
        /// <para>
        /// The details of the mapping relationship, containing either framework or common control
        /// information.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Mapping Mapping
        {
            get { return this._mapping; }
            set { this._mapping = value; }
        }

        // Check to see if Mapping property is set
        internal bool IsSetMapping()
        {
            return this._mapping != null;
        }

        /// <summary>
        /// Gets and sets the property MappingType. 
        /// <para>
        /// The type of mapping relationship between the control and other entities. Indicates
        /// whether the mapping is to a framework or common control.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MappingType MappingType
        {
            get { return this._mappingType; }
            set { this._mappingType = value; }
        }

        // Check to see if MappingType property is set
        internal bool IsSetMappingType()
        {
            return this._mappingType != null;
        }

    }
}