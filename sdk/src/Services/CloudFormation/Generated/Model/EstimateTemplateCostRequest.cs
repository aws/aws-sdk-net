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
    /// Container for the parameters to the EstimateTemplateCost operation.
    /// Returns the estimated monthly cost of a template. The return value is an Amazon Web
    /// Services Simple Monthly Calculator URL with a query string that describes the resources
    /// required to run the template.
    /// </summary>
    public partial class EstimateTemplateCostRequest : AmazonCloudFormationRequest
    {
        private List<Parameter> _parameters = new List<Parameter>();
        private string _templateBody;
        private string _templateURL;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A list of <code>Parameter</code> structures that specify input parameters.
        /// </para>
        /// </summary>
        public List<Parameter> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TemplateBody. 
        /// <para>
        /// Structure containing the template body with a minimum length of 1 byte and a maximum
        /// length of 51,200 bytes. (For more information, go to <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/template-anatomy.html">Template
        /// Anatomy</a> in the CloudFormation User Guide.)
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must pass <code>TemplateBody</code> or <code>TemplateURL</code>.
        /// If both are passed, only <code>TemplateBody</code> is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string TemplateBody
        {
            get { return this._templateBody; }
            set { this._templateBody = value; }
        }

        // Check to see if TemplateBody property is set
        internal bool IsSetTemplateBody()
        {
            return this._templateBody != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateURL. 
        /// <para>
        /// Location of file containing the template body. The URL must point to a template that's
        /// located in an Amazon S3 bucket or a Systems Manager document. For more information,
        /// go to <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/template-anatomy.html">Template
        /// Anatomy</a> in the CloudFormation User Guide.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must pass <code>TemplateURL</code> or <code>TemplateBody</code>.
        /// If both are passed, only <code>TemplateBody</code> is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string TemplateURL
        {
            get { return this._templateURL; }
            set { this._templateURL = value; }
        }

        // Check to see if TemplateURL property is set
        internal bool IsSetTemplateURL()
        {
            return this._templateURL != null;
        }

    }
}