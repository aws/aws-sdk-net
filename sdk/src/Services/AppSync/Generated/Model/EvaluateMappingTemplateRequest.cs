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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
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
namespace Amazon.AppSync.Model
{
    /// <summary>
    /// Container for the parameters to the EvaluateMappingTemplate operation.
    /// Evaluates a given template and returns the response. The mapping template can be a
    /// request or response template.
    /// 
    ///  
    /// <para>
    /// Request templates take the incoming request after a GraphQL operation is parsed and
    /// convert it into a request configuration for the selected data source operation. Response
    /// templates interpret responses from the data source and map it to the shape of the
    /// GraphQL field output type.
    /// </para>
    ///  
    /// <para>
    /// Mapping templates are written in the Apache Velocity Template Language (VTL).
    /// </para>
    /// </summary>
    public partial class EvaluateMappingTemplateRequest : AmazonAppSyncRequest
    {
        private string _context;
        private string _template;

        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        /// The map that holds all of the contextual information for your resolver invocation.
        /// A <c>context</c> is required for this action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=28000)]
        public string Context
        {
            get { return this._context; }
            set { this._context = value; }
        }

        // Check to see if Context property is set
        internal bool IsSetContext()
        {
            return this._context != null;
        }

        /// <summary>
        /// Gets and sets the property Template. 
        /// <para>
        /// The mapping template; this can be a request or response template. A <c>template</c>
        /// is required for this action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=65536)]
        public string Template
        {
            get { return this._template; }
            set { this._template = value; }
        }

        // Check to see if Template property is set
        internal bool IsSetTemplate()
        {
            return this._template != null;
        }

    }
}