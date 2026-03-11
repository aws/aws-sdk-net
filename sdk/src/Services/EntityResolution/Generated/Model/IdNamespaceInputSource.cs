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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
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
namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// An object containing <c>inputSourceARN</c> and <c>schemaName</c>.
    /// </summary>
    public partial class IdNamespaceInputSource
    {
        private string _inputSourceARN;
        private string _schemaName;

        /// <summary>
        /// Gets and sets the property InputSourceARN. 
        /// <para>
        /// An Glue table Amazon Resource Name (ARN) or a matching workflow ARN for the input
        /// source table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InputSourceARN
        {
            get { return this._inputSourceARN; }
            set { this._inputSourceARN = value; }
        }

        // Check to see if InputSourceARN property is set
        internal bool IsSetInputSourceARN()
        {
            return this._inputSourceARN != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaName. 
        /// <para>
        /// The name of the schema.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string SchemaName
        {
            get { return this._schemaName; }
            set { this._schemaName = value; }
        }

        // Check to see if SchemaName property is set
        internal bool IsSetSchemaName()
        {
            return this._schemaName != null;
        }

    }
}