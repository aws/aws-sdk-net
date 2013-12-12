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
    /// Container for the parameters to the RetrieveEnvironmentInfo operation.
    /// <para> Retrieves the compiled information from a RequestEnvironmentInfo request. </para> <para>Related Topics</para>
    /// <ul>
    /// <li> RequestEnvironmentInfo </li>
    /// 
    /// </ul>
    /// </summary>
    public partial class RetrieveEnvironmentInfoRequest : AmazonElasticBeanstalkRequest
    {
        private string environmentId;
        private string environmentName;
        private EnvironmentInfoType infoType;


        /// <summary>
        /// The ID of the data's environment. If no such environment is found, returns an <c>InvalidParameterValue</c> error. Condition: You must
        /// specify either this or an EnvironmentName, or both. If you do not specify either, AWS Elastic Beanstalk returns
        /// <c>MissingRequiredParameter</c> error.
        ///  
        /// </summary>
        public string EnvironmentId
        {
            get { return this.environmentId; }
            set { this.environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this.environmentId != null;
        }

        /// <summary>
        /// The name of the data's environment. If no such environment is found, returns an <c>InvalidParameterValue</c> error. Condition: You must
        /// specify either this or an EnvironmentId, or both. If you do not specify either, AWS Elastic Beanstalk returns
        /// <c>MissingRequiredParameter</c> error.
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

        // Check to see if EnvironmentName property is set
        internal bool IsSetEnvironmentName()
        {
            return this.environmentName != null;
        }

        /// <summary>
        /// The type of information to retrieve.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>tail</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public EnvironmentInfoType InfoType
        {
            get { return this.infoType; }
            set { this.infoType = value; }
        }

        // Check to see if InfoType property is set
        internal bool IsSetInfoType()
        {
            return this.infoType != null;
        }

    }
}
    
