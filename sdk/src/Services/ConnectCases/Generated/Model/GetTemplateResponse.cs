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

namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// This is the response object from the GetTemplate operation.
    /// </summary>
    public partial class GetTemplateResponse : AmazonWebServiceResponse
    {
        private string _description;
        private LayoutConfiguration _layoutConfiguration;
        private string _name;
        private List<RequiredField> _requiredFields = new List<RequiredField>();
        private TemplateStatus _status;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private string _templateArn;
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
        /// The name of the template.
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
            return this._requiredFields != null && this._requiredFields.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of of key-value pairs that represent tags on a resource. Tags are used to organize,
        /// track, or control access for this resource.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TemplateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string TemplateArn
        {
            get { return this._templateArn; }
            set { this._templateArn = value; }
        }

        // Check to see if TemplateArn property is set
        internal bool IsSetTemplateArn()
        {
            return this._templateArn != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateId. 
        /// <para>
        /// A unique identifier of a template.
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