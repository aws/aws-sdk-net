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
 * Do not modify this file. This file is generated from the osis-2022-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OSIS.Model
{
    /// <summary>
    /// This is the response object from the ListPipelineBlueprints operation.
    /// </summary>
    public partial class ListPipelineBlueprintsResponse : AmazonWebServiceResponse
    {
        private List<PipelineBlueprintSummary> _blueprints = new List<PipelineBlueprintSummary>();

        /// <summary>
        /// Gets and sets the property Blueprints. 
        /// <para>
        /// A list of available blueprints for Data Prepper.
        /// </para>
        /// </summary>
        public List<PipelineBlueprintSummary> Blueprints
        {
            get { return this._blueprints; }
            set { this._blueprints = value; }
        }

        // Check to see if Blueprints property is set
        internal bool IsSetBlueprints()
        {
            return this._blueprints != null && this._blueprints.Count > 0; 
        }

    }
}