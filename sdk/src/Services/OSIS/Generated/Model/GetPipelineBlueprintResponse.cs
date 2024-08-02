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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.OSIS.Model
{
    /// <summary>
    /// This is the response object from the GetPipelineBlueprint operation.
    /// </summary>
    public partial class GetPipelineBlueprintResponse : AmazonWebServiceResponse
    {
        private PipelineBlueprint _blueprint;
        private string _format;

        /// <summary>
        /// Gets and sets the property Blueprint. 
        /// <para>
        /// The requested blueprint in YAML format.
        /// </para>
        /// </summary>
        public PipelineBlueprint Blueprint
        {
            get { return this._blueprint; }
            set { this._blueprint = value; }
        }

        // Check to see if Blueprint property is set
        internal bool IsSetBlueprint()
        {
            return this._blueprint != null;
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the blueprint.
        /// </para>
        /// </summary>
        public string Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

    }
}