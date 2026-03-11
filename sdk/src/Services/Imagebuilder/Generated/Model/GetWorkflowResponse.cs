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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
    /// This is the response object from the GetWorkflow operation.
    /// </summary>
    public partial class GetWorkflowResponse : AmazonWebServiceResponse
    {
        private LatestVersionReferences _latestVersionReferences;
        private Workflow _workflow;

        /// <summary>
        /// Gets and sets the property LatestVersionReferences. 
        /// <para>
        /// The resource ARNs with different wildcard variations of semantic versioning.
        /// </para>
        /// </summary>
        public LatestVersionReferences LatestVersionReferences
        {
            get { return this._latestVersionReferences; }
            set { this._latestVersionReferences = value; }
        }

        // Check to see if LatestVersionReferences property is set
        internal bool IsSetLatestVersionReferences()
        {
            return this._latestVersionReferences != null;
        }

        /// <summary>
        /// Gets and sets the property Workflow. 
        /// <para>
        /// The workflow resource specified in the request.
        /// </para>
        /// </summary>
        public Workflow Workflow
        {
            get { return this._workflow; }
            set { this._workflow = value; }
        }

        // Check to see if Workflow property is set
        internal bool IsSetWorkflow()
        {
            return this._workflow != null;
        }

    }
}