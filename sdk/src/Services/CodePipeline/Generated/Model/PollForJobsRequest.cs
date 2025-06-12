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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
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
namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Container for the parameters to the PollForJobs operation.
    /// Returns information about any jobs for CodePipeline to act on. <c>PollForJobs</c>
    /// is valid only for action types with "Custom" in the owner field. If the action type
    /// contains <c>AWS</c> or <c>ThirdParty</c> in the owner field, the <c>PollForJobs</c>
    /// action returns an error.
    /// 
    ///  <important> 
    /// <para>
    /// When this API is called, CodePipeline returns temporary credentials for the S3 bucket
    /// used to store artifacts for the pipeline, if the action requires access to that S3
    /// bucket for input or output artifacts. This API also returns any secret values defined
    /// for the action.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class PollForJobsRequest : AmazonCodePipelineRequest
    {
        private ActionTypeId _actionTypeId;
        private int? _maxBatchSize;
        private Dictionary<string, string> _queryParam = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ActionTypeId. 
        /// <para>
        /// Represents information about an action type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ActionTypeId ActionTypeId
        {
            get { return this._actionTypeId; }
            set { this._actionTypeId = value; }
        }

        // Check to see if ActionTypeId property is set
        internal bool IsSetActionTypeId()
        {
            return this._actionTypeId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxBatchSize. 
        /// <para>
        /// The maximum number of jobs to return in a poll for jobs call.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MaxBatchSize
        {
            get { return this._maxBatchSize; }
            set { this._maxBatchSize = value; }
        }

        // Check to see if MaxBatchSize property is set
        internal bool IsSetMaxBatchSize()
        {
            return this._maxBatchSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueryParam. 
        /// <para>
        /// A map of property names and values. For an action type with no queryable properties,
        /// this value must be null or an empty map. For an action type with a queryable property,
        /// you must supply that property as a key in the map. Only jobs whose action configuration
        /// matches the mapped value are returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public Dictionary<string, string> QueryParam
        {
            get { return this._queryParam; }
            set { this._queryParam = value; }
        }

        // Check to see if QueryParam property is set
        internal bool IsSetQueryParam()
        {
            return this._queryParam != null && (this._queryParam.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}