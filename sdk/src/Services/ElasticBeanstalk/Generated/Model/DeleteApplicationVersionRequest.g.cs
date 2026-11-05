/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteApplicationVersion operation. Deletes the
    /// specified version from the specified application. <note> <para> You cannot delete
    /// an application version that is associated with a running environment. </para> </note>
    /// </summary>
    public partial class DeleteApplicationVersionRequest : AmazonElasticBeanstalkRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public DeleteApplicationVersionRequest() { }

        /// <summary>
        /// Instantiates DeleteApplicationVersionRequest with the parameterized properties
        /// </summary>
        /// <param name="applicationName">The name of the application to which the version belongs.</param>
        /// <param name="versionLabel">The label of the version to delete.</param>
        public DeleteApplicationVersionRequest(string applicationName, string versionLabel)
        {
            this.ApplicationName = applicationName;
            this.VersionLabel = versionLabel;
        }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the application to which the version belongs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationName property is set.
        /// </summary>
        internal bool IsSetApplicationName() => this.ApplicationName != null;

        /// <summary>
        /// Gets and sets the property DeleteSourceBundle. 
        /// <para>
        /// Set to <c>true</c> to delete the source bundle from your storage bucket. Otherwise,
        /// the application version is deleted only from Elastic Beanstalk and the source bundle
        /// remains in Amazon S3.
        /// </para>
        /// </summary>
        public bool? DeleteSourceBundle { get; set; }

        /// <summary>
        /// Checks to see if the DeleteSourceBundle property is set.
        /// </summary>
        internal bool IsSetDeleteSourceBundle() => this.DeleteSourceBundle.HasValue;

        /// <summary>
        /// Gets and sets the property VersionLabel. 
        /// <para>
        /// The label of the version to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string VersionLabel { get; set; }

        /// <summary>
        /// Checks to see if the VersionLabel property is set.
        /// </summary>
        internal bool IsSetVersionLabel() => this.VersionLabel != null;
    }
}
