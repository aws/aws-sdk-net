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

namespace Amazon.Omics.Model
{
    /// <summary>
    /// Container for the parameters to the StartReadSetImportJob operation. Imports a read
    /// set from the sequence store. Read set import jobs support a maximum of 100 read sets
    /// of different types. Monitor the progress of your read set import job by calling the
    /// <c>GetReadSetImportJob</c> API operation.
    /// </summary>
    public partial class StartReadSetImportJobRequest : AmazonOmicsRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// To ensure that jobs don't run multiple times, specify a unique token for each job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 127)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// A service role for the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property SequenceStoreId. 
        /// <para>
        /// The read set's sequence store ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 36)]
        public string SequenceStoreId { get; set; }

        /// <summary>
        /// Checks to see if the SequenceStoreId property is set.
        /// </summary>
        internal bool IsSetSequenceStoreId() => this.SequenceStoreId != null;

        /// <summary>
        /// Gets and sets the property Sources. 
        /// <para>
        /// The job's source files.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public List<StartReadSetImportJobSourceItem> Sources { get; set; } = AWSConfigs.InitializeCollections ? new List<StartReadSetImportJobSourceItem>() : null;

        /// <summary>
        /// Checks to see if the Sources property is set.
        /// </summary>
        internal bool IsSetSources() => this.Sources != null && (this.Sources.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
