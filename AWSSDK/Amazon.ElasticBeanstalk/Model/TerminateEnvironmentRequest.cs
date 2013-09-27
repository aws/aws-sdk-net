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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Container for the parameters to the TerminateEnvironment operation.
    /// <para> Terminates the specified environment. </para>
    /// </summary>
    /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.TerminateEnvironment"/>
    public class TerminateEnvironmentRequest : AmazonWebServiceRequest
    {
        private string environmentId;
        private string environmentName;
        private bool? terminateResources;

        /// <summary>
        /// The ID of the environment to terminate. Condition: You must specify either this or an EnvironmentName, or both. If you do not specify
        /// either, AWS Elastic Beanstalk returns <c>MissingRequiredParameter</c> error.
        ///  
        /// </summary>
        public string EnvironmentId
        {
            get { return this.environmentId; }
            set { this.environmentId = value; }
        }

        /// <summary>
        /// Sets the EnvironmentId property
        /// </summary>
        /// <param name="environmentId">The value to set for the EnvironmentId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TerminateEnvironmentRequest WithEnvironmentId(string environmentId)
        {
            this.environmentId = environmentId;
            return this;
        }
            

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this.environmentId != null;       
        }

        /// <summary>
        /// The name of the environment to terminate. Condition: You must specify either this or an EnvironmentId, or both. If you do not specify
        /// either, AWS Elastic Beanstalk returns <c>MissingRequiredParameter</c> error.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>4 - 23</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string EnvironmentName
        {
            get { return this.environmentName; }
            set { this.environmentName = value; }
        }

        /// <summary>
        /// Sets the EnvironmentName property
        /// </summary>
        /// <param name="environmentName">The value to set for the EnvironmentName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TerminateEnvironmentRequest WithEnvironmentName(string environmentName)
        {
            this.environmentName = environmentName;
            return this;
        }
            

        // Check to see if EnvironmentName property is set
        internal bool IsSetEnvironmentName()
        {
            return this.environmentName != null;       
        }

        /// <summary>
        /// Indicates whether the associated AWS resources should shut down when the environment is terminated: <enumValues> <value name="true">
        /// <c>true</c>: (default) The user AWS resources (for example, the Auto Scaling group, LoadBalancer, etc.) are terminated along with the
        /// environment. </value> <value name="false"> <c>false</c>: The environment is removed from the AWS Elastic Beanstalk but the AWS resources
        /// continue to operate. </value> </enumValues> <ul> <li> <c>true</c>: The specified environment as well as the associated AWS resources, such
        /// as Auto Scaling group and LoadBalancer, are terminated. </li> <li> <c>false</c>: AWS Elastic Beanstalk resource management is removed from
        /// the environment, but the AWS resources continue to operate. </li> </ul> For more information, see the <a
        /// href="http://docs.amazonwebservices.com/elasticbeanstalk/latest/ug/"> AWS Elastic Beanstalk User Guide. </a> Default: <c>true</c> Valid
        /// Values: <c>true</c> | <c>false</c>
        ///  
        /// </summary>
        public bool TerminateResources
        {
            get { return this.terminateResources ?? default(bool); }
            set { this.terminateResources = value; }
        }

        /// <summary>
        /// Sets the TerminateResources property
        /// </summary>
        /// <param name="terminateResources">The value to set for the TerminateResources property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TerminateEnvironmentRequest WithTerminateResources(bool terminateResources)
        {
            this.terminateResources = terminateResources;
            return this;
        }
            

        // Check to see if TerminateResources property is set
        internal bool IsSetTerminateResources()
        {
            return this.terminateResources.HasValue;       
        }
    }
}
    
