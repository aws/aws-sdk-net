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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the GetFlowLogsIntegrationTemplate operation.
    /// Generates a CloudFormation template that streamlines and automates the integration
    /// of VPC flow logs with Amazon Athena. This make it easier for you to query and gain
    /// insights from VPC flow logs data. Based on the information that you provide, we configure
    /// resources in the template to do the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Create a table in Athena that maps fields to a custom log format
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Create a Lambda function that updates the table with new partitions on a daily, weekly,
    /// or monthly basis
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Create a table partitioned between two timestamps in the past
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Create a set of named queries in Athena that you can use to get started quickly
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    ///  <c>GetFlowLogsIntegrationTemplate</c> does not support integration between Amazon
    /// Web Services Transit Gateway Flow Logs and Amazon Athena.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetFlowLogsIntegrationTemplateRequest : AmazonEC2Request
    {
        private string _configDeliveryS3DestinationArn;
        private bool? _dryRun;
        private string _flowLogId;
        private IntegrateServices _integrateServices;

        /// <summary>
        /// Gets and sets the property ConfigDeliveryS3DestinationArn. 
        /// <para>
        /// To store the CloudFormation template in Amazon S3, specify the location in Amazon
        /// S3.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConfigDeliveryS3DestinationArn
        {
            get { return this._configDeliveryS3DestinationArn; }
            set { this._configDeliveryS3DestinationArn = value; }
        }

        // Check to see if ConfigDeliveryS3DestinationArn property is set
        internal bool IsSetConfigDeliveryS3DestinationArn()
        {
            return this._configDeliveryS3DestinationArn != null;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FlowLogId. 
        /// <para>
        /// The ID of the flow log.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FlowLogId
        {
            get { return this._flowLogId; }
            set { this._flowLogId = value; }
        }

        // Check to see if FlowLogId property is set
        internal bool IsSetFlowLogId()
        {
            return this._flowLogId != null;
        }

        /// <summary>
        /// Gets and sets the property IntegrateServices. 
        /// <para>
        /// Information about the service integration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IntegrateServices IntegrateServices
        {
            get { return this._integrateServices; }
            set { this._integrateServices = value; }
        }

        // Check to see if IntegrateServices property is set
        internal bool IsSetIntegrateServices()
        {
            return this._integrateServices != null;
        }

    }
}