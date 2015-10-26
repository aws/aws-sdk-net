/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAssociationBatch operation.
    /// Associates the specified SSM document with the specified instances.
    /// 
    ///  
    /// <para>
    /// When you associate an SSM document with an instance, the configuration agent on the
    /// instance processes the document and configures the instance as specified.
    /// </para>
    ///  
    /// <para>
    /// If you associate a document with an instance that already has an associated document,
    /// the system throws the AssociationAlreadyExists exception.
    /// </para>
    /// </summary>
    public partial class CreateAssociationBatchRequest : AmazonSimpleSystemsManagementRequest
    {
        private List<CreateAssociationBatchRequestEntry> _entries = new List<CreateAssociationBatchRequestEntry>();

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
        /// </summary>
        public List<CreateAssociationBatchRequestEntry> Entries
        {
            get { return this._entries; }
            set { this._entries = value; }
        }

        // Check to see if Entries property is set
        internal bool IsSetEntries()
        {
            return this._entries != null && this._entries.Count > 0; 
        }

    }
}