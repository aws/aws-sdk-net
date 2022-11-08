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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FMS.Model
{
    /// <summary>
    /// This is the response object from the BatchDisassociateResource operation.
    /// </summary>
    public partial class BatchDisassociateResourceResponse : AmazonWebServiceResponse
    {
        private List<FailedItem> _failedItems = new List<FailedItem>();
        private string _resourceSetIdentifier;

        /// <summary>
        /// Gets and sets the property FailedItems. 
        /// <para>
        /// The resources that failed to disassociate from the resource set.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<FailedItem> FailedItems
        {
            get { return this._failedItems; }
            set { this._failedItems = value; }
        }

        // Check to see if FailedItems property is set
        internal bool IsSetFailedItems()
        {
            return this._failedItems != null && this._failedItems.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceSetIdentifier. 
        /// <para>
        /// A unique identifier for the resource set, used in a TODO to refer to the resource
        /// set.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ResourceSetIdentifier
        {
            get { return this._resourceSetIdentifier; }
            set { this._resourceSetIdentifier = value; }
        }

        // Check to see if ResourceSetIdentifier property is set
        internal bool IsSetResourceSetIdentifier()
        {
            return this._resourceSetIdentifier != null;
        }

    }
}