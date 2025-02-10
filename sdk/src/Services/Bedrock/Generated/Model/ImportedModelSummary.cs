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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Information about the imported model.
    /// </summary>
    public partial class ImportedModelSummary
    {
        private DateTime? _creationTime;
        private bool? _instructSupported;
        private string _modelArchitecture;
        private string _modelArn;
        private string _modelName;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Creation time of the imported model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstructSupported. 
        /// <para>
        /// Specifies if the imported model supports converse.
        /// </para>
        /// </summary>
        public bool? InstructSupported
        {
            get { return this._instructSupported; }
            set { this._instructSupported = value; }
        }

        // Check to see if InstructSupported property is set
        internal bool IsSetInstructSupported()
        {
            return this._instructSupported.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelArchitecture. 
        /// <para>
        /// The architecture of the imported model.
        /// </para>
        /// </summary>
        public string ModelArchitecture
        {
            get { return this._modelArchitecture; }
            set { this._modelArchitecture = value; }
        }

        // Check to see if ModelArchitecture property is set
        internal bool IsSetModelArchitecture()
        {
            return this._modelArchitecture != null;
        }

        /// <summary>
        /// Gets and sets the property ModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the imported model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=1011)]
        public string ModelArn
        {
            get { return this._modelArn; }
            set { this._modelArn = value; }
        }

        // Check to see if ModelArn property is set
        internal bool IsSetModelArn()
        {
            return this._modelArn != null;
        }

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// Name of the imported model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string ModelName
        {
            get { return this._modelName; }
            set { this._modelName = value; }
        }

        // Check to see if ModelName property is set
        internal bool IsSetModelName()
        {
            return this._modelName != null;
        }

    }
}