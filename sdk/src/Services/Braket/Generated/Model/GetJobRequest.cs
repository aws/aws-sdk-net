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
 * Do not modify this file. This file is generated from the braket-2019-09-01.normal.json service model.
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
namespace Amazon.Braket.Model
{
    /// <summary>
    /// Container for the parameters to the GetJob operation.
    /// Retrieves the specified Amazon Braket job.
    /// </summary>
    public partial class GetJobRequest : AmazonBraketRequest
    {
        private List<string> _additionalAttributeNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _jobArn;

        /// <summary>
        /// Gets and sets the property AdditionalAttributeNames. 
        /// <para>
        /// A list of attributes to return information for.
        /// </para>
        /// </summary>
        public List<string> AdditionalAttributeNames
        {
            get { return this._additionalAttributeNames; }
            set { this._additionalAttributeNames = value; }
        }

        // Check to see if AdditionalAttributeNames property is set
        internal bool IsSetAdditionalAttributeNames()
        {
            return this._additionalAttributeNames != null && (this._additionalAttributeNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        /// The ARN of the job to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string JobArn
        {
            get { return this._jobArn; }
            set { this._jobArn = value; }
        }

        // Check to see if JobArn property is set
        internal bool IsSetJobArn()
        {
            return this._jobArn != null;
        }

    }
}