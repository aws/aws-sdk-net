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
    /// Result message wrapping a single description of an application         version.
    /// </summary>
    public partial class UpdateApplicationVersionResult
    {
        private ApplicationVersionDescription _applicationVersion;


        /// <summary>
        /// Gets and sets the property ApplicationVersion. 
        /// <para>
        ///          The         <a>ApplicationVersionDescription</a>         of the application
        /// version.      
        /// </para>
        /// </summary>
        public ApplicationVersionDescription ApplicationVersion
        {
            get { return this._applicationVersion; }
            set { this._applicationVersion = value; }
        }


        /// <summary>
        /// Sets the ApplicationVersion property
        /// </summary>
        /// <param name="applicationVersion">The value to set for the ApplicationVersion property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateApplicationVersionResult WithApplicationVersion(ApplicationVersionDescription applicationVersion)
        {
            this._applicationVersion = applicationVersion;
            return this;
        }

        // Check to see if ApplicationVersion property is set
        internal bool IsSetApplicationVersion()
        {
            return this._applicationVersion != null;
        }

    }
}