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

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Identifies an Amazon EC2 launch template to use for a specific account.
    /// </summary>
    public partial class LaunchTemplateConfiguration
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account ID that this configuration applies to.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property LaunchTemplateId. 
        /// <para>
        /// Identifies the Amazon EC2 launch template to use.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LaunchTemplateId { get; set; }

        /// <summary>
        /// Checks to see if the LaunchTemplateId property is set.
        /// </summary>
        internal bool IsSetLaunchTemplateId() => this.LaunchTemplateId != null;

        /// <summary>
        /// Gets and sets the property SetDefaultVersion. 
        /// <para>
        /// Specifies whether to make the new launch template version that Image Builder creates
        /// the default version of the launch template. If you don't set a value, Image Builder
        /// treats it as <c>true</c>.
        /// </para>
        /// </summary>
        public bool? SetDefaultVersion { get; set; }

        /// <summary>
        /// Checks to see if the SetDefaultVersion property is set.
        /// </summary>
        internal bool IsSetSetDefaultVersion() => this.SetDefaultVersion.HasValue;
    }
}
