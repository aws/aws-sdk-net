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
    /// This is the response object from the StartAssessmentFrameworkShare operation.
    /// </summary>
    public partial class StartAssessmentFrameworkShareResponse : AmazonWebServiceResponse
    {
        private AssessmentFrameworkShareRequest _assessmentFrameworkShareRequest;

        /// <summary>
        /// Gets and sets the property AssessmentFrameworkShareRequest. 
        /// <para>
        ///  The share request that's created by the <c>StartAssessmentFrameworkShare</c> API.
        /// 
        /// </para>
        /// </summary>
        public AssessmentFrameworkShareRequest AssessmentFrameworkShareRequest
        {
            get { return this._assessmentFrameworkShareRequest; }
            set { this._assessmentFrameworkShareRequest = value; }
        }

        // Check to see if AssessmentFrameworkShareRequest property is set
        internal bool IsSetAssessmentFrameworkShareRequest()
        {
            return this._assessmentFrameworkShareRequest != null;
        }

    }
}