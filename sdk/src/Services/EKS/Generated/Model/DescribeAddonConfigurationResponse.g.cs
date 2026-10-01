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

namespace Amazon.EKS.Model
{
    /// <summary>
    /// This is the response object from the DescribeAddonConfiguration operation.
    /// </summary>
    public partial class DescribeAddonConfigurationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AddonName. 
        /// <para>
        /// The name of the add-on.
        /// </para>
        /// </summary>
        public string AddonName { get; set; }

        /// <summary>
        /// Checks to see if the AddonName property is set.
        /// </summary>
        internal bool IsSetAddonName() => this.AddonName != null;

        /// <summary>
        /// Gets and sets the property AddonVersion. 
        /// <para>
        /// The version of the add-on. The version must match one of the versions returned by
        /// <a href="https://docs.aws.amazon.com/eks/latest/APIReference/API_DescribeAddonVersions.html">
        /// <c>DescribeAddonVersions</c> </a>.
        /// </para>
        /// </summary>
        public string AddonVersion { get; set; }

        /// <summary>
        /// Checks to see if the AddonVersion property is set.
        /// </summary>
        internal bool IsSetAddonVersion() => this.AddonVersion != null;

        /// <summary>
        /// Gets and sets the property ConfigurationSchema. 
        /// <para>
        /// A JSON schema that's used to validate the configuration values you provide when an
        /// add-on is created or updated.
        /// </para>
        /// </summary>
        public string ConfigurationSchema { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationSchema property is set.
        /// </summary>
        internal bool IsSetConfigurationSchema() => this.ConfigurationSchema != null;

        /// <summary>
        /// Gets and sets the property PodIdentityConfiguration. 
        /// <para>
        /// The Kubernetes service account name used by the add-on, and any suggested IAM policies.
        /// Use this information to create an IAM Role for the add-on.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AddonPodIdentityConfiguration> PodIdentityConfiguration { get; set; } = AWSConfigs.InitializeCollections ? new List<AddonPodIdentityConfiguration>() : null;

        /// <summary>
        /// Checks to see if the PodIdentityConfiguration property is set.
        /// </summary>
        internal bool IsSetPodIdentityConfiguration() => this.PodIdentityConfiguration != null && (this.PodIdentityConfiguration.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
