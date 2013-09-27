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
    /// Container for the parameters to the CreateApplicationVersion operation.
    /// <para>Creates an application version for the specified application.</para> <para><b>NOTE:</b>Once you create an application version with a
    /// specified Amazon S3 bucket and key location, you cannot change that Amazon S3 location. If you change the Amazon S3 location, you receive an
    /// exception when you attempt to launch an environment from the application version. </para>
    /// </summary>
    /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.CreateApplicationVersion"/>
    public class CreateApplicationVersionRequest : AmazonWebServiceRequest
    {
        private string applicationName;
        private string versionLabel;
        private string description;
        private S3Location sourceBundle;
        private bool? autoCreateApplication;

        /// <summary>
        /// The name of the application. If no application is found with this name, and <c>AutoCreateApplication</c> is <c>false</c>, returns an
        /// <c>InvalidParameterValue</c> error.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 100</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ApplicationName
        {
            get { return this.applicationName; }
            set { this.applicationName = value; }
        }

        /// <summary>
        /// Sets the ApplicationName property
        /// </summary>
        /// <param name="applicationName">The value to set for the ApplicationName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateApplicationVersionRequest WithApplicationName(string applicationName)
        {
            this.applicationName = applicationName;
            return this;
        }
            

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this.applicationName != null;       
        }

        /// <summary>
        /// A label identifying this version. Constraint: Must be unique per application. If an application version already exists with this label for
        /// the specified application, AWS Elastic Beanstalk returns an <c>InvalidParameterValue</c> error.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 100</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string VersionLabel
        {
            get { return this.versionLabel; }
            set { this.versionLabel = value; }
        }

        /// <summary>
        /// Sets the VersionLabel property
        /// </summary>
        /// <param name="versionLabel">The value to set for the VersionLabel property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateApplicationVersionRequest WithVersionLabel(string versionLabel)
        {
            this.versionLabel = versionLabel;
            return this;
        }
            

        // Check to see if VersionLabel property is set
        internal bool IsSetVersionLabel()
        {
            return this.versionLabel != null;       
        }

        /// <summary>
        /// Describes this version.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 200</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">The value to set for the Description property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateApplicationVersionRequest WithDescription(string description)
        {
            this.description = description;
            return this;
        }
            

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;       
        }

        /// <summary>
        /// The Amazon S3 bucket and key that identify the location of the source bundle for this version. If data found at the Amazon S3 location
        /// exceeds the maximum allowed source bundle size, AWS Elastic Beanstalk returns an <c>InvalidParameterValue</c> error. Default: If not
        /// specified, AWS Elastic Beanstalk uses a sample application. If only partially specified (for example, a bucket is provided but not the key)
        /// or if no data is found at the Amazon S3 location, AWS Elastic Beanstalk returns an <c>InvalidParameterCombination</c> error.
        ///  
        /// </summary>
        public S3Location SourceBundle
        {
            get { return this.sourceBundle; }
            set { this.sourceBundle = value; }
        }

        /// <summary>
        /// Sets the SourceBundle property
        /// </summary>
        /// <param name="sourceBundle">The value to set for the SourceBundle property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateApplicationVersionRequest WithSourceBundle(S3Location sourceBundle)
        {
            this.sourceBundle = sourceBundle;
            return this;
        }
            

        // Check to see if SourceBundle property is set
        internal bool IsSetSourceBundle()
        {
            return this.sourceBundle != null;       
        }

        /// <summary>
        /// Determines how the system behaves if the specified application for this version does not already exist: <enumValues> <value name="true">
        /// <c>true</c>: Automatically creates the specified application for this version if it does not already exist. </value> <value name="false">
        /// <c>false</c>: Returns an <c>InvalidParameterValue</c> if the specified application for this version does not already exist. </value>
        /// </enumValues> <ul> <li> <c>true</c> : Automatically creates the specified application for this release if it does not already exist. </li>
        /// <li> <c>false</c> : Throws an <c>InvalidParameterValue</c> if the specified application for this release does not already exist. </li> </ul>
        /// Default: <c>false</c> Valid Values: <c>true</c> | <c>false</c>
        ///  
        /// </summary>
        public bool AutoCreateApplication
        {
            get { return this.autoCreateApplication ?? default(bool); }
            set { this.autoCreateApplication = value; }
        }

        /// <summary>
        /// Sets the AutoCreateApplication property
        /// </summary>
        /// <param name="autoCreateApplication">The value to set for the AutoCreateApplication property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateApplicationVersionRequest WithAutoCreateApplication(bool autoCreateApplication)
        {
            this.autoCreateApplication = autoCreateApplication;
            return this;
        }
            

        // Check to see if AutoCreateApplication property is set
        internal bool IsSetAutoCreateApplication()
        {
            return this.autoCreateApplication.HasValue;       
        }
    }
}
    
