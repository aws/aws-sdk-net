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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// This is the response object from the GetContainerServices operation.
    /// </summary>
    public partial class GetContainerServicesResponse : AmazonWebServiceResponse
    {
        private List<ContainerService> _containerServices = new List<ContainerService>();

        /// <summary>
        /// Gets and sets the property ContainerServices. 
        /// <para>
        /// An array of objects that describe one or more container services.
        /// </para>
        /// </summary>
        public List<ContainerService> ContainerServices
        {
            get { return this._containerServices; }
            set { this._containerServices = value; }
        }

        // Check to see if ContainerServices property is set
        internal bool IsSetContainerServices()
        {
            return this._containerServices != null && this._containerServices.Count > 0; 
        }

    }
}