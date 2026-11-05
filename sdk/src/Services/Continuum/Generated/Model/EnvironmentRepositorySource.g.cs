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

namespace Amazon.Continuum.Model
{
    /// <summary>
    /// One repository selected from a previously-created integration.
    /// </summary>
    public partial class EnvironmentRepositorySource
    {
        /// <summary>
        /// Gets and sets the property DefaultBranch. Branch used when a scan does not choose
        /// a more specific revision.
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DefaultBranch { get; set; }

        /// <summary>
        /// Checks to see if the DefaultBranch property is set.
        /// </summary>
        internal bool IsSetDefaultBranch() => this.DefaultBranch != null;

        /// <summary>
        /// Gets and sets the property IntegrationId. Integration that provides the selected repository.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string IntegrationId { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationId property is set.
        /// </summary>
        internal bool IsSetIntegrationId() => this.IntegrationId != null;

        /// <summary>
        /// Gets and sets the property Repository. Repository selected from that integration in
        /// owner/repository form.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Repository { get; set; }

        /// <summary>
        /// Checks to see if the Repository property is set.
        /// </summary>
        internal bool IsSetRepository() => this.Repository != null;
    }
}
