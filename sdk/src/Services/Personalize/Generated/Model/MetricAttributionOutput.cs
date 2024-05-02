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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
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
namespace Amazon.Personalize.Model
{
    /// <summary>
    /// The output configuration details for a metric attribution.
    /// </summary>
    public partial class MetricAttributionOutput
    {
        private string _roleArn;
        private S3DataConfig _s3DataDestination;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM service role that has permissions to add
        /// data to your output Amazon S3 bucket and add metrics to Amazon CloudWatch. For more
        /// information, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/measuring-recommendation-impact.html">Measuring
        /// impact of recommendations</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property S3DataDestination.
        /// </summary>
        public S3DataConfig S3DataDestination
        {
            get { return this._s3DataDestination; }
            set { this._s3DataDestination = value; }
        }

        // Check to see if S3DataDestination property is set
        internal bool IsSetS3DataDestination()
        {
            return this._s3DataDestination != null;
        }

    }
}