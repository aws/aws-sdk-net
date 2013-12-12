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
    /// Container for the parameters to the DescribeEnvironments operation.
    /// <para>Returns descriptions for existing environments.</para>
    /// </summary>
    public partial class DescribeEnvironmentsRequest : AmazonElasticBeanstalkRequest
    {
        private string applicationName;
        private string versionLabel;
        private List<string> environmentIds = new List<string>();
        private List<string> environmentNames = new List<string>();
        private bool? includeDeleted;
        private DateTime? includedDeletedBackTo;


        /// <summary>
        /// If specified, AWS Elastic Beanstalk restricts the returned descriptions to include only those that are associated with this application.
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

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this.applicationName != null;
        }

        /// <summary>
        /// If specified, AWS Elastic Beanstalk restricts the returned descriptions to include only those that are associated with this application
        /// version.
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

        // Check to see if VersionLabel property is set
        internal bool IsSetVersionLabel()
        {
            return this.versionLabel != null;
        }

        /// <summary>
        /// If specified, AWS Elastic Beanstalk restricts the returned descriptions to include only those that have the specified IDs.
        ///  
        /// </summary>
        public List<string> EnvironmentIds
        {
            get { return this.environmentIds; }
            set { this.environmentIds = value; }
        }

        // Check to see if EnvironmentIds property is set
        internal bool IsSetEnvironmentIds()
        {
            return this.environmentIds.Count > 0;
        }

        /// <summary>
        /// If specified, AWS Elastic Beanstalk restricts the returned descriptions to include only those that have the specified names.
        ///  
        /// </summary>
        public List<string> EnvironmentNames
        {
            get { return this.environmentNames; }
            set { this.environmentNames = value; }
        }

        // Check to see if EnvironmentNames property is set
        internal bool IsSetEnvironmentNames()
        {
            return this.environmentNames.Count > 0;
        }

        /// <summary>
        /// Indicates whether to include deleted environments: <c>true</c>: Environments that have been deleted after <c>IncludedDeletedBackTo</c> are
        /// displayed. <c>false</c>: Do not include deleted environments.
        ///  
        /// </summary>
        public bool IncludeDeleted
        {
            get { return this.includeDeleted ?? default(bool); }
            set { this.includeDeleted = value; }
        }

        // Check to see if IncludeDeleted property is set
        internal bool IsSetIncludeDeleted()
        {
            return this.includeDeleted.HasValue;
        }

        /// <summary>
        /// If specified when <c>IncludeDeleted</c> is set to <c>true</c>, then environments deleted after this date are displayed.
        ///  
        /// </summary>
        public DateTime IncludedDeletedBackTo
        {
            get { return this.includedDeletedBackTo ?? default(DateTime); }
            set { this.includedDeletedBackTo = value; }
        }

        // Check to see if IncludedDeletedBackTo property is set
        internal bool IsSetIncludedDeletedBackTo()
        {
            return this.includedDeletedBackTo.HasValue;
        }

    }
}
    
