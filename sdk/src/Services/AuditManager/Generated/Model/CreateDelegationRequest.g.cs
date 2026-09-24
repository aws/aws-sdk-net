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

namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// A collection of attributes that's used to create a delegation for an assessment in
    /// Audit Manager.
    /// </summary>
    public partial class CreateDelegationRequest
    {
        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        ///  A comment that's related to the delegation request. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 350)]
        public string Comment { get; set; }

        /// <summary>
        /// Checks to see if the Comment property is set.
        /// </summary>
        internal bool IsSetComment() => this.Comment != null;

        /// <summary>
        /// Gets and sets the property ControlSetId. 
        /// <para>
        ///  The unique identifier for the control set. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public string ControlSetId { get; set; }

        /// <summary>
        /// Checks to see if the ControlSetId property is set.
        /// </summary>
        internal bool IsSetControlSetId() => this.ControlSetId != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the IAM role. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property RoleType. 
        /// <para>
        ///  The type of customer persona. 
        /// </para>
        ///  <note> 
        /// <para>
        /// In <c>CreateAssessment</c>, <c>roleType</c> can only be <c>PROCESS_OWNER</c>. 
        /// </para>
        ///  
        /// <para>
        /// In <c>UpdateSettings</c>, <c>roleType</c> can only be <c>PROCESS_OWNER</c>.
        /// </para>
        ///  
        /// <para>
        /// In <c>BatchCreateDelegationByAssessment</c>, <c>roleType</c> can only be <c>RESOURCE_OWNER</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public RoleType RoleType { get; set; }

        /// <summary>
        /// Checks to see if the RoleType property is set.
        /// </summary>
        internal bool IsSetRoleType() => this.RoleType != null;
    }
}
