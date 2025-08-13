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
 * Do not modify this file. This file is generated from the security-ir-2018-05-10.normal.json service model.
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
namespace Amazon.SecurityIR.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateResolverType operation.
    /// Updates the resolver type for a case.
    /// 
    ///  <important> 
    /// <para>
    /// This is a one-way action and cannot be reversed.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class UpdateResolverTypeRequest : AmazonSecurityIRRequest
    {
        private string _caseId;
        private ResolverType _resolverType;

        /// <summary>
        /// Gets and sets the property CaseId. 
        /// <para>
        /// Required element for UpdateResolverType to identify the case to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=32)]
        public string CaseId
        {
            get { return this._caseId; }
            set { this._caseId = value; }
        }

        // Check to see if CaseId property is set
        internal bool IsSetCaseId()
        {
            return this._caseId != null;
        }

        /// <summary>
        /// Gets and sets the property ResolverType. 
        /// <para>
        /// Required element for UpdateResolverType to identify the new resolver.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResolverType ResolverType
        {
            get { return this._resolverType; }
            set { this._resolverType = value; }
        }

        // Check to see if ResolverType property is set
        internal bool IsSetResolverType()
        {
            return this._resolverType != null;
        }

    }
}