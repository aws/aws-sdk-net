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

namespace Amazon.MigrationHub.Model
{
    /// <summary>
    /// Container for the parameters to the DisassociateDiscoveredResource operation. Disassociate
    /// an Application Discovery Service discovered resource from a migration task.
    /// </summary>
    public partial class DisassociateDiscoveredResourceRequest : AmazonMigrationHubRequest
    {
        /// <summary>
        /// Gets and sets the property ConfigurationId. 
        /// <para>
        /// ConfigurationId of the Application Discovery Service resource to be disassociated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1600)]
        public string ConfigurationId { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationId property is set.
        /// </summary>
        internal bool IsSetConfigurationId() => this.ConfigurationId != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Optional boolean flag to indicate whether any effect should take place. Used to test
        /// if the caller has permission to make the call.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property MigrationTaskName. 
        /// <para>
        /// The identifier given to the MigrationTask. <i>Do not store personal data in this field.</i>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string MigrationTaskName { get; set; }

        /// <summary>
        /// Checks to see if the MigrationTaskName property is set.
        /// </summary>
        internal bool IsSetMigrationTaskName() => this.MigrationTaskName != null;

        /// <summary>
        /// Gets and sets the property ProgressUpdateStream. 
        /// <para>
        /// The name of the ProgressUpdateStream.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public string ProgressUpdateStream { get; set; }

        /// <summary>
        /// Checks to see if the ProgressUpdateStream property is set.
        /// </summary>
        internal bool IsSetProgressUpdateStream() => this.ProgressUpdateStream != null;
    }
}
