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

namespace Amazon.SecurityIR.Model
{
    /// <summary>
    /// This is the response object from the UpdateResolverType operation.
    /// </summary>
    public partial class UpdateResolverTypeResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CaseId. 
        /// <para>
        /// Response element for UpdateResolver identifying the case ID being updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 32)]
        public string CaseId { get; set; }

        /// <summary>
        /// Checks to see if the CaseId property is set.
        /// </summary>
        internal bool IsSetCaseId() => this.CaseId != null;

        /// <summary>
        /// Gets and sets the property CaseStatus. 
        /// <para>
        /// Response element for UpdateResolver identifying the current status of the case.
        /// </para>
        /// </summary>
        public CaseStatus CaseStatus { get; set; }

        /// <summary>
        /// Checks to see if the CaseStatus property is set.
        /// </summary>
        internal bool IsSetCaseStatus() => this.CaseStatus != null;

        /// <summary>
        /// Gets and sets the property ResolverType. 
        /// <para>
        /// Response element for UpdateResolver identifying the current resolver of the case.
        /// </para>
        /// </summary>
        public ResolverType ResolverType { get; set; }

        /// <summary>
        /// Checks to see if the ResolverType property is set.
        /// </summary>
        internal bool IsSetResolverType() => this.ResolverType != null;
    }
}
