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
    /// Container for the parameters to the DeleteShare operation.
    /// Deletes a resource share. If you are the resource owner, the subscriber will no longer
    /// have access to the shared resource. If you are the subscriber, this operation deletes
    /// your access to the share.
    /// </summary>
    public partial class DeleteShareRequest : AmazonOmicsRequest
    {
        private string _shareId;

        /// <summary>
        /// Gets and sets the property ShareId. 
        /// <para>
        /// The ID for the resource share to be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ShareId
        {
            get { return this._shareId; }
            set { this._shareId = value; }
        }

        // Check to see if ShareId property is set
        internal bool IsSetShareId()
        {
            return this._shareId != null;
        }

    }
}