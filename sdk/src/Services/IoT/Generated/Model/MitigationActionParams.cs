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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// The set of parameters for this mitigation action. You can specify only one type of
    /// parameter (in other words, you can apply only one action for each defined mitigation
    /// action).
    /// </summary>
    public partial class MitigationActionParams
    {
        private AddThingsToThingGroupParams _addThingsToThingGroupParams;
        private EnableIoTLoggingParams _enableIoTLoggingParams;
        private PublishFindingToSnsParams _publishFindingToSnsParams;
        private ReplaceDefaultPolicyVersionParams _replaceDefaultPolicyVersionParams;
        private UpdateCACertificateParams _updatecaCertificateParams;
        private UpdateDeviceCertificateParams _updateDeviceCertificateParams;

        /// <summary>
        /// Gets and sets the property AddThingsToThingGroupParams. 
        /// <para>
        /// Parameters to define a mitigation action that moves devices associated with a certificate
        /// to one or more specified thing groups, typically for quarantine.
        /// </para>
        /// </summary>
        public AddThingsToThingGroupParams AddThingsToThingGroupParams
        {
            get { return this._addThingsToThingGroupParams; }
            set { this._addThingsToThingGroupParams = value; }
        }

        // Check to see if AddThingsToThingGroupParams property is set
        internal bool IsSetAddThingsToThingGroupParams()
        {
            return this._addThingsToThingGroupParams != null;
        }

        /// <summary>
        /// Gets and sets the property EnableIoTLoggingParams. 
        /// <para>
        /// Parameters to define a mitigation action that enables Amazon Web Services IoT Core
        /// logging at a specified level of detail.
        /// </para>
        /// </summary>
        public EnableIoTLoggingParams EnableIoTLoggingParams
        {
            get { return this._enableIoTLoggingParams; }
            set { this._enableIoTLoggingParams = value; }
        }

        // Check to see if EnableIoTLoggingParams property is set
        internal bool IsSetEnableIoTLoggingParams()
        {
            return this._enableIoTLoggingParams != null;
        }

        /// <summary>
        /// Gets and sets the property PublishFindingToSnsParams. 
        /// <para>
        /// Parameters to define a mitigation action that publishes findings to Amazon Simple
        /// Notification Service (Amazon SNS. You can implement your own custom actions in response
        /// to the Amazon SNS messages.
        /// </para>
        /// </summary>
        public PublishFindingToSnsParams PublishFindingToSnsParams
        {
            get { return this._publishFindingToSnsParams; }
            set { this._publishFindingToSnsParams = value; }
        }

        // Check to see if PublishFindingToSnsParams property is set
        internal bool IsSetPublishFindingToSnsParams()
        {
            return this._publishFindingToSnsParams != null;
        }

        /// <summary>
        /// Gets and sets the property ReplaceDefaultPolicyVersionParams. 
        /// <para>
        /// Parameters to define a mitigation action that adds a blank policy to restrict permissions.
        /// </para>
        /// </summary>
        public ReplaceDefaultPolicyVersionParams ReplaceDefaultPolicyVersionParams
        {
            get { return this._replaceDefaultPolicyVersionParams; }
            set { this._replaceDefaultPolicyVersionParams = value; }
        }

        // Check to see if ReplaceDefaultPolicyVersionParams property is set
        internal bool IsSetReplaceDefaultPolicyVersionParams()
        {
            return this._replaceDefaultPolicyVersionParams != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateCACertificateParams. 
        /// <para>
        /// Parameters to define a mitigation action that changes the state of the CA certificate
        /// to inactive.
        /// </para>
        /// </summary>
        public UpdateCACertificateParams UpdateCACertificateParams
        {
            get { return this._updatecaCertificateParams; }
            set { this._updatecaCertificateParams = value; }
        }

        // Check to see if UpdateCACertificateParams property is set
        internal bool IsSetUpdateCACertificateParams()
        {
            return this._updatecaCertificateParams != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateDeviceCertificateParams. 
        /// <para>
        /// Parameters to define a mitigation action that changes the state of the device certificate
        /// to inactive.
        /// </para>
        /// </summary>
        public UpdateDeviceCertificateParams UpdateDeviceCertificateParams
        {
            get { return this._updateDeviceCertificateParams; }
            set { this._updateDeviceCertificateParams = value; }
        }

        // Check to see if UpdateDeviceCertificateParams property is set
        internal bool IsSetUpdateDeviceCertificateParams()
        {
            return this._updateDeviceCertificateParams != null;
        }

    }
}