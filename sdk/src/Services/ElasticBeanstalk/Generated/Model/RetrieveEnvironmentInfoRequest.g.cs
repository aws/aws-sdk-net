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
    /// Container for the parameters to the RetrieveEnvironmentInfo operation. Retrieves the
    /// compiled information from a <a>RequestEnvironmentInfo</a> request. <para> Related
    /// Topics </para> <ul> <li> <para> <a>RequestEnvironmentInfo</a> </para> </li> </ul>
    /// </summary>
    public partial class RetrieveEnvironmentInfoRequest : AmazonElasticBeanstalkRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public RetrieveEnvironmentInfoRequest() { }

        /// <summary>
        /// Instantiates RetrieveEnvironmentInfoRequest with the parameterized properties
        /// </summary>
        /// <param name="infoType">The type of information to retrieve.</param>
        public RetrieveEnvironmentInfoRequest(EnvironmentInfoType infoType)
        {
            this.InfoType = infoType;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The ID of the data's environment.
        /// </para>
        ///  
        /// <para>
        /// If no such environment is found, returns an <c>InvalidParameterValue</c> error.
        /// </para>
        ///  
        /// <para>
        /// Condition: You must specify either this or an EnvironmentName, or both. If you do
        /// not specify either, Elastic Beanstalk returns <c>MissingRequiredParameter</c> error.
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
        /// The name of the data's environment.
        /// </para>
        ///  
        /// <para>
        ///  If no such environment is found, returns an <c>InvalidParameterValue</c> error. 
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
        /// Gets and sets the property InfoType. 
        /// <para>
        /// The type of information to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EnvironmentInfoType InfoType { get; set; }

        /// <summary>
        /// Checks to see if the InfoType property is set.
        /// </summary>
        internal bool IsSetInfoType() => this.InfoType != null;
    }
}
