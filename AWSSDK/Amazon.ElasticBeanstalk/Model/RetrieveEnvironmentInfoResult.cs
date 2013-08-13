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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// <para>Result message containing a description of the requested environment info.</para>
    /// </summary>
    public class RetrieveEnvironmentInfoResult  
    {
        
        private List<EnvironmentInfoDescription> environmentInfo = new List<EnvironmentInfoDescription>();

        /// <summary>
        /// The <a>EnvironmentInfoDescription</a> of the environment.
        ///  
        /// </summary>
        public List<EnvironmentInfoDescription> EnvironmentInfo
        {
            get { return this.environmentInfo; }
            set { this.environmentInfo = value; }
        }
        /// <summary>
        /// Adds elements to the EnvironmentInfo collection
        /// </summary>
        /// <param name="environmentInfo">The values to add to the EnvironmentInfo collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RetrieveEnvironmentInfoResult WithEnvironmentInfo(params EnvironmentInfoDescription[] environmentInfo)
        {
            foreach (EnvironmentInfoDescription element in environmentInfo)
            {
                this.environmentInfo.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the EnvironmentInfo collection
        /// </summary>
        /// <param name="environmentInfo">The values to add to the EnvironmentInfo collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RetrieveEnvironmentInfoResult WithEnvironmentInfo(IEnumerable<EnvironmentInfoDescription> environmentInfo)
        {
            foreach (EnvironmentInfoDescription element in environmentInfo)
            {
                this.environmentInfo.Add(element);
            }

            return this;
        }

        // Check to see if EnvironmentInfo property is set
        internal bool IsSetEnvironmentInfo()
        {
            return this.environmentInfo.Count > 0;       
        }
    }
}
