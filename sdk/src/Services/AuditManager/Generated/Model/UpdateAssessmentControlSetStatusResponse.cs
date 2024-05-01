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
    /// This is the response object from the UpdateAssessmentControlSetStatus operation.
    /// </summary>
    public partial class UpdateAssessmentControlSetStatusResponse : AmazonWebServiceResponse
    {
        private AssessmentControlSet _controlSet;

        /// <summary>
        /// Gets and sets the property ControlSet. 
        /// <para>
        ///  The name of the updated control set that the <c>UpdateAssessmentControlSetStatus</c>
        /// API returned. 
        /// </para>
        /// </summary>
        public AssessmentControlSet ControlSet
        {
            get { return this._controlSet; }
            set { this._controlSet = value; }
        }

        // Check to see if ControlSet property is set
        internal bool IsSetControlSet()
        {
            return this._controlSet != null;
        }

    }
}