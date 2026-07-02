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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
namespace Amazon.EKS.Model
{
    /// <summary>
    /// Container for the parameters to the CancelUpdate operation.
    /// Cancels an in-progress update to an Amazon EKS cluster on a best-effort basis. Cancellation
    /// is only performed if the update can be cancelled. Currently, this is supported for
    /// <c>VersionRollback</c> update types on EKS Auto Mode clusters when nodes are rolling
    /// back.
    /// 
    ///  
    /// <para>
    /// A successful cancellation stops the node rollback. After cancellation, nodes converge
    /// to the current cluster version honoring configured disruption controls. If the control
    /// plane rollback has already begun, the cancellation request fails.
    /// </para>
    /// </summary>
    public partial class CancelUpdateRequest : AmazonEKSRequest
    {
        private string _clientRequestToken;
        private string _name;
        private string _updateId;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Amazon EKS cluster associated with the update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateId. 
        /// <para>
        /// The ID of the update to cancel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string UpdateId
        {
            get { return this._updateId; }
            set { this._updateId = value; }
        }

        // Check to see if UpdateId property is set
        internal bool IsSetUpdateId()
        {
            return this._updateId != null;
        }

    }
}