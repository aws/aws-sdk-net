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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteSchema operation.
    /// Deletes the entire schema set, including the schema set and all of its versions. To
    /// get the status of the delete operation, you can call <c>GetSchema</c> API after the
    /// asynchronous call. Deleting a registry will deactivate all online operations for the
    /// schema, such as the <c>GetSchemaByDefinition</c>, and <c>RegisterSchemaVersion</c>
    /// APIs.
    /// </summary>
    public partial class DeleteSchemaRequest : AmazonGlueRequest
    {
        private SchemaId _schemaId;

        /// <summary>
        /// Gets and sets the property SchemaId. 
        /// <para>
        /// This is a wrapper structure that may contain the schema name and Amazon Resource Name
        /// (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SchemaId SchemaId
        {
            get { return this._schemaId; }
            set { this._schemaId = value; }
        }

        // Check to see if SchemaId property is set
        internal bool IsSetSchemaId()
        {
            return this._schemaId != null;
        }

    }
}