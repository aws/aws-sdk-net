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
 * Do not modify this file. This file is generated from the synthetics-2017-10-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Synthetics.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteCanary operation.
    /// Permanently deletes the specified canary.
    /// 
    ///  
    /// <para>
    /// When you delete a canary, resources used and created by the canary are not automatically
    /// deleted. After you delete a canary that you do not intend to use again, you should
    /// also delete the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The Lambda functions and layers used by this canary. These have the prefix <code>cwsyn-<i>MyCanaryName</i>
    /// </code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The CloudWatch alarms created for this canary. These alarms have a name of <code>Synthetics-SharpDrop-Alarm-<i>MyCanaryName</i>
    /// </code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon S3 objects and buckets, such as the canary's artifact location.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// IAM roles created for the canary. If they were created in the console, these roles
    /// have the name <code> role/service-role/CloudWatchSyntheticsRole-<i>MyCanaryName</i>
    /// </code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// CloudWatch Logs log groups created for the canary. These logs groups have the name
    /// <code>/aws/lambda/cwsyn-<i>MyCanaryName</i> </code>. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Before you delete a canary, you might want to use <code>GetCanary</code> to display
    /// the information about this canary. Make note of the information returned by this operation
    /// so that you can delete these resources after you delete the canary.
    /// </para>
    /// </summary>
    public partial class DeleteCanaryRequest : AmazonSyntheticsRequest
    {
        private string _name;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the canary that you want to delete. To find the names of your canaries,
        /// use <a href="https://docs.aws.amazon.com/AmazonSynthetics/latest/APIReference/API_DescribeCanaries.html">DescribeCanaries</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=21)]
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

    }
}