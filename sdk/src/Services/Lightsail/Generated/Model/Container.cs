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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the settings of a container that will be launched, or that is launched,
    /// to an Amazon Lightsail container service.
    /// </summary>
    public partial class Container
    {
        private List<string> _command = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _environment = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _image;
        private Dictionary<string, string> _ports = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The launch command for the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Command
        {
            get { return this._command; }
            set { this._command = value; }
        }

        // Check to see if Command property is set
        internal bool IsSetCommand()
        {
            return this._command != null && (this._command.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment variables of the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Environment
        {
            get { return this._environment; }
            set { this._environment = value; }
        }

        // Check to see if Environment property is set
        internal bool IsSetEnvironment()
        {
            return this._environment != null && (this._environment.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// The name of the image used for the container.
        /// </para>
        ///  
        /// <para>
        /// Container images sourced from your Lightsail container service, that are registered
        /// and stored on your service, start with a colon (<c>:</c>). For example, if your container
        /// service name is <c>container-service-1</c>, the container image label is <c>mystaticsite</c>,
        /// and you want to use the third (<c>3</c>) version of the registered container image,
        /// then you should specify <c>:container-service-1.mystaticsite.3</c>. To use the latest
        /// version of a container image, specify <c>latest</c> instead of a version number (for
        /// example, <c>:container-service-1.mystaticsite.latest</c>). Lightsail will automatically
        /// use the highest numbered version of the registered container image.
        /// </para>
        ///  
        /// <para>
        /// Container images sourced from a public registry like Docker Hub don't start with a
        /// colon. For example, <c>nginx:latest</c> or <c>nginx</c>.
        /// </para>
        /// </summary>
        public string Image
        {
            get { return this._image; }
            set { this._image = value; }
        }

        // Check to see if Image property is set
        internal bool IsSetImage()
        {
            return this._image != null;
        }

        /// <summary>
        /// Gets and sets the property Ports. 
        /// <para>
        /// The open firewall ports of the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Ports
        {
            get { return this._ports; }
            set { this._ports = value; }
        }

        // Check to see if Ports property is set
        internal bool IsSetPorts()
        {
            return this._ports != null && (this._ports.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}