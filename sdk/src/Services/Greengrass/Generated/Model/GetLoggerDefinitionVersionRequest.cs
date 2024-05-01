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
    /// Container for the parameters to the GetLoggerDefinitionVersion operation.
    /// Retrieves information about a logger definition version.
    /// </summary>
    public partial class GetLoggerDefinitionVersionRequest : AmazonGreengrassRequest
    {
        private string _loggerDefinitionId;
        private string _loggerDefinitionVersionId;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property LoggerDefinitionId. The ID of the logger definition.
        /// </summary>
        [AWSProperty(Required=true)]
        public string LoggerDefinitionId
        {
            get { return this._loggerDefinitionId; }
            set { this._loggerDefinitionId = value; }
        }

        // Check to see if LoggerDefinitionId property is set
        internal bool IsSetLoggerDefinitionId()
        {
            return this._loggerDefinitionId != null;
        }

        /// <summary>
        /// Gets and sets the property LoggerDefinitionVersionId. The ID of the logger definition
        /// version. This value maps to the ''Version'' property of the corresponding ''VersionInformation''
        /// object, which is returned by ''ListLoggerDefinitionVersions'' requests. If the version
        /// is the last one that was associated with a logger definition, the value also maps
        /// to the ''LatestVersion'' property of the corresponding ''DefinitionInformation'' object.
        /// </summary>
        [AWSProperty(Required=true)]
        public string LoggerDefinitionVersionId
        {
            get { return this._loggerDefinitionVersionId; }
            set { this._loggerDefinitionVersionId = value; }
        }

        // Check to see if LoggerDefinitionVersionId property is set
        internal bool IsSetLoggerDefinitionVersionId()
        {
            return this._loggerDefinitionVersionId != null;
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