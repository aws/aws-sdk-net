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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
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
namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Container for the parameters to the CancelSchemaExtension operation.
    /// Cancels an in-progress schema extension to a Microsoft AD directory. Once a schema
    /// extension has started replicating to all domain controllers, the task can no longer
    /// be canceled. A schema extension can be canceled during any of the following states;
    /// <c>Initializing</c>, <c>CreatingSnapshot</c>, and <c>UpdatingSchema</c>.
    /// </summary>
    public partial class CancelSchemaExtensionRequest : AmazonDirectoryServiceRequest
    {
        private string _directoryId;
        private string _schemaExtensionId;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The identifier of the directory whose schema extension will be canceled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaExtensionId. 
        /// <para>
        /// The identifier of the schema extension that will be canceled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SchemaExtensionId
        {
            get { return this._schemaExtensionId; }
            set { this._schemaExtensionId = value; }
        }

        // Check to see if SchemaExtensionId property is set
        internal bool IsSetSchemaExtensionId()
        {
            return this._schemaExtensionId != null;
        }

    }
}