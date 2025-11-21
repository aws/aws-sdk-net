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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
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
namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// This is the response object from the AddApplicationVpcConfiguration operation.
    /// </summary>
    public partial class AddApplicationVpcConfigurationResponse : AmazonWebServiceResponse
    {
        private string _applicationARN;
        private long? _applicationVersionId;
        private string _operationId;
        private VpcConfigurationDescription _vpcConfigurationDescription;

        /// <summary>
        /// Gets and sets the property ApplicationARN. 
        /// <para>
        /// The ARN of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ApplicationARN
        {
            get { return this._applicationARN; }
            set { this._applicationARN = value; }
        }

        // Check to see if ApplicationARN property is set
        internal bool IsSetApplicationARN()
        {
            return this._applicationARN != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationVersionId. 
        /// <para>
        /// Provides the current application version. Managed Service for Apache Flink updates
        /// the ApplicationVersionId each time you update the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=999999999)]
        public long? ApplicationVersionId
        {
            get { return this._applicationVersionId; }
            set { this._applicationVersionId = value; }
        }

        // Check to see if ApplicationVersionId property is set
        internal bool IsSetApplicationVersionId()
        {
            return this._applicationVersionId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OperationId. 
        /// <para>
        /// The operation ID that can be used to track the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string OperationId
        {
            get { return this._operationId; }
            set { this._operationId = value; }
        }

        // Check to see if OperationId property is set
        internal bool IsSetOperationId()
        {
            return this._operationId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConfigurationDescription. 
        /// <para>
        /// The parameters of the new VPC configuration.
        /// </para>
        /// </summary>
        public VpcConfigurationDescription VpcConfigurationDescription
        {
            get { return this._vpcConfigurationDescription; }
            set { this._vpcConfigurationDescription = value; }
        }

        // Check to see if VpcConfigurationDescription property is set
        internal bool IsSetVpcConfigurationDescription()
        {
            return this._vpcConfigurationDescription != null;
        }

    }
}