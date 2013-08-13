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
    /// <para>Result message containing a single description of an application.</para>
    /// </summary>
    public class UpdateApplicationResult  
    {
        
        private ApplicationDescription application;

        /// <summary>
        /// The <a>ApplicationDescription</a> of the application.
        ///  
        /// </summary>
        public ApplicationDescription Application
        {
            get { return this.application; }
            set { this.application = value; }
        }

        /// <summary>
        /// Sets the Application property
        /// </summary>
        /// <param name="application">The value to set for the Application property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateApplicationResult WithApplication(ApplicationDescription application)
        {
            this.application = application;
            return this;
        }
            

        // Check to see if Application property is set
        internal bool IsSetApplication()
        {
            return this.application != null;       
        }
    }
}
