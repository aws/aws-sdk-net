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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterPublisher operation.
    /// Registers your account as a publisher of public extensions in the CloudFormation registry.
    /// Public extensions are available for use by all CloudFormation users. This publisher
    /// ID applies to your account in all Amazon Web Services Regions.
    /// 
    ///  
    /// <para>
    /// For information about requirements for registering as a public extension publisher,
    /// see <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/publish-extension.html#publish-extension-prereqs">Prerequisite:
    /// Registering your account to publish CloudFormation extensions</a> in the <i>CloudFormation
    /// Command Line Interface (CLI) User Guide</i>.
    /// </para>
    /// </summary>
    public partial class RegisterPublisherRequest : AmazonCloudFormationRequest
    {
        private bool? _acceptTermsAndConditions;
        private string _connectionArn;

        /// <summary>
        /// Gets and sets the property AcceptTermsAndConditions. 
        /// <para>
        /// Whether you accept the <a href="https://cloudformation-registry-documents.s3.amazonaws.com/Terms_and_Conditions_for_AWS_CloudFormation_Registry_Publishers.pdf">Terms
        /// and Conditions</a> for publishing extensions in the CloudFormation registry. You must
        /// accept the terms and conditions in order to register to publish public extensions
        /// to the CloudFormation registry.
        /// </para>
        ///  
        /// <para>
        /// The default is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? AcceptTermsAndConditions
        {
            get { return this._acceptTermsAndConditions; }
            set { this._acceptTermsAndConditions = value; }
        }

        // Check to see if AcceptTermsAndConditions property is set
        internal bool IsSetAcceptTermsAndConditions()
        {
            return this._acceptTermsAndConditions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConnectionArn. 
        /// <para>
        /// If you are using a Bitbucket or GitHub account for identity verification, the Amazon
        /// Resource Name (ARN) for your connection to that account.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/publish-extension.html#publish-extension-prereqs">Prerequisite:
        /// Registering your account to publish CloudFormation extensions</a> in the <i>CloudFormation
        /// Command Line Interface (CLI) User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ConnectionArn
        {
            get { return this._connectionArn; }
            set { this._connectionArn = value; }
        }

        // Check to see if ConnectionArn property is set
        internal bool IsSetConnectionArn()
        {
            return this._connectionArn != null;
        }

    }
}