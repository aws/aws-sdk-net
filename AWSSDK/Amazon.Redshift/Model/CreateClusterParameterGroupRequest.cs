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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the CreateClusterParameterGroup operation.
    /// <para> Creates an Amazon Redshift parameter group. </para> <para>Creating parameter groups is independent of creating clusters. You can
    /// associate a cluster with a parameter group when you create the cluster. You can also associate an existing cluster with a parameter group
    /// after the cluster is created by using ModifyCluster. </para> <para> Parameters in the parameter group define specific behavior that applies
    /// to the databases you create on the cluster. For more information about managing parameter groups, go to Amazon Redshift Parameter Groups in
    /// the <i>Amazon Redshift Management Guide</i> .
    /// </para>
    /// </summary>
    /// <seealso cref="Amazon.Redshift.AmazonRedshift.CreateClusterParameterGroup"/>
    public class CreateClusterParameterGroupRequest : AmazonWebServiceRequest
    {
        private string parameterGroupName;
        private string parameterGroupFamily;
        private string description;

        /// <summary>
        /// The name of the cluster parameter group. Constraints: <ul> <li>Must be 1 to 255 alphanumeric characters or hyphens</li> <li>First character
        /// must be a letter.</li> <li>Cannot end with a hyphen or contain two consecutive hyphens.</li> <li>Must be unique withing your AWS
        /// account.</li> </ul> <note>This value is stored as a lower-case string.</note>
        ///  
        /// </summary>
        public string ParameterGroupName
        {
            get { return this.parameterGroupName; }
            set { this.parameterGroupName = value; }
        }

        /// <summary>
        /// Sets the ParameterGroupName property
        /// </summary>
        /// <param name="parameterGroupName">The value to set for the ParameterGroupName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateClusterParameterGroupRequest WithParameterGroupName(string parameterGroupName)
        {
            this.parameterGroupName = parameterGroupName;
            return this;
        }
            

        // Check to see if ParameterGroupName property is set
        internal bool IsSetParameterGroupName()
        {
            return this.parameterGroupName != null;
        }

        /// <summary>
        /// The Amazon Redshift engine version to which the cluster parameter group applies. The cluster engine version determines the set of
        /// parameters. To get a list of valid parameter group family names, you can call <a>DescribeClusterParameterGroups</a>. By default, Amazon
        /// Redshift returns a list of all the parameter groups that are owned by your AWS account, including the default parameter groups for each
        /// Amazon Redshift engine version. The parameter group family names associated with the default parameter groups provide you the valid values.
        /// For example, a valid family name is "redshift-1.0".
        ///  
        /// </summary>
        public string ParameterGroupFamily
        {
            get { return this.parameterGroupFamily; }
            set { this.parameterGroupFamily = value; }
        }

        /// <summary>
        /// Sets the ParameterGroupFamily property
        /// </summary>
        /// <param name="parameterGroupFamily">The value to set for the ParameterGroupFamily property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateClusterParameterGroupRequest WithParameterGroupFamily(string parameterGroupFamily)
        {
            this.parameterGroupFamily = parameterGroupFamily;
            return this;
        }
            

        // Check to see if ParameterGroupFamily property is set
        internal bool IsSetParameterGroupFamily()
        {
            return this.parameterGroupFamily != null;
        }

        /// <summary>
        /// A description of the parameter group.
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">The value to set for the Description property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateClusterParameterGroupRequest WithDescription(string description)
        {
            this.description = description;
            return this;
        }
            

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }
    }
}
    
