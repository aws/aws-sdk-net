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
 * Do not modify this file. This file is generated from the tnb-2008-10-21.normal.json service model.
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
namespace Amazon.Tnb.Model
{
    /// <summary>
    /// Lifecycle management operation details on the network instance.
    /// 
    ///  
    /// <para>
    /// Lifecycle management operations are deploy, update, or delete operations.
    /// </para>
    /// </summary>
    public partial class LcmOperationInfo
    {
        private string _nsLcmOpOccId;

        /// <summary>
        /// Gets and sets the property NsLcmOpOccId. 
        /// <para>
        /// The identifier of the network operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NsLcmOpOccId
        {
            get { return this._nsLcmOpOccId; }
            set { this._nsLcmOpOccId = value; }
        }

        // Check to see if NsLcmOpOccId property is set
        internal bool IsSetNsLcmOpOccId()
        {
            return this._nsLcmOpOccId != null;
        }

    }
}