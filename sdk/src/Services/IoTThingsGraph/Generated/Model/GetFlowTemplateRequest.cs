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

namespace Amazon.IoTThingsGraph.Model
{
    /// <summary>
    /// Container for the parameters to the GetFlowTemplate operation.
    /// Gets the latest version of the <code>DefinitionDocument</code> and <code>FlowTemplateSummary</code>
    /// for the specified workflow.
    /// </summary>
    public partial class GetFlowTemplateRequest : AmazonIoTThingsGraphRequest
    {
        private string _id;
        private long? _revisionNumber;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the workflow.
        /// </para>
        ///  
        /// <para>
        /// The ID should be in the following format.
        /// </para>
        ///  
        /// <para>
        ///  <code>urn:tdm:REGION/ACCOUNT ID/default:workflow:WORKFLOWNAME</code> 
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

        /// <summary>
        /// Gets and sets the property RevisionNumber. 
        /// <para>
        /// The number of the workflow revision to retrieve.
        /// </para>
        /// </summary>
        public long RevisionNumber
        {
            get { return this._revisionNumber.GetValueOrDefault(); }
            set { this._revisionNumber = value; }
        }

        // Check to see if RevisionNumber property is set
        internal bool IsSetRevisionNumber()
        {
            return this._revisionNumber.HasValue; 
        }

    }
}