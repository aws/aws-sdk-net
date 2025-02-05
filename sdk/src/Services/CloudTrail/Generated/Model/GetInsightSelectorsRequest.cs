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
    /// Container for the parameters to the GetInsightSelectors operation.
    /// Describes the settings for the Insights event selectors that you configured for your
    /// trail or event data store. <c>GetInsightSelectors</c> shows if CloudTrail Insights
    /// event logging is enabled on the trail or event data store, and if it is, which Insights
    /// types are enabled. If you run <c>GetInsightSelectors</c> on a trail or event data
    /// store that does not have Insights events enabled, the operation throws the exception
    /// <c>InsightNotEnabledException</c> 
    /// 
    ///  
    /// <para>
    /// Specify either the <c>EventDataStore</c> parameter to get Insights event selectors
    /// for an event data store, or the <c>TrailName</c> parameter to the get Insights event
    /// selectors for a trail. You cannot specify these parameters together.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-insights-events-with-cloudtrail.html">Working
    /// with CloudTrail Insights</a> in the <i>CloudTrail User Guide</i>.
    /// </para>
    /// </summary>
    public partial class GetInsightSelectorsRequest : AmazonCloudTrailRequest
    {
        private string _eventDataStore;
        private string _trailName;

        /// <summary>
        /// Gets and sets the property EventDataStore. 
        /// <para>
        ///  Specifies the ARN (or ID suffix of the ARN) of the event data store for which you
        /// want to get Insights selectors. 
        /// </para>
        ///  
        /// <para>
        /// You cannot use this parameter with the <c>TrailName</c> parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=256)]
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

        /// <summary>
        /// Gets and sets the property TrailName. 
        /// <para>
        /// Specifies the name of the trail or trail ARN. If you specify a trail name, the string
        /// must meet the following requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you specify a trail ARN, it must be in the format:
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c> 
        /// </para>
        ///  
        /// <para>
        /// You cannot use this parameter with the <c>EventDataStore</c> parameter.
        /// </para>
        /// </summary>
        public string TrailName
        {
            get { return this._trailName; }
            set { this._trailName = value; }
        }

        // Check to see if TrailName property is set
        internal bool IsSetTrailName()
        {
            return this._trailName != null;
        }

    }
}