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

namespace Amazon.SupplyChain.Model
{
    /// <summary>
    /// The details of the instance.
    /// </summary>
    public partial class Instance
    {
        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The Amazon Web Services account ID that owns the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The instance creation timestamp.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The Amazon Web Services Supply Chain instance error message. If the instance results
        /// in an unhealthy state, customers need to check the error message, delete the current
        /// instance, and recreate a new one based on the mitigation from the error message.
        /// </para>
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property InstanceDescription. 
        /// <para>
        /// The Amazon Web Services Supply Chain instance description.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 501)]
        public string InstanceDescription { get; set; }

        /// <summary>
        /// Checks to see if the InstanceDescription property is set.
        /// </summary>
        internal bool IsSetInstanceDescription() => this.InstanceDescription != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The Amazon Web Services Supply Chain instance identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property InstanceName. 
        /// <para>
        /// The Amazon Web Services Supply Chain instance name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string InstanceName { get; set; }

        /// <summary>
        /// Checks to see if the InstanceName property is set.
        /// </summary>
        internal bool IsSetInstanceName() => this.InstanceName != null;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The ARN (Amazon Resource Name) of the Key Management Service (KMS) key you optionally
        /// provided for encryption. If you did not provide anything here, AWS Supply Chain uses
        /// the Amazon Web Services owned KMS key and nothing is returned.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 2048)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The instance last modified timestamp.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InstanceState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property VersionNumber. 
        /// <para>
        /// The version number of the instance.
        /// </para>
        /// </summary>
        public double? VersionNumber { get; set; }

        /// <summary>
        /// Checks to see if the VersionNumber property is set.
        /// </summary>
        internal bool IsSetVersionNumber() => this.VersionNumber.HasValue;

        /// <summary>
        /// Gets and sets the property WebAppDnsDomain. 
        /// <para>
        /// The WebApp DNS domain name of the instance.
        /// </para>
        /// </summary>
        public string WebAppDnsDomain { get; set; }

        /// <summary>
        /// Checks to see if the WebAppDnsDomain property is set.
        /// </summary>
        internal bool IsSetWebAppDnsDomain() => this.WebAppDnsDomain != null;
    }
}
