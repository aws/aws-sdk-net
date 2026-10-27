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

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// This is the response object from the CreateWorkflow operation.
    /// </summary>
    public partial class CreateWorkflowResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The client token that uniquely identifies the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property LatestVersionReferences. 
        /// <para>
        /// A set of wildcard version ARNs that always reference the latest version of the resource.
        /// ARNs are included for the latest version overall, and for the latest versions within
        /// the same major, minor, and patch levels.
        /// </para>
        /// </summary>
        public LatestVersionReferences LatestVersionReferences { get; set; }

        /// <summary>
        /// Checks to see if the LatestVersionReferences property is set.
        /// </summary>
        internal bool IsSetLatestVersionReferences() => this.LatestVersionReferences != null;

        /// <summary>
        /// Gets and sets the property WorkflowBuildVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the workflow resource that the request created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string WorkflowBuildVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowBuildVersionArn property is set.
        /// </summary>
        internal bool IsSetWorkflowBuildVersionArn() => this.WorkflowBuildVersionArn != null;
    }
}
