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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
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
    /// Container for the parameters to the RequestEnvironmentInfo operation.
    /// Initiates a request to compile the specified type of information of the deployed environment.
    /// 
    ///  
    /// <para>
    ///  Setting the <c>InfoType</c> to <c>tail</c> compiles the last lines from the application
    /// server log files of every Amazon EC2 instance in your environment. 
    /// </para>
    ///  
    /// <para>
    ///  Setting the <c>InfoType</c> to <c>bundle</c> compresses the application server log
    /// files for every Amazon EC2 instance into a <c>.zip</c> file. Legacy and .NET containers
    /// do not support bundle logs. 
    /// </para>
    ///  
    /// <para>
    ///  Use <a>RetrieveEnvironmentInfo</a> to obtain the set of logs. 
    /// </para>
    ///  
    /// <para>
    /// Related Topics
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>RetrieveEnvironmentInfo</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class RequestEnvironmentInfoRequest : AmazonElasticBeanstalkRequest
    {
        private string _environmentId;
        private string _environmentName;
        private EnvironmentInfoType _infoType;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public RequestEnvironmentInfoRequest() { }

        /// <summary>
        /// Instantiates RequestEnvironmentInfoRequest with the parameterized properties
        /// </summary>
        /// <param name="infoType">The type of information to request.</param>
        public RequestEnvironmentInfoRequest(EnvironmentInfoType infoType)
        {
            _infoType = infoType;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The ID of the environment of the requested data.
        /// </para>
        ///  
        /// <para>
        /// If no such environment is found, <c>RequestEnvironmentInfo</c> returns an <c>InvalidParameterValue</c>
        /// error. 
        /// </para>
        ///  
        /// <para>
        /// Condition: You must specify either this or an EnvironmentName, or both. If you do
        /// not specify either, AWS Elastic Beanstalk returns <c>MissingRequiredParameter</c>
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
        /// If no such environment is found, <c>RequestEnvironmentInfo</c> returns an <c>InvalidParameterValue</c>
        /// error. 
        /// </para>
        ///  
        /// <para>
        /// Condition: You must specify either this or an EnvironmentId, or both. If you do not
        /// specify either, AWS Elastic Beanstalk returns <c>MissingRequiredParameter</c> error.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=40)]
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
        /// The type of information to request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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