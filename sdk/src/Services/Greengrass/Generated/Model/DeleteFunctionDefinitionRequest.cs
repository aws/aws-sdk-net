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
    /// Container for the parameters to the DeleteFunctionDefinition operation.
    /// Deletes a Lambda function definition.
    /// </summary>
    public partial class DeleteFunctionDefinitionRequest : AmazonGreengrassRequest
    {
        private string _functionDefinitionId;

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

    }
}