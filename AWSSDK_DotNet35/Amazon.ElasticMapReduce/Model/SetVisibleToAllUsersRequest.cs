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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the SetVisibleToAllUsers operation.
    /// <para>Sets whether all AWS Identity and Access Management (IAM) users under your account can access the specified job flows. This action
    /// works on running job flows. You can also set the visibility of a job flow when you launch it using the <c>VisibleToAllUsers</c> parameter of
    /// RunJobFlow. The SetVisibleToAllUsers action can be called only by an IAM user who created the job flow or the AWS account that owns the job
    /// flow.</para>
    /// </summary>
    public partial class SetVisibleToAllUsersRequest : AmazonElasticMapReduceRequest
    {
        private List<string> jobFlowIds = new List<string>();
        private bool? visibleToAllUsers;


        /// <summary>
        /// Identifiers of the job flows to receive the new visibility setting.
        ///  
        /// </summary>
        public List<string> JobFlowIds
        {
            get { return this.jobFlowIds; }
            set { this.jobFlowIds = value; }
        }

        // Check to see if JobFlowIds property is set
        internal bool IsSetJobFlowIds()
        {
            return this.jobFlowIds.Count > 0;
        }

        /// <summary>
        /// Whether the specified job flows are visible to all IAM users of the AWS account associated with the job flow. If this value is set to True,
        /// all IAM users of that AWS account can view and, if they have the proper IAM policy permissions set, manage the job flows. If it is set to
        /// False, only the IAM user that created a job flow can view and manage it.
        ///  
        /// </summary>
        public bool VisibleToAllUsers
        {
            get { return this.visibleToAllUsers ?? default(bool); }
            set { this.visibleToAllUsers = value; }
        }

        // Check to see if VisibleToAllUsers property is set
        internal bool IsSetVisibleToAllUsers()
        {
            return this.visibleToAllUsers.HasValue;
        }

    }
}
    
