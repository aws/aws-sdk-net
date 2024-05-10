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
    /// Container for the parameters to the BatchAssociateAnalyticsDataSet operation.
    /// This API is in preview release for Amazon Connect and is subject to change.
    /// 
    ///  
    /// <para>
    /// Associates a list of analytics datasets for a given Amazon Connect instance to a target
    /// account. You can associate multiple datasets in a single call.
    /// </para>
    /// </summary>
    public partial class BatchAssociateAnalyticsDataSetRequest : AmazonConnectRequest
    {
        private List<string> _dataSetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _instanceId;
        private string _targetAccountId;

        /// <summary>
        /// Gets and sets the property DataSetIds. 
        /// <para>
        /// An array of dataset identifiers to associate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> DataSetIds
        {
            get { return this._dataSetIds; }
            set { this._dataSetIds = value; }
        }

        // Check to see if DataSetIds property is set
        internal bool IsSetDataSetIds()
        {
            return this._dataSetIds != null && (this._dataSetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property TargetAccountId. 
        /// <para>
        /// The identifier of the target account. Use to associate a dataset to a different account
        /// than the one containing the Amazon Connect instance. If not specified, by default
        /// this value is the Amazon Web Services account that has the Amazon Connect instance.
        /// </para>
        /// </summary>
        public string TargetAccountId
        {
            get { return this._targetAccountId; }
            set { this._targetAccountId = value; }
        }

        // Check to see if TargetAccountId property is set
        internal bool IsSetTargetAccountId()
        {
            return this._targetAccountId != null;
        }

    }
}