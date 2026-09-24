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
 * Do not modify this file. This file is generated from the eventbridgev2-2025-05-15.normal.json service model.
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
namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSubscriber operation.
    /// Updates a subscriber. Fields omitted from the request are left unchanged.
    /// </summary>
    public partial class UpdateSubscriberRequest : AmazonEventBridgeV2Request
    {
        private BatchConfiguration _batchConfiguration;
        private string _description;
        private FilterConfiguration _filterConfiguration;
        private UpdateInvokeConfiguration _invokeConfiguration;
        private LogConfiguration _logConfiguration;
        private OnFailureConfiguration _onFailureConfiguration;
        private ResumePosition _resumePosition;
        private RetryPolicy _retryPolicy;
        private SubscriberState _state;
        private string _subscriberArn;
        private Transformer _transformer;

        /// <summary>
        /// Gets and sets the property BatchConfiguration.
        /// </summary>
        public BatchConfiguration BatchConfiguration
        {
            get { return this._batchConfiguration; }
            set { this._batchConfiguration = value; }
        }

        // Check to see if BatchConfiguration property is set
        internal bool IsSetBatchConfiguration()
        {
            return this._batchConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Description.
        /// </summary>
        [AWSProperty(Min=0, Max=512)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FilterConfiguration.
        /// </summary>
        public FilterConfiguration FilterConfiguration
        {
            get { return this._filterConfiguration; }
            set { this._filterConfiguration = value; }
        }

        // Check to see if FilterConfiguration property is set
        internal bool IsSetFilterConfiguration()
        {
            return this._filterConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property InvokeConfiguration.
        /// </summary>
        public UpdateInvokeConfiguration InvokeConfiguration
        {
            get { return this._invokeConfiguration; }
            set { this._invokeConfiguration = value; }
        }

        // Check to see if InvokeConfiguration property is set
        internal bool IsSetInvokeConfiguration()
        {
            return this._invokeConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property LogConfiguration.
        /// </summary>
        public LogConfiguration LogConfiguration
        {
            get { return this._logConfiguration; }
            set { this._logConfiguration = value; }
        }

        // Check to see if LogConfiguration property is set
        internal bool IsSetLogConfiguration()
        {
            return this._logConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property OnFailureConfiguration.
        /// </summary>
        public OnFailureConfiguration OnFailureConfiguration
        {
            get { return this._onFailureConfiguration; }
            set { this._onFailureConfiguration = value; }
        }

        // Check to see if OnFailureConfiguration property is set
        internal bool IsSetOnFailureConfiguration()
        {
            return this._onFailureConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ResumePosition.
        /// </summary>
        public ResumePosition ResumePosition
        {
            get { return this._resumePosition; }
            set { this._resumePosition = value; }
        }

        // Check to see if ResumePosition property is set
        internal bool IsSetResumePosition()
        {
            return this._resumePosition != null;
        }

        /// <summary>
        /// Gets and sets the property RetryPolicy.
        /// </summary>
        public RetryPolicy RetryPolicy
        {
            get { return this._retryPolicy; }
            set { this._retryPolicy = value; }
        }

        // Check to see if RetryPolicy property is set
        internal bool IsSetRetryPolicy()
        {
            return this._retryPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property State.
        /// </summary>
        public SubscriberState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriberArn.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string SubscriberArn
        {
            get { return this._subscriberArn; }
            set { this._subscriberArn = value; }
        }

        // Check to see if SubscriberArn property is set
        internal bool IsSetSubscriberArn()
        {
            return this._subscriberArn != null;
        }

        /// <summary>
        /// Gets and sets the property Transformer. 
        /// <para>
        /// Not applicable to universal (aws-sdk) targets, whose input transformation is UniversalTargetParameters.Input;
        /// a Transformer on such a target is rejected.
        /// </para>
        /// </summary>
        public Transformer Transformer
        {
            get { return this._transformer; }
            set { this._transformer = value; }
        }

        // Check to see if Transformer property is set
        internal bool IsSetTransformer()
        {
            return this._transformer != null;
        }

    }
}