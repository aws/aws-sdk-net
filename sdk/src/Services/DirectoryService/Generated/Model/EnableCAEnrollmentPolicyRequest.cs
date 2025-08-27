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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
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
namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Container for the parameters to the EnableCAEnrollmentPolicy operation.
    /// Enables certificate authority (CA) enrollment policy for the specified directory.
    /// This allows domain-joined clients to automatically request and receive certificates
    /// from the specified Amazon Web Services Private Certificate Authority.
    /// 
    ///  <note> 
    /// <para>
    /// Before enabling CA enrollment, ensure that the PCA connector is properly configured
    /// and accessible from the directory. The connector must be in an active state and have
    /// the necessary permissions.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class EnableCAEnrollmentPolicyRequest : AmazonDirectoryServiceRequest
    {
        private string _directoryId;
        private string _pcaConnectorArn;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The identifier of the directory for which to enable the CA enrollment policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

        /// <summary>
        /// Gets and sets the property PcaConnectorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Private Certificate Authority (PCA) connector
        /// to use for automatic certificate enrollment. This connector must be properly configured
        /// and accessible from the directory.
        /// </para>
        ///  
        /// <para>
        /// The ARN format is: <c>arn:aws:pca-connector-ad:<i>region</i>:<i>account-id</i>:connector/<i>connector-id</i>
        /// </c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PcaConnectorArn
        {
            get { return this._pcaConnectorArn; }
            set { this._pcaConnectorArn = value; }
        }

        // Check to see if PcaConnectorArn property is set
        internal bool IsSetPcaConnectorArn()
        {
            return this._pcaConnectorArn != null;
        }

    }
}