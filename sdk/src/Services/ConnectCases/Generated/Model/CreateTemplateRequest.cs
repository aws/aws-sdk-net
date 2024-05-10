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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
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
namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTemplate operation.
    /// Creates a template in the Cases domain. This template is used to define the case object
    /// model (that is, to define what data can be captured on cases) in a Cases domain. A
    /// template must have a unique name within a domain, and it must reference existing field
    /// IDs and layout IDs. Additionally, multiple fields with same IDs are not allowed within
    /// the same Template. A template can be either Active or Inactive, as indicated by its
    /// status. Inactive templates cannot be used to create cases.
    /// </summary>
    public partial class CreateTemplateRequest : AmazonConnectCasesRequest
    {
        private string _description;
        private string _domainId;
        private LayoutConfiguration _layoutConfiguration;
        private string _name;
        private List<RequiredField> _requiredFields = AWSConfigs.InitializeCollections ? new List<RequiredField>() : null;
        private TemplateStatus _status;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A brief description of the template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
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
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The unique identifier of the Cases domain. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property LayoutConfiguration. 
        /// <para>
        /// Configuration of layouts associated to the template.
        /// </para>
        /// </summary>
        public LayoutConfiguration LayoutConfiguration
        {
            get { return this._layoutConfiguration; }
            set { this._layoutConfiguration = value; }
        }

        // Check to see if LayoutConfiguration property is set
        internal bool IsSetLayoutConfiguration()
        {
            return this._layoutConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the template. It must be unique per domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Gets and sets the property RequiredFields. 
        /// <para>
        /// A list of fields that must contain a value for a case to be successfully created with
        /// this template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<RequiredField> RequiredFields
        {
            get { return this._requiredFields; }
            set { this._requiredFields = value; }
        }

        // Check to see if RequiredFields property is set
        internal bool IsSetRequiredFields()
        {
            return this._requiredFields != null && (this._requiredFields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the template.
        /// </para>
        /// </summary>
        public TemplateStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}