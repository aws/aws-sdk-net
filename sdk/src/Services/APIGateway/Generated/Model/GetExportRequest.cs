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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Container for the parameters to the GetExport operation.
    /// 
    /// </summary>
    public partial class GetExportRequest : AmazonAPIGatewayRequest
    {
        private string _accepts;
        private string _exportType;
        private Dictionary<string, string> _parameters = new Dictionary<string, string>();
        private string _restApiId;
        private string _stageName;

        /// <summary>
        /// Gets and sets the property Accepts.
        /// </summary>
        public string Accepts
        {
            get { return this._accepts; }
            set { this._accepts = value; }
        }

        // Check to see if Accepts property is set
        internal bool IsSetAccepts()
        {
            return this._accepts != null;
        }

        /// <summary>
        /// Gets and sets the property ExportType.
        /// </summary>
        public string ExportType
        {
            get { return this._exportType; }
            set { this._exportType = value; }
        }

        // Check to see if ExportType property is set
        internal bool IsSetExportType()
        {
            return this._exportType != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters.
        /// </summary>
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RestApiId.
        /// </summary>
        public string RestApiId
        {
            get { return this._restApiId; }
            set { this._restApiId = value; }
        }

        // Check to see if RestApiId property is set
        internal bool IsSetRestApiId()
        {
            return this._restApiId != null;
        }

        /// <summary>
        /// Gets and sets the property StageName.
        /// </summary>
        public string StageName
        {
            get { return this._stageName; }
            set { this._stageName = value; }
        }

        // Check to see if StageName property is set
        internal bool IsSetStageName()
        {
            return this._stageName != null;
        }

    }
}