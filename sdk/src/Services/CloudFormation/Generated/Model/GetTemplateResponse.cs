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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// The output for <a>GetTemplate</a> action.
    /// </summary>
    public partial class GetTemplateResponse : AmazonWebServiceResponse
    {
        private List<string> _stagesAvailable = new List<string>();
        private string _templateBody;

        /// <summary>
        /// Gets and sets the property StagesAvailable. 
        /// <para>
        /// The stage of the template that you can retrieve. For stacks, the <code>Original</code>
        /// and <code>Processed</code> templates are always available. For change sets, the <code>Original</code>
        /// template is always available. After AWS CloudFormation finishes creating the change
        /// set, the <code>Processed</code> template becomes available.
        /// </para>
        /// </summary>
        public List<string> StagesAvailable
        {
            get { return this._stagesAvailable; }
            set { this._stagesAvailable = value; }
        }

        // Check to see if StagesAvailable property is set
        internal bool IsSetStagesAvailable()
        {
            return this._stagesAvailable != null && this._stagesAvailable.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TemplateBody. 
        /// <para>
        /// Structure containing the template body. (For more information, go to <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/template-anatomy.html">Template
        /// Anatomy</a> in the AWS CloudFormation User Guide.)
        /// </para>
        ///  
        /// <para>
        /// AWS CloudFormation returns the same template that was used when the stack was created.
        /// </para>
        /// </summary>
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

    }
}