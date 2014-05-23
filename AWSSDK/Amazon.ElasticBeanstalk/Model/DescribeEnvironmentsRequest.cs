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
    /// Container for the parameters to the DescribeEnvironments operation.
    /// Returns descriptions for existing environments.
    /// </summary>
    public partial class DescribeEnvironmentsRequest : AmazonWebServiceRequest
    {
        private string _applicationName;
        private List<string> _environmentIds = new List<string>();
        private List<string> _environmentNames = new List<string>();
        private DateTime? _includedDeletedBackTo;
        private bool? _includeDeleted;
        private string _versionLabel;


        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        ///          If specified, AWS Elastic Beanstalk         restricts the returned descriptions
        /// to         include only those that are         associated with this application. 
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
        public DescribeEnvironmentsRequest WithApplicationName(string applicationName)
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
        /// Gets and sets the property EnvironmentIds. 
        /// <para>
        ///          If specified, AWS Elastic Beanstalk         restricts the returned descriptions
        /// to         include only those that have the         specified IDs.      
        /// </para>
        /// </summary>
        public List<string> EnvironmentIds
        {
            get { return this._environmentIds; }
            set { this._environmentIds = value; }
        }

        /// <summary>
        /// Sets the EnvironmentIds property
        /// </summary>
        /// <param name="environmentIds">The values to add to the EnvironmentIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeEnvironmentsRequest WithEnvironmentIds(params string[] environmentIds)
        {
            foreach (var element in environmentIds)
            {
                this._environmentIds.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the EnvironmentIds property
        /// </summary>
        /// <param name="environmentIds">The values to add to the EnvironmentIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeEnvironmentsRequest WithEnvironmentIds(IEnumerable<string> environmentIds)
        {
            foreach (var element in environmentIds)
            {
                this._environmentIds.Add(element);
            }
            return this;
        }
        // Check to see if EnvironmentIds property is set
        internal bool IsSetEnvironmentIds()
        {
            return this._environmentIds != null && this._environmentIds.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property EnvironmentNames. 
        /// <para>
        ///          If specified, AWS Elastic Beanstalk         restricts the returned descriptions
        /// to         include only those that have the         specified names.      
        /// </para>
        /// </summary>
        public List<string> EnvironmentNames
        {
            get { return this._environmentNames; }
            set { this._environmentNames = value; }
        }

        /// <summary>
        /// Sets the EnvironmentNames property
        /// </summary>
        /// <param name="environmentNames">The values to add to the EnvironmentNames collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeEnvironmentsRequest WithEnvironmentNames(params string[] environmentNames)
        {
            foreach (var element in environmentNames)
            {
                this._environmentNames.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the EnvironmentNames property
        /// </summary>
        /// <param name="environmentNames">The values to add to the EnvironmentNames collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeEnvironmentsRequest WithEnvironmentNames(IEnumerable<string> environmentNames)
        {
            foreach (var element in environmentNames)
            {
                this._environmentNames.Add(element);
            }
            return this;
        }
        // Check to see if EnvironmentNames property is set
        internal bool IsSetEnvironmentNames()
        {
            return this._environmentNames != null && this._environmentNames.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property IncludedDeletedBackTo. 
        /// <para>
        ///          If specified when         <code>IncludeDeleted</code>         is set to 
        ///        <code>true</code>,         then environments deleted after this date are displayed.
        ///      
        /// </para>
        /// </summary>
        public DateTime IncludedDeletedBackTo
        {
            get { return this._includedDeletedBackTo.GetValueOrDefault(); }
            set { this._includedDeletedBackTo = value; }
        }


        /// <summary>
        /// Sets the IncludedDeletedBackTo property
        /// </summary>
        /// <param name="includedDeletedBackTo">The value to set for the IncludedDeletedBackTo property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeEnvironmentsRequest WithIncludedDeletedBackTo(DateTime includedDeletedBackTo)
        {
            this._includedDeletedBackTo = includedDeletedBackTo;
            return this;
        }

        // Check to see if IncludedDeletedBackTo property is set
        internal bool IsSetIncludedDeletedBackTo()
        {
            return this._includedDeletedBackTo.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property IncludeDeleted. 
        /// <para>
        /// Indicates whether to include deleted environments:      
        /// </para>
        ///       
        /// <para>
        ///          <code>true</code>: Environments that have been deleted after         <code>IncludedDeletedBackTo</code>
        ///         are displayed.      
        /// </para>
        ///       
        /// <para>
        ///          <code>false</code>: Do not include deleted environments.      
        /// </para>
        /// </summary>
        public bool IncludeDeleted
        {
            get { return this._includeDeleted.GetValueOrDefault(); }
            set { this._includeDeleted = value; }
        }


        /// <summary>
        /// Sets the IncludeDeleted property
        /// </summary>
        /// <param name="includeDeleted">The value to set for the IncludeDeleted property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeEnvironmentsRequest WithIncludeDeleted(bool includeDeleted)
        {
            this._includeDeleted = includeDeleted;
            return this;
        }

        // Check to see if IncludeDeleted property is set
        internal bool IsSetIncludeDeleted()
        {
            return this._includeDeleted.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property VersionLabel. 
        /// <para>
        ///          If specified, AWS Elastic Beanstalk         restricts the returned descriptions
        /// to         include only those that are         associated with this application version.
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
        public DescribeEnvironmentsRequest WithVersionLabel(string versionLabel)
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