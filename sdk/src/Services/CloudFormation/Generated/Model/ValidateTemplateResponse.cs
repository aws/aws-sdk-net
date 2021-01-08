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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// The output for <a>ValidateTemplate</a> action.
    /// </summary>
    public partial class ValidateTemplateResponse : AmazonWebServiceResponse
    {
        private List<string> _capabilities = new List<string>();
        private string _capabilitiesReason;
        private List<string> _declaredTransforms = new List<string>();
        private string _description;
        private List<TemplateParameter> _parameters = new List<TemplateParameter>();

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// The capabilities found within the template. If your template contains IAM resources,
        /// you must specify the CAPABILITY_IAM or CAPABILITY_NAMED_IAM value for this parameter
        /// when you use the <a>CreateStack</a> or <a>UpdateStack</a> actions with your template;
        /// otherwise, those actions return an InsufficientCapabilities error.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-iam-template.html#capabilities">Acknowledging
        /// IAM Resources in AWS CloudFormation Templates</a>.
        /// </para>
        /// </summary>
        public List<string> Capabilities
        {
            get { return this._capabilities; }
            set { this._capabilities = value; }
        }

        // Check to see if Capabilities property is set
        internal bool IsSetCapabilities()
        {
            return this._capabilities != null && this._capabilities.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CapabilitiesReason. 
        /// <para>
        /// The list of resources that generated the values in the <code>Capabilities</code> response
        /// element.
        /// </para>
        /// </summary>
        public string CapabilitiesReason
        {
            get { return this._capabilitiesReason; }
            set { this._capabilitiesReason = value; }
        }

        // Check to see if CapabilitiesReason property is set
        internal bool IsSetCapabilitiesReason()
        {
            return this._capabilitiesReason != null;
        }

        /// <summary>
        /// Gets and sets the property DeclaredTransforms. 
        /// <para>
        /// A list of the transforms that are declared in the template.
        /// </para>
        /// </summary>
        public List<string> DeclaredTransforms
        {
            get { return this._declaredTransforms; }
            set { this._declaredTransforms = value; }
        }

        // Check to see if DeclaredTransforms property is set
        internal bool IsSetDeclaredTransforms()
        {
            return this._declaredTransforms != null && this._declaredTransforms.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description found within the template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A list of <code>TemplateParameter</code> structures.
        /// </para>
        /// </summary>
        public List<TemplateParameter> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

    }
}