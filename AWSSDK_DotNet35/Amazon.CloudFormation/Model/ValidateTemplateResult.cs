/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.Runtime;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// <para>The output for ValidateTemplate action.</para>
    /// </summary>
    public partial class ValidateTemplateResult : AmazonWebServiceResponse
    {
        
        private List<TemplateParameter> parameters = new List<TemplateParameter>();
        private string description;
        private List<string> capabilities = new List<string>();
        private string capabilitiesReason;


        /// <summary>
        /// A list of <c>TemplateParameter</c> structures.
        ///  
        /// </summary>
        public List<TemplateParameter> Parameters
        {
            get { return this.parameters; }
            set { this.parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this.parameters.Count > 0;
        }

        /// <summary>
        /// The description found within the template.
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }

        /// <summary>
        /// The capabilities found within the template. Currently, CAPABILITY_IAM is the only capability detected. If your template contains IAM
        /// resources, you must specify the CAPABILITY_IAM value for this parameter when you use the <a>CreateStack</a> or <a>UpdateStack</a> actions
        /// with your template; otherwise, those actions return an InsufficientCapabilities error.
        ///  
        /// </summary>
        public List<string> Capabilities
        {
            get { return this.capabilities; }
            set { this.capabilities = value; }
        }

        // Check to see if Capabilities property is set
        internal bool IsSetCapabilities()
        {
            return this.capabilities.Count > 0;
        }

        /// <summary>
        /// The capabilities reason found within the template.
        ///  
        /// </summary>
        public string CapabilitiesReason
        {
            get { return this.capabilitiesReason; }
            set { this.capabilitiesReason = value; }
        }

        // Check to see if CapabilitiesReason property is set
        internal bool IsSetCapabilitiesReason()
        {
            return this.capabilitiesReason != null;
        }
    }
}
