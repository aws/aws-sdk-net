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
    /// Container for the parameters to the DeleteApplicationVersion operation.
    /// <para> Deletes the specified version from the specified application. </para> <para><b>NOTE:</b>You cannot delete an application version that
    /// is associated with a running environment.</para>
    /// </summary>
    public partial class DeleteApplicationVersionRequest : AmazonElasticBeanstalkRequest
    {
        private string applicationName;
        private string versionLabel;
        private bool? deleteSourceBundle;


        /// <summary>
        /// The name of the application to delete releases from.
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
        /// The label of the version to delete.
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
        /// Indicates whether to delete the associated source bundle from Amazon S3: <ul> <li> <c>true</c>: An attempt is made to delete the associated
        /// Amazon S3 source bundle specified at time of creation. </li> <li> <c>false</c>: No action is taken on the Amazon S3 source bundle specified
        /// at time of creation. </li> </ul> Valid Values: <c>true</c> | <c>false</c>
        ///  
        /// </summary>
        public bool DeleteSourceBundle
        {
            get { return this.deleteSourceBundle ?? default(bool); }
            set { this.deleteSourceBundle = value; }
        }

        // Check to see if DeleteSourceBundle property is set
        internal bool IsSetDeleteSourceBundle()
        {
            return this.deleteSourceBundle.HasValue;
        }

    }
}
    
