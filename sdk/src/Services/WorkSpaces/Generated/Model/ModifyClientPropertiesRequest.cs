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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyClientProperties operation.
    /// Modifies the properties of the specified Amazon WorkSpaces clients.
    /// </summary>
    public partial class ModifyClientPropertiesRequest : AmazonWorkSpacesRequest
    {
        private ClientProperties _clientProperties;
        private string _resourceId;

        /// <summary>
        /// Gets and sets the property ClientProperties. 
        /// <para>
        /// Information about the Amazon WorkSpaces client.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ClientProperties ClientProperties
        {
            get { return this._clientProperties; }
            set { this._clientProperties = value; }
        }

        // Check to see if ClientProperties property is set
        internal bool IsSetClientProperties()
        {
            return this._clientProperties != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The resource identifiers, in the form of directory IDs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

    }
}