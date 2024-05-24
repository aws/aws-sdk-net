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
 * Do not modify this file. This file is generated from the verifiedpermissions-2021-12-01.normal.json service model.
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
    /// An authorization request that you include in a <c>BatchIsAuthorizedWithToken</c> API
    /// request.
    /// </summary>
    public partial class BatchIsAuthorizedWithTokenInputItem
    {
        private ActionIdentifier _action;
        private ContextDefinition _context;
        private EntityIdentifier _resource;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Specifies the requested action to be authorized. For example, <c>PhotoFlash::ReadPhoto</c>.
        /// </para>
        /// </summary>
        public ActionIdentifier Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        /// Specifies additional context that can be used to make more granular authorization
        /// decisions.
        /// </para>
        /// </summary>
        public ContextDefinition Context
        {
            get { return this._context; }
            set { this._context = value; }
        }

        // Check to see if Context property is set
        internal bool IsSetContext()
        {
            return this._context != null;
        }

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// Specifies the resource that you want an authorization decision for. For example, <c>PhotoFlash::Photo</c>.
        /// </para>
        /// </summary>
        public EntityIdentifier Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null;
        }

    }
}