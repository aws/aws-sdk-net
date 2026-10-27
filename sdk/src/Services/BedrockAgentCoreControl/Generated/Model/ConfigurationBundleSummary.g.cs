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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Summary information about a configuration bundle.
    /// </summary>
    public partial class ConfigurationBundleSummary
    {
        /// <summary>
        /// Gets and sets the property BundleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the configuration bundle.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BundleArn { get; set; }

        /// <summary>
        /// Checks to see if the BundleArn property is set.
        /// </summary>
        internal bool IsSetBundleArn() => this.BundleArn != null;

        /// <summary>
        /// Gets and sets the property BundleId. 
        /// <para>
        /// The unique identifier of the configuration bundle.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BundleId { get; set; }

        /// <summary>
        /// Checks to see if the BundleId property is set.
        /// </summary>
        internal bool IsSetBundleId() => this.BundleId != null;

        /// <summary>
        /// Gets and sets the property BundleName. 
        /// <para>
        /// The name of the configuration bundle.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BundleName { get; set; }

        /// <summary>
        /// Checks to see if the BundleName property is set.
        /// </summary>
        internal bool IsSetBundleName() => this.BundleName != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the configuration bundle was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the configuration bundle.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 500)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;
    }
}
