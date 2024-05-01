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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
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
namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// This is the response object from the DescribeCopyProductStatus operation.
    /// </summary>
    public partial class DescribeCopyProductStatusResponse : AmazonWebServiceResponse
    {
        private CopyProductStatus _copyProductStatus;
        private string _statusDetail;
        private string _targetProductId;

        /// <summary>
        /// Gets and sets the property CopyProductStatus. 
        /// <para>
        /// The status of the copy product operation.
        /// </para>
        /// </summary>
        public CopyProductStatus CopyProductStatus
        {
            get { return this._copyProductStatus; }
            set { this._copyProductStatus = value; }
        }

        // Check to see if CopyProductStatus property is set
        internal bool IsSetCopyProductStatus()
        {
            return this._copyProductStatus != null;
        }

        /// <summary>
        /// Gets and sets the property StatusDetail. 
        /// <para>
        /// The status message.
        /// </para>
        /// </summary>
        public string StatusDetail
        {
            get { return this._statusDetail; }
            set { this._statusDetail = value; }
        }

        // Check to see if StatusDetail property is set
        internal bool IsSetStatusDetail()
        {
            return this._statusDetail != null;
        }

        /// <summary>
        /// Gets and sets the property TargetProductId. 
        /// <para>
        /// The identifier of the copied product.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string TargetProductId
        {
            get { return this._targetProductId; }
            set { this._targetProductId = value; }
        }

        // Check to see if TargetProductId property is set
        internal bool IsSetTargetProductId()
        {
            return this._targetProductId != null;
        }

    }
}