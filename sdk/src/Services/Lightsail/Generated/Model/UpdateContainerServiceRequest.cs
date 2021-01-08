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
    /// Container for the parameters to the UpdateContainerService operation.
    /// Updates the configuration of your Amazon Lightsail container service, such as its
    /// power, scale, and public domain names.
    /// </summary>
    public partial class UpdateContainerServiceRequest : AmazonLightsailRequest
    {
        private bool? _isDisabled;
        private ContainerServicePowerName _power;
        private Dictionary<string, List<string>> _publicDomainNames = new Dictionary<string, List<string>>();
        private int? _scale;
        private string _serviceName;

        /// <summary>
        /// Gets and sets the property IsDisabled. 
        /// <para>
        /// A Boolean value to indicate whether the container service is disabled.
        /// </para>
        /// </summary>
        public bool IsDisabled
        {
            get { return this._isDisabled.GetValueOrDefault(); }
            set { this._isDisabled = value; }
        }

        // Check to see if IsDisabled property is set
        internal bool IsSetIsDisabled()
        {
            return this._isDisabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Power. 
        /// <para>
        /// The power for the container service.
        /// </para>
        ///  
        /// <para>
        /// The power specifies the amount of memory, vCPUs, and base monthly cost of each node
        /// of the container service. The <code>power</code> and <code>scale</code> of a container
        /// service makes up its configured capacity. To determine the monthly price of your container
        /// service, multiply the base price of the <code>power</code> with the <code>scale</code>
        /// (the number of nodes) of the service.
        /// </para>
        ///  
        /// <para>
        /// Use the <code>GetContainerServicePowers</code> action to view the specifications of
        /// each power option.
        /// </para>
        /// </summary>
        public ContainerServicePowerName Power
        {
            get { return this._power; }
            set { this._power = value; }
        }

        // Check to see if Power property is set
        internal bool IsSetPower()
        {
            return this._power != null;
        }

        /// <summary>
        /// Gets and sets the property PublicDomainNames. 
        /// <para>
        /// The public domain names to use with the container service, such as <code>example.com</code>
        /// and <code>www.example.com</code>.
        /// </para>
        ///  
        /// <para>
        /// You can specify up to four public domain names for a container service. The domain
        /// names that you specify are used when you create a deployment with a container configured
        /// as the public endpoint of your container service.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify public domain names, then you can use the default domain of the
        /// container service.
        /// </para>
        ///  <important> 
        /// <para>
        /// You must create and validate an SSL/TLS certificate before you can use public domain
        /// names with your container service. Use the <code>CreateCertificate</code> action to
        /// create a certificate for the public domain names you want to use with your container
        /// service.
        /// </para>
        ///  </important> 
        /// <para>
        /// You can specify public domain names using a string to array map as shown in the example
        /// later on this page.
        /// </para>
        /// </summary>
        public Dictionary<string, List<string>> PublicDomainNames
        {
            get { return this._publicDomainNames; }
            set { this._publicDomainNames = value; }
        }

        // Check to see if PublicDomainNames property is set
        internal bool IsSetPublicDomainNames()
        {
            return this._publicDomainNames != null && this._publicDomainNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Scale. 
        /// <para>
        /// The scale for the container service.
        /// </para>
        ///  
        /// <para>
        /// The scale specifies the allocated compute nodes of the container service. The <code>power</code>
        /// and <code>scale</code> of a container service makes up its configured capacity. To
        /// determine the monthly price of your container service, multiply the base price of
        /// the <code>power</code> with the <code>scale</code> (the number of nodes) of the service.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public int Scale
        {
            get { return this._scale.GetValueOrDefault(); }
            set { this._scale = value; }
        }

        // Check to see if Scale property is set
        internal bool IsSetScale()
        {
            return this._scale.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the container service to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

    }
}