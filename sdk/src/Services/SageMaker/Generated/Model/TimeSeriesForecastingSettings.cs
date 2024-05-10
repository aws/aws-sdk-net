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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Time series forecast settings for the SageMaker Canvas application.
    /// </summary>
    public partial class TimeSeriesForecastingSettings
    {
        private string _amazonForecastRoleArn;
        private FeatureStatus _status;

        /// <summary>
        /// Gets and sets the property AmazonForecastRoleArn. 
        /// <para>
        /// The IAM role that Canvas passes to Amazon Forecast for time series forecasting. By
        /// default, Canvas uses the execution role specified in the <c>UserProfile</c> that launches
        /// the Canvas application. If an execution role is not specified in the <c>UserProfile</c>,
        /// Canvas uses the execution role specified in the Domain that owns the <c>UserProfile</c>.
        /// To allow time series forecasting, this IAM role should have the <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/security-iam-awsmanpol-canvas.html#security-iam-awsmanpol-AmazonSageMakerCanvasForecastAccess">
        /// AmazonSageMakerCanvasForecastAccess</a> policy attached and <c>forecast.amazonaws.com</c>
        /// added in the trust relationship as a service principal.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string AmazonForecastRoleArn
        {
            get { return this._amazonForecastRoleArn; }
            set { this._amazonForecastRoleArn = value; }
        }

        // Check to see if AmazonForecastRoleArn property is set
        internal bool IsSetAmazonForecastRoleArn()
        {
            return this._amazonForecastRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Describes whether time series forecasting is enabled or disabled in the Canvas application.
        /// </para>
        /// </summary>
        public FeatureStatus Status
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