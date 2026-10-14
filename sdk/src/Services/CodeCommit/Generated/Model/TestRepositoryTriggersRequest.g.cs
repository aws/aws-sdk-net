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

namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// Container for the parameters to the TestRepositoryTriggers operation. Tests the functionality
    /// of repository triggers by sending information to the trigger target. If real data
    /// is available in the repository, the test sends data from the last commit. If no data
    /// is available, sample data is generated.
    /// </summary>
    public partial class TestRepositoryTriggersRequest : AmazonCodeCommitRequest
    {
        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository in which to test the triggers.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryName property is set.
        /// </summary>
        internal bool IsSetRepositoryName() => this.RepositoryName != null;

        /// <summary>
        /// Gets and sets the property Triggers. 
        /// <para>
        /// The list of triggers to test.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<RepositoryTrigger> Triggers { get; set; } = AWSConfigs.InitializeCollections ? new List<RepositoryTrigger>() : null;

        /// <summary>
        /// Checks to see if the Triggers property is set.
        /// </summary>
        internal bool IsSetTriggers() => this.Triggers != null && (this.Triggers.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
