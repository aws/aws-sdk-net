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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// This is the response object from the DescribeTemplateDefinition operation.
    /// </summary>
    public partial class DescribeTemplateDefinitionResponse : AmazonWebServiceResponse
    {
        private TemplateVersionDefinition _definition;
        private List<TemplateError> _errors = new List<TemplateError>();
        private string _name;
        private string _requestId;
        private ResourceStatus _resourceStatus;
        private int? _status;
        private string _templateId;
        private string _themeArn;

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// The definition of the template.
        /// </para>
        ///  
        /// <para>
        /// A definition is the data model of all features in a Dashboard, Template, or Analysis.
        /// </para>
        /// </summary>
        public TemplateVersionDefinition Definition
        {
            get { return this._definition; }
            set { this._definition = value; }
        }

        // Check to see if Definition property is set
        internal bool IsSetDefinition()
        {
            return this._definition != null;
        }

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// Errors associated with the template version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<TemplateError> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && this._errors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The descriptive name of the template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The Amazon Web Services request ID for this operation.
        /// </para>
        /// </summary>
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceStatus. 
        /// <para>
        /// Status associated with the template.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CREATION_IN_PROGRESS</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CREATION_SUCCESSFUL</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CREATION_FAILED</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UPDATE_IN_PROGRESS</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UPDATE_SUCCESSFUL</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UPDATE_FAILED</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETED</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ResourceStatus ResourceStatus
        {
            get { return this._resourceStatus; }
            set { this._resourceStatus = value; }
        }

        // Check to see if ResourceStatus property is set
        internal bool IsSetResourceStatus()
        {
            return this._resourceStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The HTTP status of the request.
        /// </para>
        /// </summary>
        public int Status
        {
            get { return this._status.GetValueOrDefault(); }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TemplateId. 
        /// <para>
        /// The ID of the template described.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
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

        /// <summary>
        /// Gets and sets the property ThemeArn. 
        /// <para>
        /// The ARN of the theme of the template.
        /// </para>
        /// </summary>
        public string ThemeArn
        {
            get { return this._themeArn; }
            set { this._themeArn = value; }
        }

        // Check to see if ThemeArn property is set
        internal bool IsSetThemeArn()
        {
            return this._themeArn != null;
        }

    }
}