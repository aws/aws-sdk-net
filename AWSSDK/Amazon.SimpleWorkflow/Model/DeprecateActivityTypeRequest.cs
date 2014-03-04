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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Container for the parameters to the DeprecateActivityType operation.
    /// <para> Deprecates the specified <i>activity type</i> .
    /// After an activity type has been deprecated, you cannot create new tasks of that activity type. Tasks of this type that were scheduled
    /// before the type was deprecated will continue to run. </para> <para><b>NOTE:</b> This operation is eventually consistent. The results are
    /// best effort and may not exactly reflect recent updates and changes. </para> <para> <b>Access Control</b> </para> <para>You can use IAM
    /// policies to control this action's access to Amazon SWF resources as follows:</para>
    /// <ul>
    /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains.</li>
    /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
    /// <li>Constrain the following parameters by using a <c>Condition</c> element with the appropriate keys.
    /// <ul>
    /// <li> <c>activityType.name</c> : String constraint. The key is <c>swf:activityType.name</c> .</li>
    /// <li> <c>activityType.version</c> : String constraint. The key is <c>swf:activityType.version</c> .</li>
    /// 
    /// </ul>
    /// </li>
    /// 
    /// </ul>
    /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
    /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see Using IAM to Manage
    /// Access to Amazon SWF Workflows.</para>
    /// </summary>
    /// <seealso cref="Amazon.SimpleWorkflow.AmazonSimpleWorkflow.DeprecateActivityType"/>
    public class DeprecateActivityTypeRequest : AmazonWebServiceRequest
    {
        private string domain;
        private ActivityType activityType;

        /// <summary>
        /// The name of the domain in which the activity type is registered.
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
        public string Domain
        {
            get { return this.domain; }
            set { this.domain = value; }
        }

        /// <summary>
        /// Sets the Domain property
        /// </summary>
        /// <param name="domain">The value to set for the Domain property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DeprecateActivityTypeRequest WithDomain(string domain)
        {
            this.domain = domain;
            return this;
        }
            

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this.domain != null;
        }

        /// <summary>
        /// The activity type to deprecate.
        ///  
        /// </summary>
        public ActivityType ActivityType
        {
            get { return this.activityType; }
            set { this.activityType = value; }
        }

        /// <summary>
        /// Sets the ActivityType property
        /// </summary>
        /// <param name="activityType">The value to set for the ActivityType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DeprecateActivityTypeRequest WithActivityType(ActivityType activityType)
        {
            this.activityType = activityType;
            return this;
        }
            

        // Check to see if ActivityType property is set
        internal bool IsSetActivityType()
        {
            return this.activityType != null;
        }
    }
}
    
