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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about traffic distribution groups.
    /// </summary>
    public partial class TrafficDistributionGroupSummary
    {
        private string _arn;
        private string _id;
        private string _instanceArn;
        private bool? _isDefault;
        private string _name;
        private TrafficDistributionGroupStatus _status;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the traffic distribution group.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the traffic distribution group. This can be the ID or the ARN if
        /// the API is being called in the Region where the traffic distribution group was created.
        /// The ARN must be provided if the call is from the replicated Region.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property InstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the traffic distribution group.
        /// </para>
        /// </summary>
        public string InstanceArn
        {
            get { return this._instanceArn; }
            set { this._instanceArn = value; }
        }

        // Check to see if InstanceArn property is set
        internal bool IsSetInstanceArn()
        {
            return this._instanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property IsDefault. 
        /// <para>
        /// Whether this is the default traffic distribution group created during instance replication.
        /// The default traffic distribution group cannot be deleted by the <c>DeleteTrafficDistributionGroup</c>
        /// API. The default traffic distribution group is deleted as part of the process for
        /// deleting a replica.
        /// </para>
        /// </summary>
        public bool? IsDefault
        {
            get { return this._isDefault; }
            set { this._isDefault = value; }
        }

        // Check to see if IsDefault property is set
        internal bool IsSetIsDefault()
        {
            return this._isDefault.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the traffic distribution group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the traffic distribution group. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATION_IN_PROGRESS</c> means the previous <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_CreateTrafficDistributionGroup.html">CreateTrafficDistributionGroup</a>
        /// operation is still in progress and has not yet completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c> means the previous <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_CreateTrafficDistributionGroup.html">CreateTrafficDistributionGroup</a>
        /// operation has succeeded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATION_FAILED</c> indicates that the previous <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_CreateTrafficDistributionGroup.html">CreateTrafficDistributionGroup</a>
        /// operation has failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING_DELETION</c> means the previous <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_DeleteTrafficDistributionGroup.html">DeleteTrafficDistributionGroup</a>
        /// operation is still in progress and has not yet completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETION_FAILED</c> means the previous <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_DeleteTrafficDistributionGroup.html">DeleteTrafficDistributionGroup</a>
        /// operation has failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATE_IN_PROGRESS</c> means the previous <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_UpdateTrafficDistributionGroup.html">UpdateTrafficDistributionGroup</a>
        /// operation is still in progress and has not yet completed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TrafficDistributionGroupStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}