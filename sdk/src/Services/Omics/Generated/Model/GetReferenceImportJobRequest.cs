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

namespace Amazon.Omics.Model
{
    /// <summary>
    /// Container for the parameters to the GetReferenceImportJob operation.
    /// Gets information about a reference import job.
    /// </summary>
    public partial class GetReferenceImportJobRequest : AmazonOmicsRequest
    {
        private string _id;
        private string _referenceStoreId;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The job's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=36)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
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

    }
}