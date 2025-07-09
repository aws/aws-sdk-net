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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
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
namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteTrainedModelOutput operation.
    /// Deletes the model artifacts stored by the service.
    /// </summary>
    public partial class DeleteTrainedModelOutputRequest : AmazonCleanRoomsMLRequest
    {
        private string _membershipIdentifier;
        private string _trainedModelArn;
        private string _versionIdentifier;

        /// <summary>
        /// Gets and sets the property MembershipIdentifier. 
        /// <para>
        /// The membership ID of the member that is deleting the trained model output.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string MembershipIdentifier
        {
            get { return this._membershipIdentifier; }
            set { this._membershipIdentifier = value; }
        }

        // Check to see if MembershipIdentifier property is set
        internal bool IsSetMembershipIdentifier()
        {
            return this._membershipIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property TrainedModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the trained model whose output you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string TrainedModelArn
        {
            get { return this._trainedModelArn; }
            set { this._trainedModelArn = value; }
        }

        // Check to see if TrainedModelArn property is set
        internal bool IsSetTrainedModelArn()
        {
            return this._trainedModelArn != null;
        }

        /// <summary>
        /// Gets and sets the property VersionIdentifier. 
        /// <para>
        /// The version identifier of the trained model to delete. If not specified, the operation
        /// will delete the base version of the trained model. When specified, only the particular
        /// version will be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string VersionIdentifier
        {
            get { return this._versionIdentifier; }
            set { this._versionIdentifier = value; }
        }

        // Check to see if VersionIdentifier property is set
        internal bool IsSetVersionIdentifier()
        {
            return this._versionIdentifier != null;
        }

    }
}