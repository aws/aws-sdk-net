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
    /// Container for the parameters to the RequestEnvironmentInfo operation.
    /// Initiates a request to compile the specified type of         information
    /// of the deployed environment.      
    /// 
    ///       
    /// <para>
    ///          Setting the <code>InfoType</code> to <code>tail</code>         compiles the
    /// last lines from the application server log files of every         Amazon EC2 instance
    /// in your environment. Use <a>RetrieveEnvironmentInfo</a>         to access the compiled
    /// information.      
    /// </para>
    ///        
    /// <para>
    /// Related Topics
    /// </para>
    ///       <ul>                <li>            <a>RetrieveEnvironmentInfo</a>         </li>
    ///      </ul>
    /// </summary>
    public partial class RequestEnvironmentInfoRequest : AmazonElasticBeanstalkRequest
    {
        private string _environmentId;
        private string _environmentName;
        private EnvironmentInfoType _infoType;


        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The ID of the environment of the requested data.
        /// </para>
        ///       
        /// <para>
        ///          If no such environment is found, <code>RequestEnvironmentInfo</code> returns
        /// an         <code>InvalidParameterValue</code>         error.      
        /// </para>
        ///        
        /// <para>
        ///          Condition: You must specify either this or an EnvironmentName, or both. 
        ///          If you do not specify either, AWS Elastic Beanstalk returns <code>MissingRequiredParameter</code>
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
        /// The name of the environment of the requested data.
        /// </para>
        ///       
        /// <para>
        ///          If no such environment is found, <code>RequestEnvironmentInfo</code> returns
        /// an         <code>InvalidParameterValue</code>         error.      
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
        /// Gets and sets the property InfoType. 
        /// <para>
        ///          The type of information to request.       
        /// </para>
        /// </summary>
        public EnvironmentInfoType InfoType
        {
            get { return this._infoType; }
            set { this._infoType = value; }
        }

        // Check to see if InfoType property is set
        internal bool IsSetInfoType()
        {
            return this._infoType != null;
        }

    }
}