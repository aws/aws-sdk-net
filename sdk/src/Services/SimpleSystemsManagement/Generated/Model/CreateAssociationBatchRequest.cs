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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAssociationBatch operation.
    /// Associates the specified Amazon Web Services Systems Manager document (SSM document)
    /// with the specified managed nodes or targets.
    /// 
    ///  
    /// <para>
    /// When you associate a document with one or more managed nodes using IDs or tags, Amazon
    /// Web Services Systems Manager Agent (SSM Agent) running on the managed node processes
    /// the document and configures the node as specified.
    /// </para>
    ///  
    /// <para>
    /// If you associate a document with a managed node that already has an associated document,
    /// the system returns the AssociationAlreadyExists exception.
    /// </para>
    /// </summary>
    public partial class CreateAssociationBatchRequest : AmazonSimpleSystemsManagementRequest
    {
        private List<CreateAssociationBatchRequestEntry> _entries = AWSConfigs.InitializeCollections ? new List<CreateAssociationBatchRequestEntry>() : null;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateAssociationBatchRequest() { }

        /// <summary>
        /// Instantiates CreateAssociationBatchRequest with the parameterized properties
        /// </summary>
        /// <param name="entries">One or more associations.</param>
        public CreateAssociationBatchRequest(List<CreateAssociationBatchRequestEntry> entries)
        {
            _entries = entries;
        }

        /// <summary>
        /// Gets and sets the property Entries. 
        /// <para>
        /// One or more associations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<CreateAssociationBatchRequestEntry> Entries
        {
            get { return this._entries; }
            set { this._entries = value; }
        }

        // Check to see if Entries property is set
        internal bool IsSetEntries()
        {
            return this._entries != null && (this._entries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}