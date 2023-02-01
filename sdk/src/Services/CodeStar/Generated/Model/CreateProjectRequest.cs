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
 * Do not modify this file. This file is generated from the codestar-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeStar.Model
{
    /// <summary>
    /// Container for the parameters to the CreateProject operation.
    /// Creates a project, including project resources. This action creates a project based
    /// on a submitted project request. A set of source code files and a toolchain template
    /// file can be included with the project request. If these are not provided, an empty
    /// project is created.
    /// </summary>
    public partial class CreateProjectRequest : AmazonCodeStarRequest
    {
        private string _clientRequestToken;
        private string _description;
        private string _id;
        private string _name;
        private List<Code> _sourceCode = new List<Code>();
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private Toolchain _toolchain;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A user- or system-generated token that identifies the entity that requested project
        /// creation. This token can be used to repeat the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the project, if any.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=1024)]
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the project to be created in AWS CodeStar.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=15)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The display name for the project to be created in AWS CodeStar.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SourceCode. 
        /// <para>
        /// A list of the Code objects submitted with the project request. If this parameter is
        /// specified, the request must also include the toolchain parameter.
        /// </para>
        /// </summary>
        public List<Code> SourceCode
        {
            get { return this._sourceCode; }
            set { this._sourceCode = value; }
        }

        // Check to see if SourceCode property is set
        internal bool IsSetSourceCode()
        {
            return this._sourceCode != null && this._sourceCode.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags created for the project.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Toolchain. 
        /// <para>
        /// The name of the toolchain template file submitted with the project request. If this
        /// parameter is specified, the request must also include the sourceCode parameter.
        /// </para>
        /// </summary>
        public Toolchain Toolchain
        {
            get { return this._toolchain; }
            set { this._toolchain = value; }
        }

        // Check to see if Toolchain property is set
        internal bool IsSetToolchain()
        {
            return this._toolchain != null;
        }

    }
}