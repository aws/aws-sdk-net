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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// This is the response object from the DeleteObjectAnnotation operation.
    /// </summary>
    public partial class DeleteObjectAnnotationResponse : AmazonWebServiceResponse
    {
        private string _objectVersionId;
        private RequestCharged _requestCharged;

        /// <summary>
        /// Gets and sets the property ObjectVersionId. 
        /// <para>
        /// The version ID of the object that the annotation was deleted from.
        /// </para>
        /// </summary>
        public string ObjectVersionId
        {
            get { return this._objectVersionId; }
            set { this._objectVersionId = value; }
        }

        // Check to see if ObjectVersionId property is set
        internal bool IsSetObjectVersionId()
        {
            return this._objectVersionId != null;
        }

        /// <summary>
        /// Gets and sets the property RequestCharged.
        /// </summary>
        public RequestCharged RequestCharged
        {
            get { return this._requestCharged; }
            set { this._requestCharged = value; }
        }

        // Check to see if RequestCharged property is set
        internal bool IsSetRequestCharged()
        {
            return this._requestCharged != null;
        }

    }
}