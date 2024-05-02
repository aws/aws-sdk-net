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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Container for the parameters to the GetProfileObjectTypeTemplate operation.
    /// Returns the template information for a specific object type.
    /// 
    ///  
    /// <para>
    /// A template is a predefined ProfileObjectType, such as “Salesforce-Account” or “Salesforce-Contact.”
    /// When a user sends a ProfileObject, using the PutProfileObject API, with an ObjectTypeName
    /// that matches one of the TemplateIds, it uses the mappings from the template.
    /// </para>
    /// </summary>
    public partial class GetProfileObjectTypeTemplateRequest : AmazonCustomerProfilesRequest
    {
        private string _templateId;

        /// <summary>
        /// Gets and sets the property TemplateId. 
        /// <para>
        /// A unique identifier for the object template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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