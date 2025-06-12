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
    /// Container for the parameters to the UpdateTemplate operation.
    /// Updates the attributes of an existing template. The template attributes that can be
    /// modified include <c>name</c>, <c>description</c>, <c>layoutConfiguration</c>, <c>requiredFields</c>,
    /// and <c>status</c>. At least one of these attributes must not be null. If a null value
    /// is provided for a given attribute, that attribute is ignored and its current value
    /// is preserved.
    /// 
    ///  
    /// <para>
    /// Other template APIs are:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_connect-cases_CreateTemplate.html">CreateTemplate</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_connect-cases_DeleteTemplate.html">DeleteTemplate</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_connect-cases_GetTemplate.html">GetTemplate</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_connect-cases_ListTemplates.html">ListTemplates</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class UpdateTemplateRequest : AmazonConnectCasesRequest
    {
        private string _description;
        private string _domainId;
        private LayoutConfiguration _layoutConfiguration;
        private string _name;
        private List<RequiredField> _requiredFields = AWSConfigs.InitializeCollections ? new List<RequiredField>() : null;
        private List<TemplateRule> _rules = AWSConfigs.InitializeCollections ? new List<TemplateRule>() : null;
        private TemplateStatus _status;
        private string _templateId;

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
        /// The name of the template. It must be unique per domain.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// Gets and sets the property Rules. 
        /// <para>
        /// A list of case rules (also known as <a href="https://docs.aws.amazon.com/connect/latest/adminguide/case-field-conditions.html">case
        /// field conditions</a>) on a template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<TemplateRule> Rules
        {
            get { return this._rules; }
            set { this._rules = value; }
        }

        // Check to see if Rules property is set
        internal bool IsSetRules()
        {
            return this._rules != null && (this._rules.Count > 0 || !AWSConfigs.InitializeCollections); 
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

        /// <summary>
        /// Gets and sets the property TemplateId. 
        /// <para>
        /// A unique identifier for the template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string TemplateId
        {
            get { return this._templateId; }
            set { this._templateId = value; }
        }

        // Check to see if TemplateId property is set
        internal bool IsSetTemplateId()
        {
            return this._templateId != null;
        }

    }
}