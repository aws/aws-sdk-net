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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
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
    /// Container for the parameters to the StartReferenceImportJob operation.
    /// Imports a reference genome from Amazon S3 into a specified reference store. You can
    /// have multiple reference genomes in a reference store. You can only import reference
    /// genomes one at a time into each reference store. Monitor the status of your reference
    /// import job by using the <c>GetReferenceImportJob</c> API operation.
    /// </summary>
    public partial class StartReferenceImportJobRequest : AmazonOmicsRequest
    {
        private string _clientToken;
        private string _referenceStoreId;
        private string _roleArn;
        private List<StartReferenceImportJobSourceItem> _sources = AWSConfigs.InitializeCollections ? new List<StartReferenceImportJobSourceItem>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// To ensure that jobs don't run multiple times, specify a unique token for each job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ReferenceStoreId. 
        /// <para>
        /// The job's reference store ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=36)]
        public string ReferenceStoreId
        {
            get { return this._referenceStoreId; }
            set { this._referenceStoreId = value; }
        }

        // Check to see if ReferenceStoreId property is set
        internal bool IsSetReferenceStoreId()
        {
            return this._referenceStoreId != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// A service role for the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Sources. 
        /// <para>
        /// The job's source files.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<StartReferenceImportJobSourceItem> Sources
        {
            get { return this._sources; }
            set { this._sources = value; }
        }

        // Check to see if Sources property is set
        internal bool IsSetSources()
        {
            return this._sources != null && (this._sources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}