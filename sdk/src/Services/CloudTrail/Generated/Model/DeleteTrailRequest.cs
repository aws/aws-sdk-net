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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
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
namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteTrail operation.
    /// Deletes a trail. This operation must be called from the Region in which the trail
    /// was created. <c>DeleteTrail</c> cannot be called on the shadow trails (replicated
    /// trails in other Regions) of a trail that is enabled in all Regions.
    /// 
    ///  <important> 
    /// <para>
    ///  While deleting a CloudTrail trail is an irreversible action, CloudTrail does not
    /// delete log files in the Amazon S3 bucket for that trail, the Amazon S3 bucket itself,
    /// or the CloudWatchlog group to which the trail delivers events. Deleting a multi-Region
    /// trail will stop logging of events in all Amazon Web Services Regions enabled in your
    /// Amazon Web Services account. Deleting a single-Region trail will stop logging of events
    /// in that Region only. It will not stop logging of events in other Regions even if the
    /// trails in those other Regions have identical names to the deleted trail. 
    /// </para>
    ///  
    /// <para>
    /// For information about account closure and deletion of CloudTrail trails, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-account-closure.html">https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-account-closure.html</a>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class DeleteTrailRequest : AmazonCloudTrailRequest
    {
        private string _name;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Specifies the name or the CloudTrail ARN of the trail to be deleted. The following
        /// is the format of a trail ARN. <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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