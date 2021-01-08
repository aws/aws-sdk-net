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

namespace Amazon.Personalize.Model
{
    /// <summary>
    /// Container for the parameters to the CreateEventTracker operation.
    /// Creates an event tracker that you use when sending event data to the specified dataset
    /// group using the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_UBS_PutEvents.html">PutEvents</a>
    /// API.
    /// 
    ///  
    /// <para>
    /// When Amazon Personalize creates an event tracker, it also creates an <i>event-interactions</i>
    /// dataset in the dataset group associated with the event tracker. The event-interactions
    /// dataset stores the event data from the <code>PutEvents</code> call. The contents of
    /// this dataset are not available to the user.
    /// </para>
    ///  <note> 
    /// <para>
    /// Only one event tracker can be associated with a dataset group. You will get an error
    /// if you call <code>CreateEventTracker</code> using the same dataset group as an existing
    /// event tracker.
    /// </para>
    ///  </note> 
    /// <para>
    /// When you send event data you include your tracking ID. The tracking ID identifies
    /// the customer and authorizes the customer to send the data.
    /// </para>
    ///  
    /// <para>
    /// The event tracker can be in one of the following states:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// CREATE PENDING &gt; CREATE IN_PROGRESS &gt; ACTIVE -or- CREATE FAILED
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// DELETE PENDING &gt; DELETE IN_PROGRESS
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To get the status of the event tracker, call <a>DescribeEventTracker</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// The event tracker must be in the ACTIVE state before using the tracking ID.
    /// </para>
    ///  </note> <p class="title"> <b>Related APIs</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>ListEventTrackers</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeEventTracker</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteEventTracker</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateEventTrackerRequest : AmazonPersonalizeRequest
    {
        private string _datasetGroupArn;
        private string _name;

        /// <summary>
        /// Gets and sets the property DatasetGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the dataset group that receives the event data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string DatasetGroupArn
        {
            get { return this._datasetGroupArn; }
            set { this._datasetGroupArn = value; }
        }

        // Check to see if DatasetGroupArn property is set
        internal bool IsSetDatasetGroupArn()
        {
            return this._datasetGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the event tracker.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
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