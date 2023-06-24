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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pipes.Model
{
    /// <summary>
    /// The parameters required to set up enrichment on your pipe.
    /// </summary>
    public partial class PipeEnrichmentParameters
    {
        private PipeEnrichmentHttpParameters _httpParameters;
        private string _inputTemplate;

        /// <summary>
        /// Gets and sets the property HttpParameters. 
        /// <para>
        /// Contains the HTTP parameters to use when the target is a API Gateway REST endpoint
        /// or EventBridge ApiDestination.
        /// </para>
        ///  
        /// <para>
        /// If you specify an API Gateway REST API or EventBridge ApiDestination as a target,
        /// you can use this parameter to specify headers, path parameters, and query string keys/values
        /// as part of your target invoking request. If you're using ApiDestinations, the corresponding
        /// Connection can also have these values configured. In case of any conflicting keys,
        /// values from the Connection take precedence.
        /// </para>
        /// </summary>
        public PipeEnrichmentHttpParameters HttpParameters
        {
            get { return this._httpParameters; }
            set { this._httpParameters = value; }
        }

        // Check to see if HttpParameters property is set
        internal bool IsSetHttpParameters()
        {
            return this._httpParameters != null;
        }

        /// <summary>
        /// Gets and sets the property InputTemplate. 
        /// <para>
        /// Valid JSON text passed to the enrichment. In this case, nothing from the event itself
        /// is passed to the enrichment. For more information, see <a href="http://www.rfc-editor.org/rfc/rfc7159.txt">The
        /// JavaScript Object Notation (JSON) Data Interchange Format</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=8192)]
        public string InputTemplate
        {
            get { return this._inputTemplate; }
            set { this._inputTemplate = value; }
        }

        // Check to see if InputTemplate property is set
        internal bool IsSetInputTemplate()
        {
            return this._inputTemplate != null;
        }

    }
}