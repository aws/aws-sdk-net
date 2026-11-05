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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Container for the parameters to the TerminateEnvironment operation. Terminates the
    /// specified environment.
    /// </summary>
    public partial class TerminateEnvironmentRequest : AmazonElasticBeanstalkRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public TerminateEnvironmentRequest() { }

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The ID of the environment to terminate.
        /// </para>
        ///  
        /// <para>
        ///  Condition: You must specify either this or an EnvironmentName, or both. If you do
        /// not specify either, Elastic Beanstalk returns <c>MissingRequiredParameter</c> error.
        /// 
        /// </para>
        /// </summary>
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentId property is set.
        /// </summary>
        internal bool IsSetEnvironmentId() => this.EnvironmentId != null;

        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The name of the environment to terminate.
        /// </para>
        ///  
        /// <para>
        ///  Condition: You must specify either this or an EnvironmentId, or both. If you do not
        /// specify either, Elastic Beanstalk returns <c>MissingRequiredParameter</c> error. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 40)]
        public string EnvironmentName { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentName property is set.
        /// </summary>
        internal bool IsSetEnvironmentName() => this.EnvironmentName != null;

        /// <summary>
        /// Gets and sets the property ForceTerminate. 
        /// <para>
        /// Terminates the target environment even if another environment in the same group is
        /// dependent on it.
        /// </para>
        /// </summary>
        public bool? ForceTerminate { get; set; }

        /// <summary>
        /// Checks to see if the ForceTerminate property is set.
        /// </summary>
        internal bool IsSetForceTerminate() => this.ForceTerminate.HasValue;

        /// <summary>
        /// Gets and sets the property TerminateResources. 
        /// <para>
        /// Indicates whether the associated Amazon Web Services resources should shut down when
        /// the environment is terminated:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>true</c>: The specified environment as well as the associated Amazon Web Services
        /// resources, such as Auto Scaling group and LoadBalancer, are terminated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>false</c>: Elastic Beanstalk resource management is removed from the environment,
        /// but the Amazon Web Services resources continue to operate.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  For more information, see the <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/ug/">
        /// Elastic Beanstalk User Guide. </a> 
        /// </para>
        ///  
        /// <para>
        ///  Default: <c>true</c> 
        /// </para>
        ///  
        /// <para>
        ///  Valid Values: <c>true</c> | <c>false</c> 
        /// </para>
        /// </summary>
        public bool? TerminateResources { get; set; }

        /// <summary>
        /// Checks to see if the TerminateResources property is set.
        /// </summary>
        internal bool IsSetTerminateResources() => this.TerminateResources.HasValue;
    }
}
