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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// The output for the <a>GetTemplateSummary</a> action.
    /// </summary>
    public partial class GetTemplateSummaryResponse : AmazonWebServiceResponse
    {
        private List<string> _capabilities = new List<string>();
        private string _capabilitiesReason;
        private string _description;
        private string _metadata;
        private List<ParameterDeclaration> _parameters = new List<ParameterDeclaration>();
        private string _version;

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// The capabilities found within the template. Currently, AWS CloudFormation supports
        /// only the CAPABILITY_IAM capability. If your template contains IAM resources, you must
        /// specify the CAPABILITY_IAM value for this parameter when you use the <a>CreateStack</a>
        /// or <a>UpdateStack</a> actions with your template; otherwise, those actions return
        /// an InsufficientCapabilities error.
        /// </para>
        /// </summary>
        public List<string> Capabilities
        {
            get { return this._capabilities; }
            set { this._capabilities = value; }
        }

        // Check to see if Capabilities property is set
        internal bool IsSetCapabilities()
        {
            return this._capabilities != null && this._capabilities.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CapabilitiesReason. 
        /// <para>
        /// The list of resources that generated the values in the <code>Capabilities</code> response
        /// element.
        /// </para>
        /// </summary>
        public string CapabilitiesReason
        {
            get { return this._capabilitiesReason; }
            set { this._capabilitiesReason = value; }
        }

        // Check to see if CapabilitiesReason property is set
        internal bool IsSetCapabilitiesReason()
        {
            return this._capabilitiesReason != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The value that is defined in the <code>Description</code> property of the template.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The value that is defined for the <code>Metadata</code> property of the template.
        /// </para>
        /// </summary>
        public string Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A list of parameter declarations that describe various properties for each parameter.
        /// </para>
        /// </summary>
        public List<ParameterDeclaration> Parameters
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
        /// Gets and sets the property Version. 
        /// <para>
        /// The AWS template format version, which identifies the capabilities of the template.
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}