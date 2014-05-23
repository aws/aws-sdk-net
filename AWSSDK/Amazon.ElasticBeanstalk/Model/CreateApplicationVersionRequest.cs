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
    /// Container for the parameters to the CreateApplicationVersion operation.
    /// Creates an application version for the specified         application.
    /// 
    ///       <note>Once you create an application version with a specified Amazon S3    
    ///     bucket         and key location, you cannot change that Amazon S3 location. If
    /// you change the         Amazon S3 location,         you receive an exception when you
    /// attempt to launch an environment from the         application version. </note>
    /// </summary>
    public partial class CreateApplicationVersionRequest : AmazonWebServiceRequest
    {
        private string _applicationName;
        private bool? _autoCreateApplication;
        private string _description;
        private S3Location _sourceBundle;
        private string _versionLabel;


        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        ///          The name of the application.         If no application is found with this
        /// name,         and         <code>AutoCreateApplication</code>         is         <code>false</code>,
        /// returns an         <code>InvalidParameterValue</code>         error.      
        /// </para>
        /// </summary>
        public string ApplicationName
        {
            get { return this._applicationName; }
            set { this._applicationName = value; }
        }


        /// <summary>
        /// Sets the ApplicationName property
        /// </summary>
        /// <param name="applicationName">The value to set for the ApplicationName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateApplicationVersionRequest WithApplicationName(string applicationName)
        {
            this._applicationName = applicationName;
            return this;
        }

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this._applicationName != null;
        }


        /// <summary>
        /// Gets and sets the property AutoCreateApplication. 
        /// <para>
        ///          Determines how the system behaves if the specified         application for
        /// this         version does not already exist:      
        /// </para>
        ///       <enumValues>         <value name="true">            
        /// <para>
        ///                <code>true</code>: Automatically creates the specified application
        /// for this               version if it does not already exist.            
        /// </para>
        ///          </value>         <value name="false">            
        /// <para>
        ///                <code>false</code>: Returns an               <code>InvalidParameterValue</code>
        ///               if the specified application for this version does not already     
        ///          exist.            
        /// </para>
        ///          </value>      </enumValues>      <ul>         <li>            <code>true</code>
        ///            : Automatically creates the specified application for this            release
        /// if it does not already exist.         </li>         <li>            <code>false</code>
        ///            : Throws an            <code>InvalidParameterValue</code>            if
        /// the specified application for this release does not already            exist.    
        ///     </li>      </ul>      
        /// <para>
        ///          Default:         <code>false</code>      
        /// </para>
        ///       
        /// <para>
        ///          Valid Values:         <code>true</code>         |         <code>false</code>
        ///      
        /// </para>
        /// </summary>
        public bool AutoCreateApplication
        {
            get { return this._autoCreateApplication.GetValueOrDefault(); }
            set { this._autoCreateApplication = value; }
        }


        /// <summary>
        /// Sets the AutoCreateApplication property
        /// </summary>
        /// <param name="autoCreateApplication">The value to set for the AutoCreateApplication property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateApplicationVersionRequest WithAutoCreateApplication(bool autoCreateApplication)
        {
            this._autoCreateApplication = autoCreateApplication;
            return this;
        }

        // Check to see if AutoCreateApplication property is set
        internal bool IsSetAutoCreateApplication()
        {
            return this._autoCreateApplication.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Describes this version.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }


        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">The value to set for the Description property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateApplicationVersionRequest WithDescription(string description)
        {
            this._description = description;
            return this;
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }


        /// <summary>
        /// Gets and sets the property SourceBundle. 
        /// <para>
        ///  The Amazon S3 bucket and key that identify the location of the         source   
        ///      bundle for this version. 
        /// </para>
        ///       
        /// <para>
        ///          If data found at the Amazon S3 location exceeds the maximum allowed     
        ///    source bundle size, AWS Elastic Beanstalk         returns an         <code>InvalidParameterValue</code>
        ///         error. The maximum size allowed is 512 MB.      
        /// </para>
        ///       
        /// <para>
        /// Default:         If not specified, AWS Elastic Beanstalk         uses a sample application.
        ///         If only partially specified (for example, a bucket is provided but not   
        ///      the key)         or if no data is found at the Amazon S3 location, AWS Elastic
        /// Beanstalk         returns an         <code>InvalidParameterCombination</code>    
        ///     error.      
        /// </para>
        /// </summary>
        public S3Location SourceBundle
        {
            get { return this._sourceBundle; }
            set { this._sourceBundle = value; }
        }


        /// <summary>
        /// Sets the SourceBundle property
        /// </summary>
        /// <param name="sourceBundle">The value to set for the SourceBundle property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateApplicationVersionRequest WithSourceBundle(S3Location sourceBundle)
        {
            this._sourceBundle = sourceBundle;
            return this;
        }

        // Check to see if SourceBundle property is set
        internal bool IsSetSourceBundle()
        {
            return this._sourceBundle != null;
        }


        /// <summary>
        /// Gets and sets the property VersionLabel. 
        /// <para>
        /// A label identifying this version.
        /// </para>
        ///       
        /// <para>
        /// Constraint:         Must be unique per application. If an application version already
        ///         exists with this label for the specified application, AWS Elastic Beanstalk
        ///         returns an         <code>InvalidParameterValue</code>         error.     
        /// 
        /// </para>
        /// </summary>
        public string VersionLabel
        {
            get { return this._versionLabel; }
            set { this._versionLabel = value; }
        }


        /// <summary>
        /// Sets the VersionLabel property
        /// </summary>
        /// <param name="versionLabel">The value to set for the VersionLabel property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateApplicationVersionRequest WithVersionLabel(string versionLabel)
        {
            this._versionLabel = versionLabel;
            return this;
        }

        // Check to see if VersionLabel property is set
        internal bool IsSetVersionLabel()
        {
            return this._versionLabel != null;
        }

    }
}