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
    /// Container for the parameters to the DescribeApplicationVersions operation.
    /// Returns descriptions for existing application versions.
    /// </summary>
    public partial class DescribeApplicationVersionsRequest : AmazonWebServiceRequest
    {
        private string _applicationName;
        private List<string> _versionLabels = new List<string>();


        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        ///          If specified, AWS Elastic Beanstalk         restricts the returned descriptions
        /// to         only include ones that are         associated with the specified application.
        ///      
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
        public DescribeApplicationVersionsRequest WithApplicationName(string applicationName)
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
        /// Gets and sets the property VersionLabels. 
        /// <para>
        ///          If specified, restricts the returned descriptions to only include ones  
        ///       that have the specified version labels.      
        /// </para>
        /// </summary>
        public List<string> VersionLabels
        {
            get { return this._versionLabels; }
            set { this._versionLabels = value; }
        }

        /// <summary>
        /// Sets the VersionLabels property
        /// </summary>
        /// <param name="versionLabels">The values to add to the VersionLabels collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeApplicationVersionsRequest WithVersionLabels(params string[] versionLabels)
        {
            foreach (var element in versionLabels)
            {
                this._versionLabels.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the VersionLabels property
        /// </summary>
        /// <param name="versionLabels">The values to add to the VersionLabels collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeApplicationVersionsRequest WithVersionLabels(IEnumerable<string> versionLabels)
        {
            foreach (var element in versionLabels)
            {
                this._versionLabels.Add(element);
            }
            return this;
        }
        // Check to see if VersionLabels property is set
        internal bool IsSetVersionLabels()
        {
            return this._versionLabels != null && this._versionLabels.Count > 0; 
        }

    }
}