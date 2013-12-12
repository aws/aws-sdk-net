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
    /// Container for the parameters to the DeleteApplication operation.
    /// <para> Deletes the specified application along with all associated versions and configurations. The application versions will not be deleted
    /// from your Amazon S3 bucket. </para> <para><b>NOTE:</b>You cannot delete an application that has a running environment. </para>
    /// </summary>
    public partial class DeleteApplicationRequest : AmazonElasticBeanstalkRequest
    {
        private string applicationName;
        private bool? terminateEnvByForce;


        /// <summary>
        /// The name of the application to delete.
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
        /// When set to true, running environments will be terminated before deleting the application.
        ///  
        /// </summary>
        public bool TerminateEnvByForce
        {
            get { return this.terminateEnvByForce ?? default(bool); }
            set { this.terminateEnvByForce = value; }
        }

        // Check to see if TerminateEnvByForce property is set
        internal bool IsSetTerminateEnvByForce()
        {
            return this.terminateEnvByForce.HasValue;
        }

    }
}
    
