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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateConfiguration operation. Updates the scan
    /// configuration for your Amazon Inspector account. If you don't specify an <c>accountId</c>,
    /// this operation updates the delegated administrator's configuration and propagates
    /// it to member accounts that have not been individually configured. If you specify an
    /// <c>accountId</c>, this operation updates that member account's configuration. Only
    /// the delegated administrator can specify an <c>accountId</c>; member accounts cannot
    /// call this operation.
    /// </summary>
    public partial class UpdateConfigurationRequest : AmazonInspector2Request
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The 12-digit Amazon Web Services account ID of the member account whose scan configuration
        /// you want to update. When specified, you must be the delegated administrator for this
        /// member account. If not specified, the operation updates your own configuration and
        /// propagates changes to any member accounts that have not been individually configured.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property AmiConfiguration. 
        /// <para>
        /// The Amazon Machine Image (AMI) scan configuration to apply to the account.
        /// </para>
        /// </summary>
        public AmiConfiguration AmiConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AmiConfiguration property is set.
        /// </summary>
        internal bool IsSetAmiConfiguration() => this.AmiConfiguration != null;

        /// <summary>
        /// Gets and sets the property Ec2Configuration. 
        /// <para>
        /// Specifies how the Amazon EC2 automated scan will be updated for your environment.
        /// </para>
        /// </summary>
        public Ec2Configuration Ec2Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Ec2Configuration property is set.
        /// </summary>
        internal bool IsSetEc2Configuration() => this.Ec2Configuration != null;

        /// <summary>
        /// Gets and sets the property EcrConfiguration. 
        /// <para>
        /// Specifies how the ECR automated re-scan will be updated for your environment.
        /// </para>
        /// </summary>
        public EcrConfiguration EcrConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EcrConfiguration property is set.
        /// </summary>
        internal bool IsSetEcrConfiguration() => this.EcrConfiguration != null;

        /// <summary>
        /// Gets and sets the property UpdateConfigurationInheritance. 
        /// <para>
        /// Specifies which scan-type configurations to reset to the delegated administrator's
        /// inherited values for the targeted member account. Each member of this structure is
        /// independently optional. When specified, <c>ec2Configuration</c> and <c>ecrConfiguration</c>
        /// must be absent, and <c>accountId</c> must also be present. Only <c>INHERIT_FROM_ADMIN</c>
        /// is valid for each member. If not specified, the operation uses the <c>ec2Configuration</c>
        /// and <c>ecrConfiguration</c> parameters instead.
        /// </para>
        /// </summary>
        public UpdateConfigurationInheritance UpdateConfigurationInheritance { get; set; }

        /// <summary>
        /// Checks to see if the UpdateConfigurationInheritance property is set.
        /// </summary>
        internal bool IsSetUpdateConfigurationInheritance() => this.UpdateConfigurationInheritance != null;
    }
}
