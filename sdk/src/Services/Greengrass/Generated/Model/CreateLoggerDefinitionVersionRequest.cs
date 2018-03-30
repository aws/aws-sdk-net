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
    /// Container for the parameters to the CreateLoggerDefinitionVersion operation.
    /// Creates a version of a logger definition that has already been defined.
    /// </summary>
    public partial class CreateLoggerDefinitionVersionRequest : AmazonGreengrassRequest
    {
        private string _amznClientToken;
        private string _loggerDefinitionId;
        private List<Logger> _loggers = new List<Logger>();

        /// <summary>
        /// Gets and sets the property AmznClientToken. A client token used to correlate requests
        /// and responses.
        /// </summary>
        public string AmznClientToken
        {
            get { return this._amznClientToken; }
            set { this._amznClientToken = value; }
        }

        // Check to see if AmznClientToken property is set
        internal bool IsSetAmznClientToken()
        {
            return this._amznClientToken != null;
        }

        /// <summary>
        /// Gets and sets the property LoggerDefinitionId. The ID of the logger definition.
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
        /// Gets and sets the property Loggers. A list of loggers.
        /// </summary>
        public List<Logger> Loggers
        {
            get { return this._loggers; }
            set { this._loggers = value; }
        }

        // Check to see if Loggers property is set
        internal bool IsSetLoggers()
        {
            return this._loggers != null && this._loggers.Count > 0; 
        }

    }
}