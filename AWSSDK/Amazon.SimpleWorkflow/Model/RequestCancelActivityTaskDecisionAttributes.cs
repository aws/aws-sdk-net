/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// <para>Provides details of the <c>RequestCancelActivityTask</c> decision.</para> <para> <b>Access Control</b> </para> <para>You can use IAM
    /// policies to control this decision's access to Amazon SWF in much the same way as for the regular API:</para>
    /// <ul>
    /// <li>Use a <c>Resource</c> element with the domain name to limit the decision to only specified domains.</li>
    /// <li>Use an <c>Action</c> element to allow or deny permission to specify this decision.</li>
    /// <li>You cannot use an IAM policy to constrain this action's parameters.</li>
    /// 
    /// </ul>
    /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
    /// constraints, the action fails. The associated event attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
    /// and example IAM policies, see Using IAM to Manage Access to Amazon SWF Workflows.</para>
    /// </summary>
    public class RequestCancelActivityTaskDecisionAttributes
    {
        
        private string activityId;

        /// <summary>
        /// The <c>activityId</c> of the activity task to be canceled.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 256</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ActivityId
        {
            get { return this.activityId; }
            set { this.activityId = value; }
        }

        /// <summary>
        /// Sets the ActivityId property
        /// </summary>
        /// <param name="activityId">The value to set for the ActivityId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RequestCancelActivityTaskDecisionAttributes WithActivityId(string activityId)
        {
            this.activityId = activityId;
            return this;
        }
            

        // Check to see if ActivityId property is set
        internal bool IsSetActivityId()
        {
            return this.activityId != null;
        }
    }
}
