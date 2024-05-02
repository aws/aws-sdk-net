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
    /// Container for the parameters to the GetResourceDefinition operation.
    /// Retrieves information about a resource definition, including its creation time and
    /// latest version.
    /// </summary>
    public partial class GetResourceDefinitionRequest : AmazonGreengrassRequest
    {
        private string _resourceDefinitionId;

        /// <summary>
        /// Gets and sets the property ResourceDefinitionId. The ID of the resource definition.
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceDefinitionId
        {
            get { return this._resourceDefinitionId; }
            set { this._resourceDefinitionId = value; }
        }

        // Check to see if ResourceDefinitionId property is set
        internal bool IsSetResourceDefinitionId()
        {
            return this._resourceDefinitionId != null;
        }

    }
}