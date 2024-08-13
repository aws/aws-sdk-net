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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
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
namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteTrust operation.
    /// Deletes an existing trust relationship between your Managed Microsoft AD directory
    /// and an external domain.
    /// </summary>
    public partial class DeleteTrustRequest : AmazonDirectoryServiceRequest
    {
        private bool? _deleteAssociatedConditionalForwarder;
        private string _trustId;

        /// <summary>
        /// Gets and sets the property DeleteAssociatedConditionalForwarder. 
        /// <para>
        /// Delete a conditional forwarder as part of a DeleteTrustRequest.
        /// </para>
        /// </summary>
        public bool? DeleteAssociatedConditionalForwarder
        {
            get { return this._deleteAssociatedConditionalForwarder; }
            set { this._deleteAssociatedConditionalForwarder = value; }
        }

        // Check to see if DeleteAssociatedConditionalForwarder property is set
        internal bool IsSetDeleteAssociatedConditionalForwarder()
        {
            return this._deleteAssociatedConditionalForwarder.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrustId. 
        /// <para>
        /// The Trust ID of the trust relationship to be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TrustId
        {
            get { return this._trustId; }
            set { this._trustId = value; }
        }

        // Check to see if TrustId property is set
        internal bool IsSetTrustId()
        {
            return this._trustId != null;
        }

    }
}