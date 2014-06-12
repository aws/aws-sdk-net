/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Terminates the specified environment.
    /// </summary>
    public partial class TerminateEnvironmentRequest : AmazonElasticBeanstalkRequest
    {
        private string _environmentId;
        private string _environmentName;
        private bool? _terminateResources;


        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The ID of the environment to terminate.
        /// </para>
        ///        
        /// <para>
        ///          Condition: You must specify either this or an EnvironmentName, or both. If
        /// you do not specify either, AWS Elastic Beanstalk returns <code>MissingRequiredParameter</code>
        /// error.        
        /// </para>
        /// </summary>
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }


        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The name of the environment to terminate.
        /// </para>
        ///        
        /// <para>
        ///          Condition: You must specify either this or an EnvironmentId, or both.   
        ///        If you do not specify either, AWS Elastic Beanstalk returns <code>MissingRequiredParameter</code>
        /// error.        
        /// </para>
        /// </summary>
        public string EnvironmentName
        {
            get { return this._environmentName; }
            set { this._environmentName = value; }
        }

        // Check to see if EnvironmentName property is set
        internal bool IsSetEnvironmentName()
        {
            return this._environmentName != null;
        }


        /// <summary>
        /// Gets and sets the property TerminateResources. 
        /// <para>
        ///          Indicates whether the associated AWS resources should shut down         when
        /// the environment is terminated:        
        /// </para>
        ///       <enumValues>         <value name="true">            
        /// <para>
        ///                <code>true</code>: (default) The user AWS resources               (for
        /// example, the Auto Scaling group, LoadBalancer, etc.) are terminated              
        /// along with the environment.            
        /// </para>
        ///          </value>         <value name="false">            
        /// <para>
        ///                <code>false</code>:               The environment is removed from the                    AWS
        /// Elastic Beanstalk               but the AWS resources continue to operate.       
        ///     
        /// </para>
        ///          </value>      </enumValues>      <ul>         <li>            <code>true</code>:
        /// The specified environment as well as the associated            AWS resources, such
        /// as Auto Scaling group and LoadBalancer, are terminated.         </li>         <li>
        ///            <code>false</code>: AWS Elastic Beanstalk            resource management
        /// is removed from the            environment, but the AWS resources continue to operate.
        ///         </li>      </ul>      
        /// <para>
        ///          For more information, see the         <a href="http://docs.aws.amazon.com/elasticbeanstalk/latest/ug/">
        ///      AWS Elastic Beanstalk            User Guide.         </a>      
        /// </para>
        ///       
        /// <para>
        ///          Default:         <code>true</code>      
        /// </para>
        ///       
        /// <para>
        ///          Valid Values:         <code>true</code>         |         <code>false</code>
        ///      
        /// </para>
        /// </summary>
        public bool TerminateResources
        {
            get { return this._terminateResources.GetValueOrDefault(); }
            set { this._terminateResources = value; }
        }

        // Check to see if TerminateResources property is set
        internal bool IsSetTerminateResources()
        {
            return this._terminateResources.HasValue; 
        }

    }
}