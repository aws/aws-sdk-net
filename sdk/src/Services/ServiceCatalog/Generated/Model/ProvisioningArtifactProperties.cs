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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Provisioning artifact properties. For example request JSON, see <a>CreateProvisioningArtifact</a>.
    /// </summary>
    public partial class ProvisioningArtifactProperties
    {
        private string _description;
        private Dictionary<string, string> _info = new Dictionary<string, string>();
        private string _name;
        private ProvisioningArtifactType _type;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The text description of the provisioning artifact properties.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Info. 
        /// <para>
        /// Additional information about the provisioning artifact properties. When using this
        /// element in a request, you must specify <code>LoadTemplateFromURL</code>. For more
        /// information, see <a>CreateProvisioningArtifact</a>.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Info
        {
            get { return this._info; }
            set { this._info = value; }
        }

        // Check to see if Info property is set
        internal bool IsSetInfo()
        {
            return this._info != null && this._info.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name assigned to the provisioning artifact properties.
        /// </para>
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

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the provisioning artifact properties. The following provisioning artifact
        /// property types are used by AWS Marketplace products:
        /// </para>
        ///  
        /// <para>
        ///  <code>MARKETPLACE_AMI</code> - AMI products.
        /// </para>
        ///  
        /// <para>
        ///  <code>MARKETPLACE_CAR</code> - CAR (Cluster and AWS Resources) products.
        /// </para>
        /// </summary>
        public ProvisioningArtifactType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}