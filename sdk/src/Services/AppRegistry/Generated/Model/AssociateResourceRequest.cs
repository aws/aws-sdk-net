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
 * Do not modify this file. This file is generated from the servicecatalog-appregistry-2020-06-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppRegistry.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateResource operation.
    /// Associates a resource with an application. The resource can be specified by its ARN
    /// or name. The application can be specified by ARN, ID, or name.
    /// </summary>
    public partial class AssociateResourceRequest : AmazonAppRegistryRequest
    {
        private string _application;
        private string _resource;
        private ResourceType _resourceType;

        /// <summary>
        /// Gets and sets the property Application. 
        /// <para>
        ///  The name, ID, or ARN of the application. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Application
        {
            get { return this._application; }
            set { this._application = value; }
        }

        // Check to see if Application property is set
        internal bool IsSetApplication()
        {
            return this._application != null;
        }

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The name or ID of the resource of which the application will be associated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource of which the application will be associated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}