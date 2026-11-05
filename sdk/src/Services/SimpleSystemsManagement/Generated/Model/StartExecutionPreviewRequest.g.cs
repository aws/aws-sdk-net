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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the StartExecutionPreview operation. Initiates the
    /// process of creating a preview showing the effects that running a specified Automation
    /// runbook would have on the targeted resources.
    /// </summary>
    public partial class StartExecutionPreviewRequest : AmazonSimpleSystemsManagementRequest
    {
        /// <summary>
        /// Gets and sets the property DocumentName. 
        /// <para>
        /// The name of the Automation runbook to run. The result of the execution preview indicates
        /// what the impact would be of running this runbook.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DocumentName { get; set; }

        /// <summary>
        /// Checks to see if the DocumentName property is set.
        /// </summary>
        internal bool IsSetDocumentName() => this.DocumentName != null;

        /// <summary>
        /// Gets and sets the property DocumentVersion. 
        /// <para>
        /// The version of the Automation runbook to run. The default value is <c>$DEFAULT</c>.
        /// </para>
        /// </summary>
        public string DocumentVersion { get; set; }

        /// <summary>
        /// Checks to see if the DocumentVersion property is set.
        /// </summary>
        internal bool IsSetDocumentVersion() => this.DocumentVersion != null;

        /// <summary>
        /// Gets and sets the property ExecutionInputs. 
        /// <para>
        /// Information about the inputs that can be specified for the preview operation. 
        /// </para>
        /// </summary>
        public ExecutionInputs ExecutionInputs { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionInputs property is set.
        /// </summary>
        internal bool IsSetExecutionInputs() => this.ExecutionInputs != null;
    }
}
