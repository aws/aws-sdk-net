/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> Result message wrapping a single description of an application version. </para>
    /// </summary>
    public class CreateApplicationVersionResult  
    {
        
        private ApplicationVersionDescription applicationVersion;

        /// <summary>
        /// The <a>ApplicationVersionDescription</a> of the application version.
        ///  
        /// </summary>
        public ApplicationVersionDescription ApplicationVersion
        {
            get { return this.applicationVersion; }
            set { this.applicationVersion = value; }
        }

        /// <summary>
        /// Sets the ApplicationVersion property
        /// </summary>
        /// <param name="applicationVersion">The value to set for the ApplicationVersion property </param>
        /// <returns>this instance</returns>
        public CreateApplicationVersionResult WithApplicationVersion(ApplicationVersionDescription applicationVersion)
        {
            this.applicationVersion = applicationVersion;
            return this;
        }
            

        // Check to see if ApplicationVersion property is set
        internal bool IsSetApplicationVersion()
        {
            return this.applicationVersion != null;       
        }
    }
}
