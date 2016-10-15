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

/*
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
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
    /// Container for the parameters to the RetrieveEnvironmentInfo operation.
    /// Retrieves the compiled information from a <a>RequestEnvironmentInfo</a> request.
    /// 
    ///  
    /// <para>
    /// Related Topics
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>RequestEnvironmentInfo</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class RetrieveEnvironmentInfoRequest : AmazonElasticBeanstalkRequest
    {
        private string _environmentId;
        private string _environmentName;
        private EnvironmentInfoType _infoType;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public RetrieveEnvironmentInfoRequest() { }

        /// <summary>
        /// Instantiates RetrieveEnvironmentInfoRequest with the parameterized properties
        /// </summary>
        /// <param name="infoType">The type of information to retrieve.</param>
        public RetrieveEnvironmentInfoRequest(EnvironmentInfoType infoType)
        {
            _infoType = infoType;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The ID of the data's environment.
        /// </para>
        ///  
        /// <para>
        /// If no such environment is found, returns an <code>InvalidParameterValue</code> error.
        /// </para>
        ///  
        /// <para>
        /// Condition: You must specify either this or an EnvironmentName, or both. If you do
        /// not specify either, AWS Elastic Beanstalk returns <code>MissingRequiredParameter</code>
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
        /// The name of the data's environment.
        /// </para>
        ///  
        /// <para>
        ///  If no such environment is found, returns an <code>InvalidParameterValue</code> error.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  Condition: You must specify either this or an EnvironmentId, or both. If you do not
        /// specify either, AWS Elastic Beanstalk returns <code>MissingRequiredParameter</code>
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
        /// The type of information to retrieve.
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