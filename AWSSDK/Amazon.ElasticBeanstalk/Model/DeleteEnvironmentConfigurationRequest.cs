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
    /// Container for the parameters to the DeleteEnvironmentConfiguration operation.
    /// <para> Deletes the draft configuration associated with the running environment. </para> <para> Updating a running environment with any
    /// configuration changes creates a draft configuration set. You can get the draft configuration using DescribeConfigurationSettings while the
    /// update is in progress or if the update fails. The <c>DeploymentStatus</c> for the draft configuration indicates whether the deployment is in
    /// process or has failed. The draft configuration remains in existence until it is deleted with this action. </para>
    /// </summary>
    /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.DeleteEnvironmentConfiguration"/>
    public class DeleteEnvironmentConfigurationRequest : AmazonWebServiceRequest
    {
        private string applicationName;
        private string environmentName;

        /// <summary>
        /// The name of the application the environment is associated with.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 100</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ApplicationName
        {
            get { return this.applicationName; }
            set { this.applicationName = value; }
        }

        /// <summary>
        /// Sets the ApplicationName property
        /// </summary>
        /// <param name="applicationName">The value to set for the ApplicationName property </param>
        /// <returns>this instance</returns>
        public DeleteEnvironmentConfigurationRequest WithApplicationName(string applicationName)
        {
            this.applicationName = applicationName;
            return this;
        }
            

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this.applicationName != null;       
        }

        /// <summary>
        /// The name of the environment to delete the draft configuration from.
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
        public DeleteEnvironmentConfigurationRequest WithEnvironmentName(string environmentName)
        {
            this.environmentName = environmentName;
            return this;
        }
            

        // Check to see if EnvironmentName property is set
        internal bool IsSetEnvironmentName()
        {
            return this.environmentName != null;       
        }
    }
}
    
