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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
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
namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Contains details of the source files.
    /// </summary>
    public partial class InputFile
    {
        private string _name;
        private FileSource _source;
        private FileUseCase _useCase;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the source file.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Source. 
        /// <para>
        /// Specifies where the files are located.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FileSource Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property UseCase. 
        /// <para>
        /// Specifies how the source files will be used by the code interpreter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FileUseCase UseCase
        {
            get { return this._useCase; }
            set { this._useCase = value; }
        }

        // Check to see if UseCase property is set
        internal bool IsSetUseCase()
        {
            return this._useCase != null;
        }

    }
}