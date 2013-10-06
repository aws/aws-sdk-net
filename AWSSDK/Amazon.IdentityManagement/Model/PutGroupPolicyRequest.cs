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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the PutGroupPolicy operation.
    /// <para>Adds (or updates) a policy document associated with the specified group. For information about policies, refer to Overview of Policies
    /// in <i>Using AWS Identity and Access Management</i> .</para> <para>For information about limits on the number of policies you can associate
    /// with a group, see Limitations on IAM Entities in <i>Using AWS Identity and Access Management</i> .</para> <para><b>NOTE:</b>Because policy
    /// documents can be large, you should use POST rather than GET when calling PutGroupPolicy. For information about setting up signatures and
    /// authorization through the API, go to Signing AWS API Requests in the AWS General Reference. For general information about using the Query
    /// API with IAM, go to Making Query Requests in Using IAM.</para>
    /// </summary>
    /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.PutGroupPolicy"/>
    public class PutGroupPolicyRequest : AmazonWebServiceRequest
    {
        private string groupName;
        private string policyName;
        private string policyDocument;

        /// <summary>
        /// Name of the group to associate the policy with.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 128</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\w+=,.@-]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string GroupName
        {
            get { return this.groupName; }
            set { this.groupName = value; }
        }

        /// <summary>
        /// Sets the GroupName property
        /// </summary>
        /// <param name="groupName">The value to set for the GroupName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutGroupPolicyRequest WithGroupName(string groupName)
        {
            this.groupName = groupName;
            return this;
        }
            

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this.groupName != null;       
        }

        /// <summary>
        /// Name of the policy document.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 128</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\w+=,.@-]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string PolicyName
        {
            get { return this.policyName; }
            set { this.policyName = value; }
        }

        /// <summary>
        /// Sets the PolicyName property
        /// </summary>
        /// <param name="policyName">The value to set for the PolicyName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutGroupPolicyRequest WithPolicyName(string policyName)
        {
            this.policyName = policyName;
            return this;
        }
            

        // Check to see if PolicyName property is set
        internal bool IsSetPolicyName()
        {
            return this.policyName != null;       
        }

        /// <summary>
        /// The policy document.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 131072</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0009\u000A\u000D\u0020-\u00FF]+</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string PolicyDocument
        {
            get { return this.policyDocument; }
            set { this.policyDocument = value; }
        }

        /// <summary>
        /// Sets the PolicyDocument property
        /// </summary>
        /// <param name="policyDocument">The value to set for the PolicyDocument property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutGroupPolicyRequest WithPolicyDocument(string policyDocument)
        {
            this.policyDocument = policyDocument;
            return this;
        }
            

        // Check to see if PolicyDocument property is set
        internal bool IsSetPolicyDocument()
        {
            return this.policyDocument != null;       
        }
    }
}
    
