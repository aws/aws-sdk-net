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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
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
namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// Container for the parameters to the StartBulkDeployment operation.
    /// Deploys multiple groups in one operation. This action starts the bulk deployment of
    /// a specified set of group versions. Each group version deployment will be triggered
    /// with an adaptive rate that has a fixed upper limit. We recommend that you include
    /// an ''X-Amzn-Client-Token'' token in every ''StartBulkDeployment'' request. These requests
    /// are idempotent with respect to the token and the request parameters.
    /// </summary>
    public partial class StartBulkDeploymentRequest : AmazonGreengrassRequest
    {
        private string _amznClientToken;
        private string _executionRoleArn;
        private string _inputFileUri;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AmznClientToken. A client token used to correlate requests
        /// and responses.
        /// </summary>
        public string AmznClientToken
        {
            get { return this._amznClientToken; }
            set { this._amznClientToken = value; }
        }

        // Check to see if AmznClientToken property is set
        internal bool IsSetAmznClientToken()
        {
            return this._amznClientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. The ARN of the execution role to associate
        /// with the bulk deployment operation. This IAM role must allow the ''greengrass:CreateDeployment''
        /// action for all group versions that are listed in the input file. This IAM role must
        /// have access to the S3 bucket containing the input file.
        /// </summary>
        [AWSProperty(Required=true)]
        public string ExecutionRoleArn
        {
            get { return this._executionRoleArn; }
            set { this._executionRoleArn = value; }
        }

        // Check to see if ExecutionRoleArn property is set
        internal bool IsSetExecutionRoleArn()
        {
            return this._executionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property InputFileUri. The URI of the input file contained in the
        /// S3 bucket. The execution role must have ''getObject'' permissions on this bucket to
        /// access the input file. The input file is a JSON-serialized, line delimited file with
        /// UTF-8 encoding that provides a list of group and version IDs and the deployment type.
        /// This file must be less than 100 MB. Currently, AWS IoT Greengrass supports only ''NewDeployment''
        /// deployment types.
        /// </summary>
        [AWSProperty(Required=true)]
        public string InputFileUri
        {
            get { return this._inputFileUri; }
            set { this._inputFileUri = value; }
        }

        // Check to see if InputFileUri property is set
        internal bool IsSetInputFileUri()
        {
            return this._inputFileUri != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. Tag(s) to add to the new resource.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}