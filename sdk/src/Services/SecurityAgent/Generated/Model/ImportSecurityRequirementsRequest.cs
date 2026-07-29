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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
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
namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Container for the parameters to the ImportSecurityRequirements operation.
    /// Imports security requirements from uploaded documents into a customer managed security
    /// requirement pack. The import process asynchronously extracts and generates structured
    /// security requirements from the provided source files.
    /// </summary>
    public partial class ImportSecurityRequirementsRequest : AmazonSecurityAgentRequest
    {
        private ImportSource _input;
        private string _packId;

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// The import source containing the documents to extract security requirements from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImportSource Input
        {
            get { return this._input; }
            set { this._input = value; }
        }

        // Check to see if Input property is set
        internal bool IsSetInput()
        {
            return this._input != null;
        }

        /// <summary>
        /// Gets and sets the property PackId. 
        /// <para>
        /// The unique identifier of the security requirement pack to import requirements into.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PackId
        {
            get { return this._packId; }
            set { this._packId = value; }
        }

        // Check to see if PackId property is set
        internal bool IsSetPackId()
        {
            return this._packId != null;
        }

    }
}