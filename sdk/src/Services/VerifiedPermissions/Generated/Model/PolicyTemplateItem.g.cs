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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// Contains details about a policy template
    /// 
    ///  
    /// <para>
    /// This data type is used as a response parameter for the <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_ListPolicyTemplates.html">ListPolicyTemplates</a>
    /// operation.
    /// </para>
    /// </summary>
    public partial class PolicyTemplateItem
    {
        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date and time that the policy template was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description attached to the policy template.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 150)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedDate. 
        /// <para>
        /// The date and time that the policy template was most recently updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastUpdatedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDate property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDate() => this.LastUpdatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the policy template, if one was assigned when the policy template was
        /// created or last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 150)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PolicyStoreId. 
        /// <para>
        /// The unique identifier of the policy store that contains the template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string PolicyStoreId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyStoreId property is set.
        /// </summary>
        internal bool IsSetPolicyStoreId() => this.PolicyStoreId != null;

        /// <summary>
        /// Gets and sets the property PolicyTemplateId. 
        /// <para>
        /// The unique identifier of the policy template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string PolicyTemplateId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyTemplateId property is set.
        /// </summary>
        internal bool IsSetPolicyTemplateId() => this.PolicyTemplateId != null;
    }
}
