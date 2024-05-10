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
    /// Container for the parameters to the DisableFederation operation.
    /// Disables Lake query federation on the specified event data store. When you disable
    /// federation, CloudTrail disables the integration with Glue, Lake Formation, and Amazon
    /// Athena. After disabling Lake query federation, you can no longer query your event
    /// data in Amazon Athena.
    /// 
    ///  
    /// <para>
    /// No CloudTrail Lake data is deleted when you disable federation and you can continue
    /// to run queries in CloudTrail Lake.
    /// </para>
    /// </summary>
    public partial class DisableFederationRequest : AmazonCloudTrailRequest
    {
        private string _eventDataStore;

        /// <summary>
        /// Gets and sets the property EventDataStore. 
        /// <para>
        ///  The ARN (or ID suffix of the ARN) of the event data store for which you want to disable
        /// Lake query federation. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=256)]
        public string EventDataStore
        {
            get { return this._eventDataStore; }
            set { this._eventDataStore = value; }
        }

        // Check to see if EventDataStore property is set
        internal bool IsSetEventDataStore()
        {
            return this._eventDataStore != null;
        }

    }
}