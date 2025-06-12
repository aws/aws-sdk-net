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
 * Do not modify this file. This file is generated from the cloudhsm-2014-05-30.normal.json service model.
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
namespace Amazon.CloudHSM.Model
{
    /// <summary>
    /// Contains the output of the <a>DescribeHapg</a> action.
    /// </summary>
    public partial class DescribeHapgResponse : AmazonWebServiceResponse
    {
        private string _hapgArn;
        private string _hapgSerial;
        private List<string> _hsmsLastActionFailed = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _hsmsPendingDeletion = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _hsmsPendingRegistration = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _label;
        private string _lastModifiedTimestamp;
        private List<string> _partitionSerialList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private CloudHsmObjectState _state;

        /// <summary>
        /// Gets and sets the property HapgArn. 
        /// <para>
        /// The ARN of the high-availability partition group.
        /// </para>
        /// </summary>
        public string HapgArn
        {
            get { return this._hapgArn; }
            set { this._hapgArn = value; }
        }

        // Check to see if HapgArn property is set
        internal bool IsSetHapgArn()
        {
            return this._hapgArn != null;
        }

        /// <summary>
        /// Gets and sets the property HapgSerial. 
        /// <para>
        /// The serial number of the high-availability partition group.
        /// </para>
        /// </summary>
        public string HapgSerial
        {
            get { return this._hapgSerial; }
            set { this._hapgSerial = value; }
        }

        // Check to see if HapgSerial property is set
        internal bool IsSetHapgSerial()
        {
            return this._hapgSerial != null;
        }

        /// <summary>
        /// Gets and sets the property HsmsLastActionFailed.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> HsmsLastActionFailed
        {
            get { return this._hsmsLastActionFailed; }
            set { this._hsmsLastActionFailed = value; }
        }

        // Check to see if HsmsLastActionFailed property is set
        internal bool IsSetHsmsLastActionFailed()
        {
            return this._hsmsLastActionFailed != null && (this._hsmsLastActionFailed.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property HsmsPendingDeletion.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> HsmsPendingDeletion
        {
            get { return this._hsmsPendingDeletion; }
            set { this._hsmsPendingDeletion = value; }
        }

        // Check to see if HsmsPendingDeletion property is set
        internal bool IsSetHsmsPendingDeletion()
        {
            return this._hsmsPendingDeletion != null && (this._hsmsPendingDeletion.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property HsmsPendingRegistration.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> HsmsPendingRegistration
        {
            get { return this._hsmsPendingRegistration; }
            set { this._hsmsPendingRegistration = value; }
        }

        // Check to see if HsmsPendingRegistration property is set
        internal bool IsSetHsmsPendingRegistration()
        {
            return this._hsmsPendingRegistration != null && (this._hsmsPendingRegistration.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// The label for the high-availability partition group.
        /// </para>
        /// </summary>
        public string Label
        {
            get { return this._label; }
            set { this._label = value; }
        }

        // Check to see if Label property is set
        internal bool IsSetLabel()
        {
            return this._label != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTimestamp. 
        /// <para>
        /// The date and time the high-availability partition group was last modified.
        /// </para>
        /// </summary>
        public string LastModifiedTimestamp
        {
            get { return this._lastModifiedTimestamp; }
            set { this._lastModifiedTimestamp = value; }
        }

        // Check to see if LastModifiedTimestamp property is set
        internal bool IsSetLastModifiedTimestamp()
        {
            return this._lastModifiedTimestamp != null;
        }

        /// <summary>
        /// Gets and sets the property PartitionSerialList. 
        /// <para>
        /// The list of partition serial numbers that belong to the high-availability partition
        /// group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PartitionSerialList
        {
            get { return this._partitionSerialList; }
            set { this._partitionSerialList = value; }
        }

        // Check to see if PartitionSerialList property is set
        internal bool IsSetPartitionSerialList()
        {
            return this._partitionSerialList != null && (this._partitionSerialList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the high-availability partition group.
        /// </para>
        /// </summary>
        public CloudHsmObjectState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}