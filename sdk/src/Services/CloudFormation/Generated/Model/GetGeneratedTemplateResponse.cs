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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// This is the response object from the GetGeneratedTemplate operation.
    /// </summary>
    public partial class GetGeneratedTemplateResponse : AmazonWebServiceResponse
    {
        private GeneratedTemplateStatus _status;
        private string _templateBody;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the template generation. Supported values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CreatePending</c> - the creation of the template is pending.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CreateInProgress</c> - the creation of the template is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DeletePending</c> - the deletion of the template is pending.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DeleteInProgress</c> - the deletion of the template is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UpdatePending</c> - the update of the template is pending.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UpdateInProgress</c> - the update of the template is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Failed</c> - the template operation failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Complete</c> - the template operation is complete.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public GeneratedTemplateStatus Status
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
        /// Gets and sets the property TemplateBody. 
        /// <para>
        /// The template body of the generated template, in the language specified by the <c>Language</c>
        /// parameter.
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

    }
}