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
    /// Container for the parameters to the StopLogging operation.
    /// Suspends the recording of Amazon Web Services API calls and log file delivery for
    /// the specified trail. Under most circumstances, there is no need to use this action.
    /// You can update a trail without stopping it first. This action is the only way to stop
    /// recording. For a trail enabled in all Regions, this operation must be called from
    /// the Region in which the trail was created, or an <c>InvalidHomeRegionException</c>
    /// will occur. This operation cannot be called on the shadow trails (replicated trails
    /// in other Regions) of a trail enabled in all Regions.
    /// </summary>
    public partial class StopLoggingRequest : AmazonCloudTrailRequest
    {
        private string _name;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Specifies the name or the CloudTrail ARN of the trail for which CloudTrail will stop
        /// logging Amazon Web Services API calls. The following is the format of a trail ARN.
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c> 
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