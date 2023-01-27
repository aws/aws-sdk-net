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
 * Do not modify this file. This file is generated from the ecr-public-2020-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECRPublic.Model
{
    /// <summary>
    /// An object that represents an Amazon ECR image layer failure.
    /// </summary>
    public partial class LayerFailure
    {
        private LayerFailureCode _failureCode;
        private string _failureReason;
        private string _layerDigest;

        /// <summary>
        /// Gets and sets the property FailureCode. 
        /// <para>
        /// The failure code that's associated with the failure.
        /// </para>
        /// </summary>
        public LayerFailureCode FailureCode
        {
            get { return this._failureCode; }
            set { this._failureCode = value; }
        }

        // Check to see if FailureCode property is set
        internal bool IsSetFailureCode()
        {
            return this._failureCode != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason for the failure.
        /// </para>
        /// </summary>
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property LayerDigest. 
        /// <para>
        /// The layer digest that's associated with the failure.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string LayerDigest
        {
            get { return this._layerDigest; }
            set { this._layerDigest = value; }
        }

        // Check to see if LayerDigest property is set
        internal bool IsSetLayerDigest()
        {
            return this._layerDigest != null;
        }

    }
}