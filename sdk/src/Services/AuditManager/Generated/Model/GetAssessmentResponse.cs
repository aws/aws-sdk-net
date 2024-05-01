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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
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
namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// This is the response object from the GetAssessment operation.
    /// </summary>
    public partial class GetAssessmentResponse : AmazonWebServiceResponse
    {
        private Assessment _assessment;
        private Role _userRole;

        /// <summary>
        /// Gets and sets the property Assessment.
        /// </summary>
        public Assessment Assessment
        {
            get { return this._assessment; }
            set { this._assessment = value; }
        }

        // Check to see if Assessment property is set
        internal bool IsSetAssessment()
        {
            return this._assessment != null;
        }

        /// <summary>
        /// Gets and sets the property UserRole.
        /// </summary>
        public Role UserRole
        {
            get { return this._userRole; }
            set { this._userRole = value; }
        }

        // Check to see if UserRole property is set
        internal bool IsSetUserRole()
        {
            return this._userRole != null;
        }

    }
}