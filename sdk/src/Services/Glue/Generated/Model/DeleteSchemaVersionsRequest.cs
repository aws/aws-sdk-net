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
    /// Container for the parameters to the DeleteSchemaVersions operation.
    /// Remove versions from the specified schema. A version number or range may be supplied.
    /// If the compatibility mode forbids deleting of a version that is necessary, such as
    /// BACKWARDS_FULL, an error is returned. Calling the <c>GetSchemaVersions</c> API after
    /// this call will list the status of the deleted versions.
    /// 
    ///  
    /// <para>
    /// When the range of version numbers contain check pointed version, the API will return
    /// a 409 conflict and will not proceed with the deletion. You have to remove the checkpoint
    /// first using the <c>DeleteSchemaCheckpoint</c> API before using this API.
    /// </para>
    ///  
    /// <para>
    /// You cannot use the <c>DeleteSchemaVersions</c> API to delete the first schema version
    /// in the schema set. The first schema version can only be deleted by the <c>DeleteSchema</c>
    /// API. This operation will also delete the attached <c>SchemaVersionMetadata</c> under
    /// the schema versions. Hard deletes will be enforced on the database.
    /// </para>
    ///  
    /// <para>
    /// If the compatibility mode forbids deleting of a version that is necessary, such as
    /// BACKWARDS_FULL, an error is returned.
    /// </para>
    /// </summary>
    public partial class DeleteSchemaVersionsRequest : AmazonGlueRequest
    {
        private SchemaId _schemaId;
        private string _versions;

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

        /// <summary>
        /// Gets and sets the property Versions. 
        /// <para>
        /// A version range may be supplied which may be of the format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// a single version number, 5
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// a range, 5-8 : deletes versions 5, 6, 7, 8
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100000)]
        public string Versions
        {
            get { return this._versions; }
            set { this._versions = value; }
        }

        // Check to see if Versions property is set
        internal bool IsSetVersions()
        {
            return this._versions != null;
        }

    }
}