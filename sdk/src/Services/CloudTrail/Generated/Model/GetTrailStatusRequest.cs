/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Container for the parameters to the GetTrailStatus operation.
    /// Returns a JSON-formatted list of information about the specified trail. Fields include
    /// information on delivery errors, Amazon SNS and Amazon S3 errors, and start and stop
    /// logging times for each trail. This operation returns trail status from a single region.
    /// To return trail status from all regions, you must call the operation on each region.
    /// </summary>
    public partial class GetTrailStatusRequest : AmazonCloudTrailRequest
    {
        private string _name;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Specifies the name or the CloudTrail ARN of the trail for which you are requesting
        /// status. To get the status of a shadow trail (a replication of the trail in another
        /// region), you must specify its ARN. The format of a trail ARN is:
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:cloudtrail:us-east-1:123456789012:trail/MyTrail</code> 
        /// </para>
        /// </summary>
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