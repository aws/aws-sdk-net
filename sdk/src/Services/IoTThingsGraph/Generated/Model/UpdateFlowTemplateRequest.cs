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
 * Do not modify this file. This file is generated from the iotthingsgraph-2018-09-06.normal.json service model.
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
namespace Amazon.IoTThingsGraph.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateFlowTemplate operation.
    /// Updates the specified workflow. All deployed systems and system instances that use
    /// the workflow will see the changes in the flow when it is redeployed. If you don't
    /// want this behavior, copy the workflow (creating a new workflow with a different ID),
    /// and update the copy. The workflow can contain only entities in the specified namespace.
    /// </summary>
    public partial class UpdateFlowTemplateRequest : AmazonIoTThingsGraphRequest
    {
        private long? _compatibleNamespaceVersion;
        private DefinitionDocument _definition;
        private string _id;

        /// <summary>
        /// Gets and sets the property CompatibleNamespaceVersion. 
        /// <para>
        /// The version of the user's namespace.
        /// </para>
        ///  
        /// <para>
        /// If no value is specified, the latest version is used by default. Use the <c>GetFlowTemplateRevisions</c>
        /// if you want to find earlier revisions of the flow to update.
        /// </para>
        /// </summary>
        public long? CompatibleNamespaceVersion
        {
            get { return this._compatibleNamespaceVersion; }
            set { this._compatibleNamespaceVersion = value; }
        }

        // Check to see if CompatibleNamespaceVersion property is set
        internal bool IsSetCompatibleNamespaceVersion()
        {
            return this._compatibleNamespaceVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// The <c>DefinitionDocument</c> that contains the updated workflow definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DefinitionDocument Definition
        {
            get { return this._definition; }
            set { this._definition = value; }
        }

        // Check to see if Definition property is set
        internal bool IsSetDefinition()
        {
            return this._definition != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the workflow to be updated.
        /// </para>
        ///  
        /// <para>
        /// The ID should be in the following format.
        /// </para>
        ///  
        /// <para>
        ///  <c>urn:tdm:REGION/ACCOUNT ID/default:workflow:WORKFLOWNAME</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=160)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

    }
}