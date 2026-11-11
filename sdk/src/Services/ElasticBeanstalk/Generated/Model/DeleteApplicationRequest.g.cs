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
    /// Container for the parameters to the DeleteApplication operation. Deletes the specified
    /// application along with all associated versions and configurations. The application
    /// versions will not be deleted from your Amazon S3 bucket. <note> <para> You cannot
    /// delete an application that has a running environment. </para> </note>
    /// </summary>
    public partial class DeleteApplicationRequest : AmazonElasticBeanstalkRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public DeleteApplicationRequest() { }

        /// <summary>
        /// Instantiates DeleteApplicationRequest with the parameterized properties
        /// </summary>
        /// <param name="applicationName">The name of the application to delete.</param>
        public DeleteApplicationRequest(string applicationName)
        {
            this.ApplicationName = applicationName;
        }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the application to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationName property is set.
        /// </summary>
        internal bool IsSetApplicationName() => this.ApplicationName != null;

        /// <summary>
        /// Gets and sets the property TerminateEnvByForce. 
        /// <para>
        /// When set to true, running environments will be terminated before deleting the application.
        /// </para>
        /// </summary>
        public bool? TerminateEnvByForce { get; set; }

        /// <summary>
        /// Checks to see if the TerminateEnvByForce property is set.
        /// </summary>
        internal bool IsSetTerminateEnvByForce() => this.TerminateEnvByForce.HasValue;
    }
}
