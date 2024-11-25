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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Synthetics.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteCanary operation.
    /// Permanently deletes the specified canary.
    /// 
    ///  
    /// <para>
    /// If the canary's <c>ProvisionedResourceCleanup</c> field is set to <c>AUTOMATIC</c>
    /// or you specify <c>DeleteLambda</c> in this operation as <c>true</c>, CloudWatch Synthetics
    /// also deletes the Lambda functions and layers that are used by the canary.
    /// </para>
    ///  
    /// <para>
    /// Other resources used and created by the canary are not automatically deleted. After
    /// you delete a canary, you should also delete the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The CloudWatch alarms created for this canary. These alarms have a name of <c>Synthetics-Alarm-<i>first-198-characters-of-canary-name</i>-<i>canaryId</i>-<i>alarm
    /// number</i> </c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon S3 objects and buckets, such as the canary's artifact location.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// IAM roles created for the canary. If they were created in the console, these roles
    /// have the name <c> role/service-role/CloudWatchSyntheticsRole-<i>First-21-Characters-of-CanaryName</i>
    /// </c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// CloudWatch Logs log groups created for the canary. These logs groups have the name
    /// <c>/aws/lambda/cwsyn-<i>First-21-Characters-of-CanaryName</i> </c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Before you delete a canary, you might want to use <c>GetCanary</c> to display the
    /// information about this canary. Make note of the information returned by this operation
    /// so that you can delete these resources after you delete the canary.
    /// </para>
    /// </summary>
    public partial class DeleteCanaryRequest : AmazonSyntheticsRequest
    {
        private bool? _deleteLambda;
        private string _name;

        /// <summary>
        /// Gets and sets the property DeleteLambda. 
        /// <para>
        /// Specifies whether to also delete the Lambda functions and layers used by this canary.
        /// The default is <c>false</c>.
        /// </para>
        ///  
        /// <para>
        /// Your setting for this parameter is used only if the canary doesn't have <c>AUTOMATIC</c>
        /// for its <c>ProvisionedResourceCleanup</c> field. If that field is set to <c>AUTOMATIC</c>,
        /// then the Lambda functions and layers will be deleted when this canary is deleted.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Type: Boolean
        /// </para>
        /// </summary>
        public bool? DeleteLambda
        {
            get { return this._deleteLambda; }
            set { this._deleteLambda = value; }
        }

        // Check to see if DeleteLambda property is set
        internal bool IsSetDeleteLambda()
        {
            return this._deleteLambda.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the canary that you want to delete. To find the names of your canaries,
        /// use <a href="https://docs.aws.amazon.com/AmazonSynthetics/latest/APIReference/API_DescribeCanaries.html">DescribeCanaries</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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