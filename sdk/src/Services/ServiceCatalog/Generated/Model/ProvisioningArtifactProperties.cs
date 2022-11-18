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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Information about a provisioning artifact (also known as a version) for a product.
    /// </summary>
    public partial class ProvisioningArtifactProperties
    {
        private string _description;
        private bool? _disableTemplateValidation;
        private Dictionary<string, string> _info = new Dictionary<string, string>();
        private string _name;
        private ProvisioningArtifactType _type;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the provisioning artifact, including how it differs from the previous
        /// provisioning artifact.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8192)]
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
        /// Gets and sets the property DisableTemplateValidation. 
        /// <para>
        /// If set to true, Service Catalog stops validating the specified provisioning artifact
        /// even if it is invalid.
        /// </para>
        /// </summary>
        public bool DisableTemplateValidation
        {
            get { return this._disableTemplateValidation.GetValueOrDefault(); }
            set { this._disableTemplateValidation = value; }
        }

        // Check to see if DisableTemplateValidation property is set
        internal bool IsSetDisableTemplateValidation()
        {
            return this._disableTemplateValidation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Info. 
        /// <para>
        /// Specify the template source with one of the following options, but not both. Keys
        /// accepted: [ <code>LoadTemplateFromURL</code>, <code>ImportFromPhysicalId</code> ]
        /// </para>
        ///  
        /// <para>
        /// The URL of the CloudFormation template in Amazon S3 or GitHub in JSON format. Specify
        /// the URL in JSON format as follows:
        /// </para>
        ///  
        /// <para>
        ///  <code>"LoadTemplateFromURL": "https://s3.amazonaws.com/cf-templates-ozkq9d3hgiq2-us-east-1/..."</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>ImportFromPhysicalId</code>: The physical id of the resource that contains
        /// the template. Currently only supports CloudFormation stack arn. Specify the physical
        /// id in JSON format as follows: <code>ImportFromPhysicalId: “arn:aws:cloudformation:[us-east-1]:[accountId]:stack/[StackName]/[resourceId]</code>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// The name of the provisioning artifact (for example, v1 v2beta). No spaces are allowed.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8192)]
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
        /// The type of provisioning artifact.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CLOUD_FORMATION_TEMPLATE</code> - CloudFormation template
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MARKETPLACE_AMI</code> - Amazon Web Services Marketplace AMI
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MARKETPLACE_CAR</code> - Amazon Web Services Marketplace Clusters and Amazon
        /// Web Services Resources
        /// </para>
        ///  </li> </ul>
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