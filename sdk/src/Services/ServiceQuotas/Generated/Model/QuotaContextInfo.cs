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

namespace Amazon.ServiceQuotas.Model
{
    /// <summary>
    /// A structure that describes the context for a service quota. The context identifies
    /// what the quota applies to.
    /// </summary>
    public partial class QuotaContextInfo
    {
        private string _contextId;
        private QuotaContextScope _contextScope;
        private string _contextScopeType;

        /// <summary>
        /// Gets and sets the property ContextId. 
        /// <para>
        /// Specifies the Amazon Web Services account or resource to which the quota applies.
        /// The value in this field depends on the context scope associated with the specified
        /// service quota.
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
        /// Specifies whether the quota applies to an Amazon Web Services account, or to a resource.
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
        /// When the <code>ContextScope</code> is <code>RESOURCE</code>, then this specifies the
        /// resource type of the specified resource.
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