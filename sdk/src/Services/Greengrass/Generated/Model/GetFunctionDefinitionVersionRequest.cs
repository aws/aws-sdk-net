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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// Container for the parameters to the GetFunctionDefinitionVersion operation.
    /// Retrieves information about a Lambda function definition version, including which
    /// Lambda functions are included in the version and their configurations.
    /// </summary>
    public partial class GetFunctionDefinitionVersionRequest : AmazonGreengrassRequest
    {
        private string _functionDefinitionId;
        private string _functionDefinitionVersionId;

        /// <summary>
        /// Gets and sets the property FunctionDefinitionId. The ID of the Lambda function definition.
        /// </summary>
        public string FunctionDefinitionId
        {
            get { return this._functionDefinitionId; }
            set { this._functionDefinitionId = value; }
        }

        // Check to see if FunctionDefinitionId property is set
        internal bool IsSetFunctionDefinitionId()
        {
            return this._functionDefinitionId != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionDefinitionVersionId. The ID of the function definition
        /// version.
        /// </summary>
        public string FunctionDefinitionVersionId
        {
            get { return this._functionDefinitionVersionId; }
            set { this._functionDefinitionVersionId = value; }
        }

        // Check to see if FunctionDefinitionVersionId property is set
        internal bool IsSetFunctionDefinitionVersionId()
        {
            return this._functionDefinitionVersionId != null;
        }

    }
}