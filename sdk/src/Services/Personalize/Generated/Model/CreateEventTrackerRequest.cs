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
    /// Container for the parameters to the CreateEventTracker operation.
    /// Creates an event tracker that you use when adding event data to a specified dataset
    /// group using the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_UBS_PutEvents.html">PutEvents</a>
    /// API.
    /// 
    ///  <note> 
    /// <para>
    /// Only one event tracker can be associated with a dataset group. You will get an error
    /// if you call <c>CreateEventTracker</c> using the same dataset group as an existing
    /// event tracker.
    /// </para>
    ///  </note> 
    /// <para>
    /// When you create an event tracker, the response includes a tracking ID, which you pass
    /// as a parameter when you use the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_UBS_PutEvents.html">PutEvents</a>
    /// operation. Amazon Personalize then appends the event data to the Item interactions
    /// dataset of the dataset group you specify in your event tracker. 
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
    /// To get the status of the event tracker, call <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeEventTracker.html">DescribeEventTracker</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// The event tracker must be in the ACTIVE state before using the tracking ID.
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>Related APIs</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_ListEventTrackers.html">ListEventTrackers</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeEventTracker.html">DescribeEventTracker</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DeleteEventTracker.html">DeleteEventTracker</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateEventTrackerRequest : AmazonPersonalizeRequest
    {
        private string _datasetGroupArn;
        private string _name;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of <a href="https://docs.aws.amazon.com/personalize/latest/dg/tagging-resources.html">tags</a>
        /// to apply to the event tracker.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}