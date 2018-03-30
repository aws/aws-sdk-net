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
    /// Container for the parameters to the CreateCoreDefinitionVersion operation.
    /// Creates a version of a core definition that has already been defined. AWS Greengrass
    /// groups must each contain exactly one AWS Greengrass core.
    /// </summary>
    public partial class CreateCoreDefinitionVersionRequest : AmazonGreengrassRequest
    {
        private string _amznClientToken;
        private string _coreDefinitionId;
        private List<Core> _cores = new List<Core>();

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
        /// Gets and sets the property CoreDefinitionId. The ID of the core definition.
        /// </summary>
        public string CoreDefinitionId
        {
            get { return this._coreDefinitionId; }
            set { this._coreDefinitionId = value; }
        }

        // Check to see if CoreDefinitionId property is set
        internal bool IsSetCoreDefinitionId()
        {
            return this._coreDefinitionId != null;
        }

        /// <summary>
        /// Gets and sets the property Cores. A list of cores in the core definition version.
        /// </summary>
        public List<Core> Cores
        {
            get { return this._cores; }
            set { this._cores = value; }
        }

        // Check to see if Cores property is set
        internal bool IsSetCores()
        {
            return this._cores != null && this._cores.Count > 0; 
        }

    }
}