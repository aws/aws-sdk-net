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
    /// Container for the parameters to the StartSchemaExtension operation.
    /// Applies a schema extension to a Microsoft AD directory.
    /// </summary>
    public partial class StartSchemaExtensionRequest : AmazonDirectoryServiceRequest
    {
        private bool? _createSnapshotBeforeSchemaExtension;
        private string _description;
        private string _directoryId;
        private string _ldifContent;

        /// <summary>
        /// Gets and sets the property CreateSnapshotBeforeSchemaExtension. 
        /// <para>
        /// If true, creates a snapshot of the directory before applying the schema extension.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? CreateSnapshotBeforeSchemaExtension
        {
            get { return this._createSnapshotBeforeSchemaExtension; }
            set { this._createSnapshotBeforeSchemaExtension = value; }
        }

        // Check to see if CreateSnapshotBeforeSchemaExtension property is set
        internal bool IsSetCreateSnapshotBeforeSchemaExtension()
        {
            return this._createSnapshotBeforeSchemaExtension.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the schema extension.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=128)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The identifier of the directory for which the schema extension will be applied to.
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
        /// Gets and sets the property LdifContent. 
        /// <para>
        /// The LDIF file represented as a string. To construct the LdifContent string, precede
        /// each line as it would be formatted in an ldif file with \n. See the example request
        /// below for more details. The file size can be no larger than 1MB.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500000)]
        public string LdifContent
        {
            get { return this._ldifContent; }
            set { this._ldifContent = value; }
        }

        // Check to see if LdifContent property is set
        internal bool IsSetLdifContent()
        {
            return this._ldifContent != null;
        }

    }
}