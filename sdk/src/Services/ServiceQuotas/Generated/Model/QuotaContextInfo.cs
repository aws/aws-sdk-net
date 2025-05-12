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
 * Do not modify this file. This file is generated from the service-quotas-2019-06-24.normal.json service model.
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
namespace Amazon.ServiceQuotas.Model
{
    /// <summary>
    /// A structure that describes the context for a resource-level quota. For resource-level
    /// quotas, such as <c>Instances per OpenSearch Service Domain</c>, you can apply the
    /// quota value at the resource-level for each OpenSearch Service Domain in your Amazon
    /// Web Services account. Together the attributes of this structure help you understand
    /// how the quota is implemented by Amazon Web Services and how you can manage it. For
    /// quotas such as <c>Amazon OpenSearch Service Domains</c> which can be managed at the
    /// account-level for each Amazon Web Services Region, the <c>QuotaContext</c> field is
    /// absent. See the attribute descriptions below to further understand how to use them.
    /// </summary>
    public partial class QuotaContextInfo
    {
        private string _contextId;
        private QuotaContextScope _contextScope;
        private string _contextScopeType;

        /// <summary>
        /// Gets and sets the property ContextId. 
        /// <para>
        /// Specifies the resource, or resources, to which the quota applies. The value for this
        /// field is either an Amazon Resource Name (ARN) or *. If the value is an ARN, the quota
        /// value applies to that resource. If the value is *, then the quota value applies to
        /// all resources listed in the <c>ContextScopeType</c> field. The quota value applies
        /// to all resources for which you haven’t previously applied a quota value, and any new
        /// resources you create in your Amazon Web Services account.
        /// </para>
        /// </summary>
        public string ContextId
        {
            get { return this._contextId; }
            set { this._contextId = value; }
        }

        // Check to see if ContextId property is set
        internal bool IsSetContextId()
        {
            return this._contextId != null;
        }

        /// <summary>
        /// Gets and sets the property ContextScope. 
        /// <para>
        /// Specifies the scope to which the quota value is applied. If the scope is <c>RESOURCE</c>,
        /// the quota value is applied to each resource in the Amazon Web Services account. If
        /// the scope is <c>ACCOUNT</c>, the quota value is applied to the Amazon Web Services
        /// account.
        /// </para>
        /// </summary>
        public QuotaContextScope ContextScope
        {
            get { return this._contextScope; }
            set { this._contextScope = value; }
        }

        // Check to see if ContextScope property is set
        internal bool IsSetContextScope()
        {
            return this._contextScope != null;
        }

        /// <summary>
        /// Gets and sets the property ContextScopeType. 
        /// <para>
        /// Specifies the resource type to which the quota can be applied.
        /// </para>
        /// </summary>
        public string ContextScopeType
        {
            get { return this._contextScopeType; }
            set { this._contextScopeType = value; }
        }

        // Check to see if ContextScopeType property is set
        internal bool IsSetContextScopeType()
        {
            return this._contextScopeType != null;
        }

    }
}