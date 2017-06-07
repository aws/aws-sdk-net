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
    /// Container for the parameters to the GetLoggerDefinitionVersion operation.
    /// Retrieves information about a logger definition version.
    /// </summary>
    public partial class GetLoggerDefinitionVersionRequest : AmazonGreengrassRequest
    {
        private string _loggerDefinitionId;
        private string _loggerDefinitionVersionId;

        /// <summary>
        /// Gets and sets the property LoggerDefinitionId. logger definition Id
        /// </summary>
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
        /// Gets and sets the property LoggerDefinitionVersionId. logger definition version Id
        /// </summary>
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

    }
}