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
    /// Container for the parameters to the GetCoreDefinition operation.
    /// Retrieves information about a core definition version.
    /// </summary>
    public partial class GetCoreDefinitionRequest : AmazonGreengrassRequest
    {
        private string _coreDefinitionId;

        /// <summary>
        /// Gets and sets the property CoreDefinitionId. core definition Id
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

    }
}