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
    /// Container for the parameters to the DeleteTemplate operation.
    /// Deletes a cases template. You can delete up to 100 templates per domain.
    /// 
    ///  
    /// <para>
    /// After a cases template is deleted:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You can still retrieve the template by calling <c>GetTemplate</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You cannot update the template. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You cannot create a case by using the deleted template.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Deleted templates are not included in the <c>ListTemplates</c> response.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DeleteTemplateRequest : AmazonConnectCasesRequest
    {
        private string _domainId;
        private string _templateId;

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