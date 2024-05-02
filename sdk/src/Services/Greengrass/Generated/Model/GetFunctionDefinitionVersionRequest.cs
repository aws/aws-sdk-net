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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
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
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property FunctionDefinitionId. The ID of the Lambda function definition.
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// version. This value maps to the ''Version'' property of the corresponding ''VersionInformation''
        /// object, which is returned by ''ListFunctionDefinitionVersions'' requests. If the version
        /// is the last one that was associated with a function definition, the value also maps
        /// to the ''LatestVersion'' property of the corresponding ''DefinitionInformation'' object.
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property NextToken. The token for the next set of results, or ''null''
        /// if there are no additional results.
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}