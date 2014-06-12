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
    /// Container for the parameters to the DeleteEnvironmentConfiguration operation.
    /// Deletes the draft configuration associated with the running environment.        
    /// 
    ///       
    /// <para>
    ///          Updating a running environment with any configuration changes creates a 
    ///        draft configuration set. You can get the draft configuration using        
    /// <a>DescribeConfigurationSettings</a> while the update is in progress          or if
    /// the update fails. The <code>DeploymentStatus</code> for the draft          configuration
    /// indicates whether the deployment is in process or has failed.         The draft configuration
    /// remains in existence until it is deleted with this action.      
    /// </para>
    /// </summary>
    public partial class DeleteEnvironmentConfigurationRequest : AmazonElasticBeanstalkRequest
    {
        private string _applicationName;
        private string _environmentName;


        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        ///          The name of the application the environment is associated with.        
        /// </para>
        /// </summary>
        public string ApplicationName
        {
            get { return this._applicationName; }
            set { this._applicationName = value; }
        }

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this._applicationName != null;
        }


        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        ///          The name of the environment to delete the draft configuration from.        
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

    }
}