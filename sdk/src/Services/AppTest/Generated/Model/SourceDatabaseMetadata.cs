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
 * Do not modify this file. This file is generated from the apptest-2022-12-06.normal.json service model.
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
namespace Amazon.AppTest.Model
{
    /// <summary>
    /// Specifies the source database metadata.
    /// </summary>
    public partial class SourceDatabaseMetadata
    {
        private CaptureTool _captureTool;
        private SourceDatabase _type;

        /// <summary>
        /// Gets and sets the property CaptureTool. 
        /// <para>
        /// The capture tool of the source database metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CaptureTool CaptureTool
        {
            get { return this._captureTool; }
            set { this._captureTool = value; }
        }

        // Check to see if CaptureTool property is set
        internal bool IsSetCaptureTool()
        {
            return this._captureTool != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the source database metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SourceDatabase Type
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