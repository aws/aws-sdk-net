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
    /// Container for the parameters to the CreateFunctionDefinition operation.
    /// Creates a Lambda function definition which contains a list of Lambda functions and
    /// their configurations to be used in a group. You can create an initial version of the
    /// definition by providing a list of Lambda functions and their configurations now, or
    /// use ``CreateFunctionDefinitionVersion`` later.
    /// </summary>
    public partial class CreateFunctionDefinitionRequest : AmazonGreengrassRequest
    {
        private string _amznClientToken;
        private FunctionDefinitionVersion _initialVersion;
        private string _name;

        /// <summary>
        /// Gets and sets the property AmznClientToken. The client token used to request idempotent
        /// operations.
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
        /// Gets and sets the property InitialVersion. Information on the initial version
        /// </summary>
        public FunctionDefinitionVersion InitialVersion
        {
            get { return this._initialVersion; }
            set { this._initialVersion = value; }
        }

        // Check to see if InitialVersion property is set
        internal bool IsSetInitialVersion()
        {
            return this._initialVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Name. name of the function definition
        /// </summary>
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

    }
}